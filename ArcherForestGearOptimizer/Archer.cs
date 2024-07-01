using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcherForestGearOptimizer {
    public class Archer {
        public Random random { get; set; } = new Random();
        public ArcherName name { get; set; }

        public Gear equippedBow { get; set; }
        public Gear equippedQuiver { get; set; }
        public Gear equippedBowAwakening1 { get; set; }
        public Gear equippedBowAwakening2 { get; set; }
        public Gear equippedQuiverAwakening1 { get; set; }
        public Gear equippedQuiverAwakening2 { get; set; }
        public Archer() {

        }
        public Archer(ArcherName name) {
            this.name = name;
        }
        public Archer clone() {
            Archer cloned = new Archer(name);
            Gear cloneEquippedBow = this.equippedBow?.clone();
            Gear cloneEquippedQuiver = this.equippedQuiver?.clone();
            Gear cloneEquippedBowAwakening1 = this.equippedBowAwakening1?.clone();
            Gear cloneEquippedBowAwakening2 = this.equippedBowAwakening2?.clone();
            Gear cloneEquippedQuiverAwakening1 = this.equippedQuiverAwakening1?.clone();
            Gear cloneEquippedQuiverAwakening2 = this.equippedQuiverAwakening2?.clone();

            cloned.equipGearInGearSlot(cloneEquippedBow, 0);
            cloned.equipGearInGearSlot(cloneEquippedQuiver, 1);
            cloned.equipGearInGearSlot(cloneEquippedBowAwakening1, 2);
            cloned.equipGearInGearSlot(cloneEquippedBowAwakening2, 3);
            cloned.equipGearInGearSlot(cloneEquippedQuiverAwakening1, 4);
            cloned.equipGearInGearSlot(cloneEquippedQuiverAwakening2, 5);


            return cloned;
        }
        public void mutateGear(GearList availableGear) {
            // Randomly select a gear slot to mutate
            Random random = new Random();
            int gearSlot = random.Next(6); // There are 6 gear slots

            // Determine the gear category based on the selected gear slot
            Gear.GearCategory categoryToMutate = availableGear.getCategoryByGearSlot(gearSlot);

            Gear newGear = availableGear.getRandomUnusedGearByCategory(categoryToMutate);

            if (newGear != null) {
                // Equip the new gear, replacing the old one
                equipGearInGearSlot(newGear, gearSlot);
            }
        }

        public void equipGearInGearSlot(Gear gear, int gearSlot) {
            if (gear == null) {
                return;
            }

            unequipGearInGearSlot(gearSlot);

            switch (gearSlot) {
                case 0:
                    equippedBow = gear;
                    break;
                case 1:
                    equippedQuiver = gear;
                    break;
                case 2:
                    equippedBowAwakening1 = gear;
                    break;
                case 3:
                    equippedBowAwakening2 = gear;
                    break;
                case 4:
                    equippedQuiverAwakening1 = gear;
                    break;
                case 5:
                    equippedQuiverAwakening2 = gear;
                    break;
            }
            gear.isInUse = true;
        }
        private void unequipGearInGearSlot(int gearSlot) {
            switch (gearSlot) {
                case 0:
                    if (equippedBow == null) return;
                    equippedBow.isInUse = false;
                    equippedBow = null;
                    break;
                case 1:
                    if (equippedQuiver == null) return;
                    equippedQuiver.isInUse = false;
                    equippedQuiver = null;
                    break;
                case 2:
                    if (equippedBowAwakening1 == null) return;
                    equippedBowAwakening1.isInUse = false;
                    equippedBowAwakening1 = null;
                    break;
                case 3:
                    if (equippedBowAwakening2 == null) return;
                    equippedBowAwakening2.isInUse = false;
                    equippedBowAwakening2 = null;
                    break;
                case 4:
                    if (equippedQuiverAwakening1 == null) return;
                    equippedQuiverAwakening1.isInUse = false;
                    equippedQuiverAwakening1 = null;
                    break;
                case 5:
                    if (equippedQuiverAwakening2 == null) return;
                    equippedQuiverAwakening2.isInUse = false;
                    equippedQuiverAwakening2 = null;
                    break;
            }
        }


        public void equipArcherWithRandomGear(GearList availableGear) {
            equipGearInGearSlot(availableGear.getRandomUnusedGearByCategory(Gear.GearCategory.Bow), 0);
            equipGearInGearSlot(availableGear.getRandomUnusedGearByCategory(Gear.GearCategory.Quiver), 1);
            equipGearInGearSlot(availableGear.getRandomUnusedGearByCategory(Gear.GearCategory.BowAwakening), 2);
            equipGearInGearSlot(availableGear.getRandomUnusedGearByCategory(Gear.GearCategory.BowAwakening), 3);
            equipGearInGearSlot(availableGear.getRandomUnusedGearByCategory(Gear.GearCategory.QuiverAwakening), 4);
            equipGearInGearSlot(availableGear.getRandomUnusedGearByCategory(Gear.GearCategory.QuiverAwakening), 5);
        }

        public enum ArcherName {
            Lily,
            Wong,
            Murphy,
            Carp,
            Genta,
            Patty,
            Brady,
            Hog,
            Spiegel,
            Rex,
            Gazelle,
            Tony,
            Raccoo,
            Chuchu,
            Kelpie,
            Dexter,
            Todd,
            Zorro,
            Hippo,
            Simon,
            Panther,
            Drake,
            Hound,
            Koruuno,
            Tuntun,
            Nelson,
            Nancy,
            Dino,
            Pandori,
            Pappitson,
            Momo,
            Kero,
            Marty,
            Zelda,
            Julian,
            Bunny,
            Beef,
            LilKong,
            Nereus,
            Tyger,
            Rhino,
            Taurus,
            Shaq,
            Raffe,
            Brownie,
            Scar,
            Olorun,
            Chronos,
            Kungbao,
            Hedwig,
            Kawiil,
            Sylphy,
            Isaac
        }
    }
}
