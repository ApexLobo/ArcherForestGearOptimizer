using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ArcherForestGearOptimizer.Archer;

namespace ArcherForestGearOptimizer {
    public class MachineLearning {
        private Random random = new Random();
        private List<StoneTeam> population = new List<StoneTeam>();
        private int populationSize = 200;
        private int maxGenerations = 100000;
        private double mutationRate = 0.1;
        private List<StoneTeam> bestTeamsFromPreviousRun = new List<StoneTeam>();

        public MachineLearning() {
        }

        private void initializeRandomPopulation() {
            for (int i = 0; i < populationSize; i++) {
                StoneTeam team = new StoneTeam();
                team.generateRandomTeam();
                population.Add(team);
            }
        }
        private void initializePopulationWithBestTeams() {
            population.Clear();

            // Add the best teams from the previous run to the new population
            foreach (var team in bestTeamsFromPreviousRun) {
                population.Add(team.clone());
            }

            // Fill the rest of the population with new random teams
            while (population.Count < populationSize) {
                StoneTeam team = new StoneTeam();
                team.generateRandomTeam();
                population.Add(team);
            }
        }
        public StoneTeam getBestStoneTeam(BackgroundWorker worker, int generationsToRun) {
            if (bestTeamsFromPreviousRun.Count > 0) {
                initializePopulationWithBestTeams();
            } else {
                initializeRandomPopulation();
            }

            double bestFitness = double.MinValue;
            StoneTeam bestTeam = null;

            maxGenerations = generationsToRun;

            for (int generation = 0; generation < maxGenerations; generation++) {
                if (worker.CancellationPending) {
                    break;
                }

                List<double> fitnessScores = evaluateFitness();

                // Find the best team in the current generation
                for (int i = 0; i < fitnessScores.Count; i++) {
                    if (fitnessScores[i] > bestFitness) {
                        bestFitness = fitnessScores[i];
                        bestTeam = population[i];
                    }
                }

                List<StoneTeam> selectedParents = selectBestParents(fitnessScores);
                List<StoneTeam> newGeneration = crossoverAndMutation(selectedParents);
                population = newGeneration;

                // Report progress every 10 generations
                if (generation % 10 == 0) {
                    int progressPercentage = (int)((double)generation / maxGenerations * 100);
                    worker.ReportProgress(progressPercentage, bestFitness);
                }
            }

            // Store the 10 best teams for the next run
            bestTeamsFromPreviousRun = population.OrderByDescending(team => team.calculateTeamArrowLevel()).Take(10).ToList();

            return bestTeam;
        }

        private List<double> evaluateFitness() {
            List<double> fitnessScores = new List<double>();
            foreach (StoneTeam team in population) {
                double fitnessScore = team.calculateTeamArrowLevel();
                fitnessScores.Add(fitnessScore);
            }
            return fitnessScores;
        }

        private List<StoneTeam> selectBestParents(List<double> fitnessScores) {
            List<StoneTeam> selectedParents = new List<StoneTeam>();
            int tournamentSize = 5;

            for (int i = 0; i < populationSize; i++) {
                List<StoneTeam> tournamentParticipants = new List<StoneTeam>();
                for (int j = 0; j < tournamentSize; j++) {
                    int randomIndex = random.Next(population.Count);
                    tournamentParticipants.Add(population[randomIndex]);
                }

                tournamentParticipants = tournamentParticipants.OrderByDescending(team => team.calculateTeamArrowLevel()).ToList();
                selectedParents.Add(tournamentParticipants.First());
            }

            return selectedParents;
        }

        private List<StoneTeam> crossoverAndMutation(List<StoneTeam> parents) {
            List<StoneTeam> newGeneration = new List<StoneTeam>();

            while (newGeneration.Count < populationSize) {
                // Randomly select two parents for crossover
                StoneTeam parent1 = parents[random.Next(parents.Count)];
                StoneTeam parent2 = parents[random.Next(parents.Count)];

                // Create a new team by combining archers from both parents
                StoneTeam childTeam = new StoneTeam();
                HashSet<Archer.ArcherName> usedNames = new HashSet<Archer.ArcherName>();

                for (int i = 0; i < childTeam.teamSize; i++) {
                    Archer selectedArcher;
                    if (i % 2 == 0) {
                        selectedArcher = parent1.archers[i].clone();
                    } else {
                        selectedArcher = parent2.archers[i].clone();
                    }

                    // Ensure no duplicate archer names in the child team
                    if (!usedNames.Add(selectedArcher.name)) {
                        childTeam.mutateArcherNameAtIndex(i); // Ensure unique name
                    }
                    childTeam.archers.Add(selectedArcher);
                }

                // Apply mutations based on the mutation rate
                for (int i = 0; i < childTeam.teamSize; i++) {
                    if (random.NextDouble() < mutationRate) {
                        // Mutate either the gear or the name of the archer
                        if (random.NextDouble() < 0.5) {
                            childTeam.mutateArcherGearAtIndex(i);
                        } else {
                            childTeam.mutateArcherNameAtIndex(i);
                        }
                    }
                }
                childTeam.ensureUniqueGearForEachArcher(); // Ensure gear uniqueness

                newGeneration.Add(childTeam);
            }

            return newGeneration;
        }
    }
}
