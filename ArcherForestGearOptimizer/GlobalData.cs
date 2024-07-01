using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ArcherForestGearOptimizer.Gear;

namespace ArcherForestGearOptimizer {
    public static class GlobalData {
        public static Player player { get; set; }
        public static GearList gearList { get; set; }
        public static GearList availableGearList {get; set; }
        public static StoneTeam currentStoneTeam { get; set; }


        // Method to mark a gear item as unavailable
        public static void removeGearFromAvailableList(Gear gearItem) {

            if (gearItem == null) { return; }

            if (gearItem.category == GearCategory.Bow) {
                Gear gearToRemove = availableGearList.bows.FirstOrDefault(g => g.uid == gearItem.uid);
                availableGearList.bows.Remove(gearToRemove);
            }
            if (gearItem.category == GearCategory.Quiver) {
                Gear gearToRemove = availableGearList.quivers.FirstOrDefault(g => g.uid == gearItem.uid);
                availableGearList.quivers.Remove(gearToRemove);
            }
            if (gearItem.category == GearCategory.BowAwakening) {
                Gear gearToRemove = availableGearList.bowAwakens.FirstOrDefault(g => g.uid == gearItem.uid);
                availableGearList.bowAwakens.Remove(gearToRemove);
            }
            if (gearItem.category == GearCategory.QuiverAwakening) {
                Gear gearToRemove = availableGearList.quiverAwakens.FirstOrDefault(g => g.uid == gearItem.uid);
                availableGearList.quiverAwakens.Remove(gearToRemove);
            }
        }

        // Method to mark a gear item as available
        public static void addGearToAvailableList(Gear gearItem) {
            if (gearItem.category == GearCategory.Bow && !availableGearList.bows.Contains(gearItem)) {
                availableGearList.bows.Add(gearItem);
            }
            if (gearItem.category == GearCategory.Quiver && !availableGearList.quivers.Contains(gearItem)) {
                availableGearList.quivers.Add(gearItem);
            }
            if (gearItem.category == GearCategory.BowAwakening && !availableGearList.bowAwakens.Contains(gearItem)) {
                availableGearList.bowAwakens.Add(gearItem);
            }
            if (gearItem.category == GearCategory.QuiverAwakening && !availableGearList.quiverAwakens.Contains(gearItem)) {
                availableGearList.quiverAwakens.Add(gearItem);
            }
        }

        // Method to reset availableGearList
        public static void resetAvailableGearList() {
            availableGearList = gearList.clone();
        }

    }
}
