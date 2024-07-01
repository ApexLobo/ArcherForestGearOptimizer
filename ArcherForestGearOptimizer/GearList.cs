using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcherForestGearOptimizer {
    public class GearList {
        public List<Gear> bows { get; set; }
        public List<Gear> quivers { get; set; }
        public List<Gear> bowAwakens { get; set; }
        public List<Gear> quiverAwakens { get; set; }

        public GearList() {
            bows = new List<Gear>();
            quivers = new List<Gear>();
            bowAwakens = new List<Gear>();
            quiverAwakens = new List<Gear>();
        }
        public GearList clone() {
            return new GearList {
                bows = new List<Gear>(this.bows.Select(item => item.clone())),
                quivers = new List<Gear>(this.quivers.Select(item => item.clone())),
                bowAwakens = new List<Gear>(this.bowAwakens.Select(item => item.clone())),
                quiverAwakens = new List<Gear>(this.quiverAwakens.Select(item => item.clone()))
            };
        }
        public Gear.GearCategory getCategoryByGearSlot(int gearSlot) {
            switch (gearSlot) {
                case 0: return Gear.GearCategory.Bow;
                case 1: return Gear.GearCategory.Quiver;
                case 2:
                case 3: return Gear.GearCategory.BowAwakening;
                case 4:
                case 5: return Gear.GearCategory.QuiverAwakening;
                default: throw new ArgumentOutOfRangeException(nameof(gearSlot), "Invalid gear slot");
            }
        }
        public Gear getRandomUnusedGearByCategory(Gear.GearCategory category) {
            Random random = new Random();
            List<Gear> listOfGear = null;

            switch (category) {
                case Gear.GearCategory.Bow:
                    listOfGear = bows;
                    break;
                case Gear.GearCategory.Quiver:
                    listOfGear = quivers;
                    break;
                case Gear.GearCategory.BowAwakening:
                    listOfGear = bowAwakens;
                    break;
                case Gear.GearCategory.QuiverAwakening:
                    listOfGear = quiverAwakens;
                    break;
            }

            if (listOfGear == null || !listOfGear.Any(g => !g.isInUse)) {
                return null; // No available gear in the specified category
            }

            // Filter the list to only include gear that's not in use
            var availableGear = listOfGear.Where(g => !g.isInUse).ToList();
            // Select a random gear item from the available gear
            return availableGear[random.Next(availableGear.Count)];
        }
    }
}
