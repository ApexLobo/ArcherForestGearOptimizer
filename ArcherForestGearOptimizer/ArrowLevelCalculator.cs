using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcherForestGearOptimizer {
    public static class ArrowLevelCalculator {


        public static double calculateRuneArrowLevel() {
            double result = 0;

            double masterRune1Multiplier = 0.05;
            double masterRune2Multiplier = 0.5;
            double masterRune3Multiplier = 1;

            double baseMasterRune1 = GlobalData.player.masterRune1 * masterRune1Multiplier;
            double baseMasterRune2 = GlobalData.player.masterRune2 * masterRune2Multiplier;
            double baseMasterRune3 = GlobalData.player.masterRune3 * masterRune3Multiplier;

            double baseMasterRunes = baseMasterRune1 + baseMasterRune2 + baseMasterRune3;

            double rmPercent = GlobalData.player.rmLevel * 0.2;

            double howlerPercent = GlobalData.player.howlerLevel * 0.2;

            result = baseMasterRunes * (1 + rmPercent + howlerPercent);

            return result;
        }
        public static int calculateBowArrowLevelForTeam(StoneTeam team) {
            int result = 0;

            if (team != null) {
                foreach (Archer archer in team.archers) {
                    if (archer.equippedBow != null) {
                        result += archer.equippedBow.mainStat;

                        if (archer.equippedBow.archerType == archer.name) {
                            result += archer.equippedBow.compatibleArcherStat;
                        }
                    }

                    if (archer.equippedBowAwakening1 != null) {
                        result += archer.equippedBowAwakening1.mainStat;

                        if (archer.equippedBowAwakening1.archerType == archer.name) {
                            result += archer.equippedBowAwakening1.compatibleArcherStat;
                        }
                    }

                    if (archer.equippedBowAwakening2 != null) {
                        result += archer.equippedBowAwakening2.mainStat;

                        if (archer.equippedBowAwakening2.archerType == archer.name) {
                            result += archer.equippedBowAwakening2.compatibleArcherStat;
                        }
                    }
                }
            } else {
                result = 0;
            }

            return result;
        }
        public static int calculateBowArrowLevel() {
            int result = 0;

            if (GlobalData.currentStoneTeam != null) {
                return calculateBowArrowLevelForTeam(GlobalData.currentStoneTeam);
            } else {
                result = 0;
            }

            return result;
        }
        public static double calculatePercentIncreaseArrowLevelForTeam(StoneTeam team, int playerUpgradeArrowLevel, int bowArrowLevel, double runeArrowLevel) {
            double result = 0;

            double quiverPercent = 0;
            double quiverAwakenPercent = 0;


            if (team != null) {
                foreach (Archer archer in team.archers) {
                    if (archer.equippedQuiver != null) {
                        quiverPercent += archer.equippedQuiver.mainStat * .01;

                        if (archer.equippedQuiver.archerType == archer.name) {
                            quiverPercent += archer.equippedQuiver.compatibleArcherStat * .01;
                        }
                    }

                    if (archer.equippedQuiverAwakening1 != null) {
                        quiverAwakenPercent += archer.equippedQuiverAwakening1.mainStat * .01;

                        if (archer.equippedQuiverAwakening1.archerType == archer.name) {
                            quiverAwakenPercent += archer.equippedQuiverAwakening1.compatibleArcherStat * .01;
                        }
                    }

                    if (archer.equippedQuiverAwakening2 != null) {
                        quiverAwakenPercent += archer.equippedQuiverAwakening2.mainStat * .01;

                        if (archer.equippedQuiverAwakening2.archerType == archer.name) {
                            quiverAwakenPercent += archer.equippedQuiverAwakening2.compatibleArcherStat * .01;
                        }
                    }
                }
            }

            double cocoPercent = GlobalData.player.cocoLevel * 0.01;

            double latentPercent = GlobalData.player.latentPercent * 0.01;


            double percentIncrease = quiverPercent + quiverAwakenPercent + cocoPercent + latentPercent;

            double baseArrowLevelIncrease = playerUpgradeArrowLevel + runeArrowLevel;

            double gearALBase = (baseArrowLevelIncrease + bowArrowLevel) * percentIncrease;

            result = gearALBase + bowArrowLevel;

            return result;
        }

        public static double calculatePercentIncreaseArrowLevel(int playerUpgradeArrowLevel, int bowArrowLevel, double runeArrowLevel) {
            return calculatePercentIncreaseArrowLevelForTeam(GlobalData.currentStoneTeam, playerUpgradeArrowLevel, bowArrowLevel, runeArrowLevel);
        }
        public static double calculateTotalArrowLevelForTeam(StoneTeam team) {
            double result = 0;

            int playerUpgradeArrowLevel = GlobalData.player.diamondUpgrade1
                + GlobalData.player.diamondUpgrade2
                + GlobalData.player.rebirthUpgrade
                + GlobalData.player.exquisiteUpgrade
                + GlobalData.player.pvpUpgrade
                + GlobalData.player.villageUpgrade
                + GlobalData.player.memoryOfBowUpgrade
                + GlobalData.player.guildTraitUpgrade
                + GlobalData.player.ownedArchersAndPetsUpgrade
                + GlobalData.player.anvilUpgrade
                + GlobalData.player.latentUpgrade;

            double runeArrowLevel = calculateRuneArrowLevel();

            int bowArrowLevel = calculateBowArrowLevelForTeam(team);

            double percentIncreaseArrowLevel = calculatePercentIncreaseArrowLevelForTeam(team,playerUpgradeArrowLevel, bowArrowLevel, runeArrowLevel);


            result = calculateTotalArrowLevel(playerUpgradeArrowLevel, runeArrowLevel, percentIncreaseArrowLevel);

            return result;
        }
        public static double calculateTotalArrowLevel(int playerUpgradeArrowLevel, double runeArrowLevel, double percentIncreaseArrowLevel) {
            double result = 0;

            result = 1 + playerUpgradeArrowLevel + runeArrowLevel + percentIncreaseArrowLevel;

            return result;
        }
    }
}
