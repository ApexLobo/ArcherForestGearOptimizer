using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ArcherForestGearOptimizer.Archer;

namespace ArcherForestGearOptimizer {
    public class StoneTeam {
        public int teamSize = 8;
        public Random random = new Random();
        public List<Archer> archers { get; set; }
        public GearList availableGear { get; set; }

        public StoneTeam() {
            archers = new List<Archer>(teamSize);
            availableGear = GlobalData.gearList.clone();
        }
        public StoneTeam clone() {
            StoneTeam clone = new StoneTeam();
            clone.archers = this.archers.Select(archer => archer.clone()).ToList();
            clone.availableGear = GlobalData.gearList.clone();
            return clone;
        }
        public void ensureUniqueGearForEachArcher() {
            Dictionary<Guid, int> gearUses = new Dictionary<Guid, int>();

            updateAvailableGear();
            foreach (Archer archer in archers) {
                if (archer.equippedBow != null) {
                    if (gearUses.ContainsKey(archer.equippedBow.uid)) {

                        archer.equippedBow = availableGear.getRandomUnusedGearByCategory(Gear.GearCategory.Bow);
                        if (archer.equippedBow != null) {
                            archer.equippedBow.isInUse = true;
                        }
                    } else {
                        gearUses[archer.equippedBow.uid] = 1;
                        archer.equippedBow.isInUse = true;
                    }
                }
                if (archer.equippedQuiver != null) {
                    if (gearUses.ContainsKey(archer.equippedQuiver.uid)) {
                        archer.equippedQuiver = availableGear.getRandomUnusedGearByCategory(Gear.GearCategory.Quiver);
                        if (archer.equippedQuiver != null) {
                            archer.equippedQuiver.isInUse = true;
                        }
                    } else {
                        gearUses[archer.equippedQuiver.uid] = 1;
                        archer.equippedQuiver.isInUse = true;
                    }
                }
                if (archer.equippedBowAwakening1 != null) {
                    if (gearUses.ContainsKey(archer.equippedBowAwakening1.uid)) {
                        archer.equippedBowAwakening1 = availableGear.getRandomUnusedGearByCategory(Gear.GearCategory.BowAwakening);
                        if (archer.equippedBowAwakening1 != null) {
                            archer.equippedBowAwakening1.isInUse = true;
                        }
                    } else {
                        gearUses[archer.equippedBowAwakening1.uid] = 1;
                        archer.equippedBowAwakening1.isInUse = true;
                    }
                }
                if (archer.equippedBowAwakening2 != null) {
                    if (gearUses.ContainsKey(archer.equippedBowAwakening2.uid)) {
                        archer.equippedBowAwakening2 = availableGear.getRandomUnusedGearByCategory(Gear.GearCategory.BowAwakening);
                        if (archer.equippedBowAwakening2 != null) {
                            archer.equippedBowAwakening2.isInUse = true;
                        }
                    } else {
                        gearUses[archer.equippedBowAwakening2.uid] = 1;
                        archer.equippedBowAwakening2.isInUse = true;
                    }
                }
                if (archer.equippedQuiverAwakening1 != null) {
                    if (gearUses.ContainsKey(archer.equippedQuiverAwakening1.uid)) {
                        archer.equippedQuiverAwakening1 = availableGear.getRandomUnusedGearByCategory(Gear.GearCategory.QuiverAwakening);
                        if (archer.equippedQuiverAwakening1 != null) {
                            archer.equippedQuiverAwakening1.isInUse = true;
                        }
                    } else {
                        gearUses[archer.equippedQuiverAwakening1.uid] = 1;
                        archer.equippedQuiverAwakening1.isInUse = true;
                    }
                }
                if (archer.equippedQuiverAwakening2 != null) {
                    if (gearUses.ContainsKey(archer.equippedQuiverAwakening2.uid)) {
                        archer.equippedQuiverAwakening2 = availableGear.getRandomUnusedGearByCategory(Gear.GearCategory.QuiverAwakening);
                        if (archer.equippedQuiverAwakening2 != null) {
                            archer.equippedQuiverAwakening2.isInUse = true;
                        }
                    } else {
                        gearUses[archer.equippedQuiverAwakening2.uid] = 1;
                        archer.equippedQuiverAwakening2.isInUse = true;
                    }
                }
            }
        }

