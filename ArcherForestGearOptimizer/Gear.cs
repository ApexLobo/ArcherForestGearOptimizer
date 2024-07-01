using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcherForestGearOptimizer {
    public class Gear {
        public Guid uid { get; set; }
        public GearCategory category { get; set; }
        public GearType type { get; set; }
        public GearQuality quality { get; set; }
        public Archer.ArcherName archerType { get; set; }
        public int mainStat { get; set; }
        public int compatibleArcherStat { get; set; }
        public int bonusStat { get; set; }
        public bool isInUse { get; set; } = false;
        public Gear() {
        }
        public Gear(GearCategory category, GearType type, GearQuality quality, Archer.ArcherName archerType, int mainStat, int compatibleArcherStat, int bonusStat) {
            this.uid = Guid.NewGuid();
            this.category = category;
            this.type = type;
            this.quality = quality;
            this.archerType = archerType;
            this.mainStat = mainStat;
            this.compatibleArcherStat = compatibleArcherStat;
            this.bonusStat = bonusStat;
        }
        public Gear(Guid uid, GearCategory category, GearType type, GearQuality quality, Archer.ArcherName archerType, int mainStat, int compatibleArcherStat, int bonusStat) {
            this.uid = uid;
            this.category = category;
            this.type = type;
            this.quality = quality;
            this.archerType = archerType;
            this.mainStat = mainStat;
            this.compatibleArcherStat = compatibleArcherStat;
            this.bonusStat = bonusStat;
        }


        public enum GearCategory {
            Bow,
            Quiver,
            BowAwakening,
            QuiverAwakening
        }
        public enum GearType {
            Wood,
            Stone,
            Steel
        }
        public enum GearQuality {
            OneStar,
            TwoStar,
            ThreeStar,
            FourStar,
            FiveStar
        }

        public Gear clone() {
            return new Gear(uid, category, type, quality, archerType, mainStat, compatibleArcherStat, bonusStat);
        }

        public override string ToString() {
            return $"{category}/{ToShorterString()}";
        }
        public string ToShorterString() {
            return $"{type}/{quality}/{archerType}/{mainStat}/{compatibleArcherStat}/{bonusStat}/{isInUse}";
        }
    }
}
