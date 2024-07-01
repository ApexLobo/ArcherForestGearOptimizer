using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcherForestGearOptimizer {
    public class Player {
        public int diamondUpgrade1 { get; set; }
        public int diamondUpgrade2 { get; set; }
        public int rebirthUpgrade { get; set; }
        public int exquisiteUpgrade { get; set; }
        public int pvpUpgrade { get; set; }
        public int villageUpgrade { get; set; }
        public int memoryOfBowUpgrade { get; set; }
        public int guildTraitUpgrade { get; set; }
        public int ownedArchersAndPetsUpgrade { get; set; }
        public int anvilUpgrade { get; set; }
        public int latentUpgrade { get; set; }


        public int rmLevel { get; set; }
        public int howlerLevel { get; set; }
        public int cocoLevel { get; set; }
        public int latentPercent { get; set; }

        public int masterRune1 { get; set; }
        public int masterRune2 { get; set; }
        public int masterRune3 { get; set; }

        public double runeArrowLevel { get; set; }
        public int bowArrowLevel { get; set; }
        public double percentIncreaseArrowLevel { get; set; }
        public double totalArrowLevel { get; set; }
    }
}