        public void updateAvailableGear() {
            // Reset all gear to not in use before updating based on current team equipment
            foreach (var gear in availableGear.bows) {
                gear.isInUse = false;
            }
            foreach (var gear in availableGear.quivers) {
                gear.isInUse = false;
            }
            foreach (var gear in availableGear.bowAwakens) {
                gear.isInUse = false;
            }
            foreach (var gear in availableGear.quiverAwakens) {
                gear.isInUse = false;
            }

            // Now, mark the gear that is currently equipped by the archers as in use
            foreach (Archer archer in archers) {
                if (archer.equippedBow != null) {
                    archer.equippedBow = availableGear.bows.Find(g => g.uid == archer.equippedBow.uid);
                    archer.equippedBow.isInUse = true;
                }
                if (archer.equippedQuiver != null) {
                    archer.equippedQuiver = availableGear.quivers.Find(g => g.uid == archer.equippedQuiver.uid);
                    archer.equippedQuiver.isInUse = true;
                }
                if (archer.equippedBowAwakening1 != null) {
                    archer.equippedBowAwakening1 = availableGear.bowAwakens.Find(g => g.uid == archer.equippedBowAwakening1.uid);
                    archer.equippedBowAwakening1.isInUse = true;
                }
                if (archer.equippedBowAwakening2 != null) {
                    archer.equippedBowAwakening2 = availableGear.bowAwakens.Find(g => g.uid == archer.equippedBowAwakening2.uid);
                    archer.equippedBowAwakening2.isInUse = true;
                }
                if (archer.equippedQuiverAwakening1 != null) {
                    archer.equippedQuiverAwakening1 = availableGear.quiverAwakens.Find(g => g.uid == archer.equippedQuiverAwakening1.uid);
                    archer.equippedQuiverAwakening1.isInUse = true;
                }
                if (archer.equippedQuiverAwakening2 != null) {
                    archer.equippedQuiverAwakening2 = availableGear.quiverAwakens.Find(g => g.uid == archer.equippedQuiverAwakening2.uid);
                    archer.equippedQuiverAwakening2.isInUse = true;
                }
            }
        }
        public void generateRandomTeam() {
            List<Archer> team = new List<Archer>();
            var allArcherNames = Enum.GetValues(typeof(Archer.ArcherName)).Cast<Archer.ArcherName>().ToList();
            shuffleList(allArcherNames); // Randomly shuffle the list of archer names

            for (int i = 0; i < teamSize && allArcherNames.Count > 0; i++) {
                ArcherName archerName = allArcherNames[0];
                allArcherNames.RemoveAt(0); // Remove the selected name to avoid duplicates

                Archer archer = new Archer(archerName);
                archer.equipArcherWithRandomGear(availableGear);
                team.Add(archer);
            }
            archers = team;
        }
        public void mutateArcherGearAtIndex(int index) {
            if (index < 0 || index >= teamSize) return;
            Archer archer = archers[index];
            archer.mutateGear(availableGear);
        }
        public void mutateArcherNameAtIndex(int index) {
            if (index < 0 || index >= archers.Count) return; // Check for valid index

            // Get all possible archer names
            var allArcherNames = Enum.GetValues(typeof(Archer.ArcherName)).Cast<Archer.ArcherName>().ToList();

            // Remove names of archers already in the team
            var existingNames = archers.Select(a => a.name).ToList();
            var availableNames = allArcherNames.Except(existingNames).ToList();

            if (availableNames.Count == 0) return; // No available names to mutate to

            // Randomly select a new name from the available names
            Archer.ArcherName newName = availableNames[random.Next(availableNames.Count)];

            // Assign the new name to the archer at the specified index
            archers[index].name = newName;
        }

        public double calculateTeamArrowLevel() {
            return ArrowLevelCalculator.calculateTotalArrowLevelForTeam(this);
        }
        private void shuffleList<T>(IList<T> list) {
            int n = list.Count;
            while (n > 1) {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

    }
}
