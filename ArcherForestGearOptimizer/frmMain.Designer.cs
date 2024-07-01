namespace ArcherForestGearOptimizer {
    partial class frmMain {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btnViewGearList = new Button();
            lblDiamondUpgrade1 = new Label();
            groupPlayerStats = new GroupBox();
            groupMasterRunes = new GroupBox();
            numericMasterRunes3 = new NumericUpDown();
            numericMasterRunes2 = new NumericUpDown();
            numericMasterRunes1 = new NumericUpDown();
            lblMasterRunes3 = new Label();
            lblMasterRunes2 = new Label();
            lblMasterRunes1 = new Label();
            groupPetProtectorLatent = new GroupBox();
            numericLatentPercent = new NumericUpDown();
            numericCocoLevel = new NumericUpDown();
            numericHowlerLevel = new NumericUpDown();
            numericRMLevel = new NumericUpDown();
            lblLatentPercent = new Label();
            lblCocoLevel = new Label();
            lblHowlerLevel = new Label();
            lblRMLevel = new Label();
            groupPlayerUpgrades = new GroupBox();
            numericLatentUpgrade = new NumericUpDown();
            numericAnvilUpgrade = new NumericUpDown();
            numericOwnedArchersAndPetsUpgrade = new NumericUpDown();
            numericGuildTraitUpgrade = new NumericUpDown();
            numericMemoryUpgrade = new NumericUpDown();
            numericVillageUpgrade = new NumericUpDown();
            numericPVPUpgrade = new NumericUpDown();
            numericExquisiteUpgrade = new NumericUpDown();
            numericRebirthUpgrade = new NumericUpDown();
            numericDiamondUpgrade2 = new NumericUpDown();
            numericDiamondUpgrade1 = new NumericUpDown();
            lblLatentUpgrade = new Label();
            lblAnvilUpgrade = new Label();
            lblOwnedArchersAndPetsUpgrade = new Label();
            lblGuildTraitUpgrade = new Label();
            lblMemoryUpgrade = new Label();
            lblVillageUpgrade = new Label();
            lblPVPUpgrade = new Label();
            lblExquisiteUpgrade = new Label();
            lblRebirthUpgrade = new Label();
            lblDiamondUpgrade2 = new Label();
            groupSimulation = new GroupBox();
            progressSimulation = new ProgressBar();
            lblSimulationProgress = new Label();
            txtSimulationArrowLevel = new TextBox();
            lblSimulationArrowLevel = new Label();
            numericSimulationGenerations = new NumericUpDown();
            lblSimulationGenerations = new Label();
            btnSimulateOptimalTeam = new Button();
            groupOptions = new GroupBox();
            btnViewStoneTeamAndEquip = new Button();
            btnLoadPlayerStats = new Button();
            btnSavePlayerStats = new Button();
            groupCalculations = new GroupBox();
            lblBowAndBowAwakenCalcTotal = new Label();
            txtBowAndBowAwakenCalcTotal = new TextBox();
            lblALCalcTotal = new Label();
            txtALCalcTotal = new TextBox();
            btnCalculateAL = new Button();
            lblPercentIncreaseCalcTotal = new Label();
            txtPercentIncreaseCalcTotal = new TextBox();
            lblRuneCalcTotal = new Label();
            txtRuneCalcTotal = new TextBox();
            backgroundWorkerMachineLearning = new System.ComponentModel.BackgroundWorker();
            groupPlayerStats.SuspendLayout();
            groupMasterRunes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericMasterRunes3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericMasterRunes2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericMasterRunes1).BeginInit();
            groupPetProtectorLatent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericLatentPercent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCocoLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericHowlerLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericRMLevel).BeginInit();
            groupPlayerUpgrades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericLatentUpgrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericAnvilUpgrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericOwnedArchersAndPetsUpgrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericGuildTraitUpgrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericMemoryUpgrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericVillageUpgrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPVPUpgrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericExquisiteUpgrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericRebirthUpgrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDiamondUpgrade2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDiamondUpgrade1).BeginInit();
            groupSimulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericSimulationGenerations).BeginInit();
            groupOptions.SuspendLayout();
            groupCalculations.SuspendLayout();
            SuspendLayout();
            // 
            // btnViewGearList
            // 
            btnViewGearList.Location = new Point(6, 156);
            btnViewGearList.Name = "btnViewGearList";
            btnViewGearList.Size = new Size(187, 23);
            btnViewGearList.TabIndex = 0;
            btnViewGearList.Text = "View gear inventory";
            btnViewGearList.UseVisualStyleBackColor = true;
            btnViewGearList.Click += btnViewGearList_Click;
            // 
            // lblDiamondUpgrade1
            // 
            lblDiamondUpgrade1.AutoSize = true;
            lblDiamondUpgrade1.Location = new Point(6, 19);
            lblDiamondUpgrade1.Name = "lblDiamondUpgrade1";
            lblDiamondUpgrade1.Size = new Size(112, 15);
            lblDiamondUpgrade1.TabIndex = 1;
            lblDiamondUpgrade1.Text = "Diamond upgrade 1";
            // 
            // groupPlayerStats
            // 
            groupPlayerStats.Controls.Add(groupMasterRunes);
            groupPlayerStats.Controls.Add(groupPetProtectorLatent);
            groupPlayerStats.Controls.Add(groupPlayerUpgrades);
            groupPlayerStats.Location = new Point(12, 12);
            groupPlayerStats.Name = "groupPlayerStats";
            groupPlayerStats.Size = new Size(739, 224);
            groupPlayerStats.TabIndex = 2;
            groupPlayerStats.TabStop = false;
            groupPlayerStats.Text = "Player stats";
            // 
            // groupMasterRunes
            // 
            groupMasterRunes.Controls.Add(numericMasterRunes3);
            groupMasterRunes.Controls.Add(numericMasterRunes2);
            groupMasterRunes.Controls.Add(numericMasterRunes1);
            groupMasterRunes.Controls.Add(lblMasterRunes3);
            groupMasterRunes.Controls.Add(lblMasterRunes2);
            groupMasterRunes.Controls.Add(lblMasterRunes1);
            groupMasterRunes.Location = new Point(551, 22);
            groupMasterRunes.Name = "groupMasterRunes";
            groupMasterRunes.Size = new Size(179, 191);
            groupMasterRunes.TabIndex = 4;
            groupMasterRunes.TabStop = false;
            groupMasterRunes.Text = "Master runes";
            // 
            // numericMasterRunes3
            // 
            numericMasterRunes3.Location = new Point(124, 74);
            numericMasterRunes3.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericMasterRunes3.Name = "numericMasterRunes3";
            numericMasterRunes3.Size = new Size(46, 23);
            numericMasterRunes3.TabIndex = 32;
            // 
            // numericMasterRunes2
            // 
            numericMasterRunes2.Location = new Point(124, 45);
            numericMasterRunes2.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericMasterRunes2.Name = "numericMasterRunes2";
            numericMasterRunes2.Size = new Size(46, 23);
            numericMasterRunes2.TabIndex = 31;
            // 
            // numericMasterRunes1
            // 
            numericMasterRunes1.Location = new Point(124, 17);
            numericMasterRunes1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericMasterRunes1.Name = "numericMasterRunes1";
            numericMasterRunes1.Size = new Size(46, 23);
            numericMasterRunes1.TabIndex = 30;
            // 
            // lblMasterRunes3
            // 
            lblMasterRunes3.AutoSize = true;
            lblMasterRunes3.Location = new Point(6, 79);
            lblMasterRunes3.Name = "lblMasterRunes3";
            lblMasterRunes3.Size = new Size(43, 15);
            lblMasterRunes3.TabIndex = 13;
            lblMasterRunes3.Text = "Level 3";
            // 
            // lblMasterRunes2
            // 
            lblMasterRunes2.AutoSize = true;
            lblMasterRunes2.Location = new Point(6, 50);
            lblMasterRunes2.Name = "lblMasterRunes2";
            lblMasterRunes2.Size = new Size(43, 15);
            lblMasterRunes2.TabIndex = 11;
            lblMasterRunes2.Text = "Level 2";
            // 
            // lblMasterRunes1
            // 
            lblMasterRunes1.AutoSize = true;
            lblMasterRunes1.Location = new Point(6, 21);
            lblMasterRunes1.Name = "lblMasterRunes1";
            lblMasterRunes1.Size = new Size(43, 15);
            lblMasterRunes1.TabIndex = 9;
            lblMasterRunes1.Text = "Level 1";
            // 
            // groupPetProtectorLatent
            // 
            groupPetProtectorLatent.Controls.Add(numericLatentPercent);
            groupPetProtectorLatent.Controls.Add(numericCocoLevel);
            groupPetProtectorLatent.Controls.Add(numericHowlerLevel);
            groupPetProtectorLatent.Controls.Add(numericRMLevel);
            groupPetProtectorLatent.Controls.Add(lblLatentPercent);
            groupPetProtectorLatent.Controls.Add(lblCocoLevel);
            groupPetProtectorLatent.Controls.Add(lblHowlerLevel);
            groupPetProtectorLatent.Controls.Add(lblRMLevel);
            groupPetProtectorLatent.Location = new Point(366, 22);
            groupPetProtectorLatent.Name = "groupPetProtectorLatent";
            groupPetProtectorLatent.Size = new Size(179, 191);
            groupPetProtectorLatent.TabIndex = 3;
            groupPetProtectorLatent.TabStop = false;
            groupPetProtectorLatent.Text = "Pet/Protector/Latent";
            // 
            // numericLatentPercent
            // 
            numericLatentPercent.Location = new Point(124, 106);
            numericLatentPercent.Name = "numericLatentPercent";
            numericLatentPercent.Size = new Size(46, 23);
            numericLatentPercent.TabIndex = 33;
            // 
            // numericCocoLevel
            // 
            numericCocoLevel.Location = new Point(124, 77);
            numericCocoLevel.Name = "numericCocoLevel";
            numericCocoLevel.Size = new Size(46, 23);
            numericCocoLevel.TabIndex = 32;
            // 
            // numericHowlerLevel
            // 
            numericHowlerLevel.Location = new Point(124, 48);
            numericHowlerLevel.Name = "numericHowlerLevel";
            numericHowlerLevel.Size = new Size(46, 23);
            numericHowlerLevel.TabIndex = 31;
            // 
            // numericRMLevel
            // 
            numericRMLevel.Location = new Point(124, 19);
            numericRMLevel.Name = "numericRMLevel";
            numericRMLevel.Size = new Size(46, 23);
            numericRMLevel.TabIndex = 30;
            // 
            // lblLatentPercent
            // 
            lblLatentPercent.AutoSize = true;
            lblLatentPercent.Location = new Point(6, 108);
            lblLatentPercent.Name = "lblLatentPercent";
            lblLatentPercent.Size = new Size(53, 15);
            lblLatentPercent.TabIndex = 9;
            lblLatentPercent.Text = "Latent %";
            // 
            // lblCocoLevel
            // 
            lblCocoLevel.AutoSize = true;
            lblCocoLevel.Location = new Point(6, 79);
            lblCocoLevel.Name = "lblCocoLevel";
            lblCocoLevel.Size = new Size(62, 15);
            lblCocoLevel.TabIndex = 7;
            lblCocoLevel.Text = "Coco level";
            // 
            // lblHowlerLevel
            // 
            lblHowlerLevel.AutoSize = true;
            lblHowlerLevel.Location = new Point(6, 50);
            lblHowlerLevel.Name = "lblHowlerLevel";
            lblHowlerLevel.Size = new Size(72, 15);
            lblHowlerLevel.TabIndex = 5;
            lblHowlerLevel.Text = "Howler level";
            // 
            // lblRMLevel
            // 
            lblRMLevel.AutoSize = true;
            lblRMLevel.Location = new Point(6, 21);
            lblRMLevel.Name = "lblRMLevel";
            lblRMLevel.Size = new Size(55, 15);
            lblRMLevel.TabIndex = 3;
            lblRMLevel.Text = "RM Level";
            // 
            // groupPlayerUpgrades
            // 
            groupPlayerUpgrades.Controls.Add(numericLatentUpgrade);
            groupPlayerUpgrades.Controls.Add(numericAnvilUpgrade);
            groupPlayerUpgrades.Controls.Add(numericOwnedArchersAndPetsUpgrade);
            groupPlayerUpgrades.Controls.Add(numericGuildTraitUpgrade);
            groupPlayerUpgrades.Controls.Add(numericMemoryUpgrade);
            groupPlayerUpgrades.Controls.Add(numericVillageUpgrade);
            groupPlayerUpgrades.Controls.Add(numericPVPUpgrade);
            groupPlayerUpgrades.Controls.Add(numericExquisiteUpgrade);
            groupPlayerUpgrades.Controls.Add(numericRebirthUpgrade);
            groupPlayerUpgrades.Controls.Add(numericDiamondUpgrade2);
            groupPlayerUpgrades.Controls.Add(numericDiamondUpgrade1);
            groupPlayerUpgrades.Controls.Add(lblLatentUpgrade);
            groupPlayerUpgrades.Controls.Add(lblAnvilUpgrade);
            groupPlayerUpgrades.Controls.Add(lblOwnedArchersAndPetsUpgrade);
            groupPlayerUpgrades.Controls.Add(lblGuildTraitUpgrade);
            groupPlayerUpgrades.Controls.Add(lblMemoryUpgrade);
            groupPlayerUpgrades.Controls.Add(lblVillageUpgrade);
            groupPlayerUpgrades.Controls.Add(lblPVPUpgrade);
            groupPlayerUpgrades.Controls.Add(lblExquisiteUpgrade);
            groupPlayerUpgrades.Controls.Add(lblRebirthUpgrade);
            groupPlayerUpgrades.Controls.Add(lblDiamondUpgrade2);
            groupPlayerUpgrades.Controls.Add(lblDiamondUpgrade1);
            groupPlayerUpgrades.Location = new Point(9, 22);
            groupPlayerUpgrades.Name = "groupPlayerUpgrades";
            groupPlayerUpgrades.Size = new Size(351, 191);
            groupPlayerUpgrades.TabIndex = 2;
            groupPlayerUpgrades.TabStop = false;
            groupPlayerUpgrades.Text = "Upgrades";
            // 
            // numericLatentUpgrade
            // 
            numericLatentUpgrade.Location = new Point(294, 131);
            numericLatentUpgrade.Name = "numericLatentUpgrade";
            numericLatentUpgrade.Size = new Size(46, 23);
            numericLatentUpgrade.TabIndex = 31;
            // 
            // numericAnvilUpgrade
            // 
            numericAnvilUpgrade.Location = new Point(294, 102);
            numericAnvilUpgrade.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
            numericAnvilUpgrade.Name = "numericAnvilUpgrade";
            numericAnvilUpgrade.Size = new Size(46, 23);
            numericAnvilUpgrade.TabIndex = 30;
            // 
            // numericOwnedArchersAndPetsUpgrade
            // 
            numericOwnedArchersAndPetsUpgrade.Location = new Point(294, 73);
            numericOwnedArchersAndPetsUpgrade.Maximum = new decimal(new int[] { 348, 0, 0, 0 });
            numericOwnedArchersAndPetsUpgrade.Name = "numericOwnedArchersAndPetsUpgrade";
            numericOwnedArchersAndPetsUpgrade.Size = new Size(46, 23);
            numericOwnedArchersAndPetsUpgrade.TabIndex = 29;
            // 
            // numericGuildTraitUpgrade
            // 
            numericGuildTraitUpgrade.Location = new Point(294, 44);
            numericGuildTraitUpgrade.Name = "numericGuildTraitUpgrade";
            numericGuildTraitUpgrade.Size = new Size(46, 23);
            numericGuildTraitUpgrade.TabIndex = 28;
            // 
            // numericMemoryUpgrade
            // 
            numericMemoryUpgrade.Location = new Point(294, 15);
            numericMemoryUpgrade.Name = "numericMemoryUpgrade";
            numericMemoryUpgrade.Size = new Size(46, 23);
            numericMemoryUpgrade.TabIndex = 27;
            // 
            // numericVillageUpgrade
            // 
            numericVillageUpgrade.Location = new Point(124, 161);
            numericVillageUpgrade.Name = "numericVillageUpgrade";
            numericVillageUpgrade.Size = new Size(46, 23);
            numericVillageUpgrade.TabIndex = 26;
            // 
            // numericPVPUpgrade
            // 
            numericPVPUpgrade.Location = new Point(124, 131);
            numericPVPUpgrade.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericPVPUpgrade.Name = "numericPVPUpgrade";
            numericPVPUpgrade.Size = new Size(46, 23);
            numericPVPUpgrade.TabIndex = 25;
            // 
            // numericExquisiteUpgrade
            // 
            numericExquisiteUpgrade.Location = new Point(124, 102);
            numericExquisiteUpgrade.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericExquisiteUpgrade.Name = "numericExquisiteUpgrade";
            numericExquisiteUpgrade.Size = new Size(46, 23);
            numericExquisiteUpgrade.TabIndex = 24;
            // 
            // numericRebirthUpgrade
            // 
            numericRebirthUpgrade.Location = new Point(124, 73);
            numericRebirthUpgrade.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            numericRebirthUpgrade.Name = "numericRebirthUpgrade";
            numericRebirthUpgrade.Size = new Size(46, 23);
            numericRebirthUpgrade.TabIndex = 23;
            // 
            // numericDiamondUpgrade2
            // 
            numericDiamondUpgrade2.Location = new Point(124, 44);
            numericDiamondUpgrade2.Maximum = new decimal(new int[] { 80, 0, 0, 0 });
            numericDiamondUpgrade2.Name = "numericDiamondUpgrade2";
            numericDiamondUpgrade2.Size = new Size(46, 23);
            numericDiamondUpgrade2.TabIndex = 22;
            // 
            // numericDiamondUpgrade1
            // 
            numericDiamondUpgrade1.Location = new Point(124, 15);
            numericDiamondUpgrade1.Maximum = new decimal(new int[] { 80, 0, 0, 0 });
            numericDiamondUpgrade1.Name = "numericDiamondUpgrade1";
            numericDiamondUpgrade1.Size = new Size(46, 23);
            numericDiamondUpgrade1.TabIndex = 8;
            // 
            // lblLatentUpgrade
            // 
            lblLatentUpgrade.AutoSize = true;
            lblLatentUpgrade.Location = new Point(176, 134);
            lblLatentUpgrade.Name = "lblLatentUpgrade";
            lblLatentUpgrade.Size = new Size(87, 15);
            lblLatentUpgrade.TabIndex = 21;
            lblLatentUpgrade.Text = "Latent upgrade";
            // 
            // lblAnvilUpgrade
            // 
            lblAnvilUpgrade.AutoSize = true;
            lblAnvilUpgrade.Location = new Point(176, 105);
            lblAnvilUpgrade.Name = "lblAnvilUpgrade";
            lblAnvilUpgrade.Size = new Size(81, 15);
            lblAnvilUpgrade.TabIndex = 19;
            lblAnvilUpgrade.Text = "Anvil upgrade";
            // 
            // lblOwnedArchersAndPetsUpgrade
            // 
            lblOwnedArchersAndPetsUpgrade.AutoSize = true;
            lblOwnedArchersAndPetsUpgrade.Location = new Point(176, 76);
            lblOwnedArchersAndPetsUpgrade.Name = "lblOwnedArchersAndPetsUpgrade";
            lblOwnedArchersAndPetsUpgrade.Size = new Size(90, 15);
            lblOwnedArchersAndPetsUpgrade.TabIndex = 17;
            lblOwnedArchersAndPetsUpgrade.Text = "A's/P's upgrade";
            // 
            // lblGuildTraitUpgrade
            // 
            lblGuildTraitUpgrade.AutoSize = true;
            lblGuildTraitUpgrade.Location = new Point(176, 47);
            lblGuildTraitUpgrade.Name = "lblGuildTraitUpgrade";
            lblGuildTraitUpgrade.Size = new Size(59, 15);
            lblGuildTraitUpgrade.TabIndex = 15;
            lblGuildTraitUpgrade.Text = "Guild trait";
            // 
            // lblMemoryUpgrade
            // 
            lblMemoryUpgrade.AutoSize = true;
            lblMemoryUpgrade.Location = new Point(176, 19);
            lblMemoryUpgrade.Name = "lblMemoryUpgrade";
            lblMemoryUpgrade.Size = new Size(99, 15);
            lblMemoryUpgrade.TabIndex = 13;
            lblMemoryUpgrade.Text = "Memory upgrade";
            // 
            // lblVillageUpgrade
            // 
            lblVillageUpgrade.AutoSize = true;
            lblVillageUpgrade.Location = new Point(6, 163);
            lblVillageUpgrade.Name = "lblVillageUpgrade";
            lblVillageUpgrade.Size = new Size(89, 15);
            lblVillageUpgrade.TabIndex = 11;
            lblVillageUpgrade.Text = "Village upgrade";
            // 
            // lblPVPUpgrade
            // 
            lblPVPUpgrade.AutoSize = true;
            lblPVPUpgrade.Location = new Point(6, 134);
            lblPVPUpgrade.Name = "lblPVPUpgrade";
            lblPVPUpgrade.Size = new Size(75, 15);
            lblPVPUpgrade.TabIndex = 9;
            lblPVPUpgrade.Text = "PVP upgrade";
            // 
            // lblExquisiteUpgrade
            // 
            lblExquisiteUpgrade.AutoSize = true;
            lblExquisiteUpgrade.Location = new Point(6, 105);
            lblExquisiteUpgrade.Name = "lblExquisiteUpgrade";
            lblExquisiteUpgrade.Size = new Size(101, 15);
            lblExquisiteUpgrade.TabIndex = 7;
            lblExquisiteUpgrade.Text = "Exquisite upgrade";
            // 
            // lblRebirthUpgrade
            // 
            lblRebirthUpgrade.AutoSize = true;
            lblRebirthUpgrade.Location = new Point(6, 76);
            lblRebirthUpgrade.Name = "lblRebirthUpgrade";
            lblRebirthUpgrade.Size = new Size(92, 15);
            lblRebirthUpgrade.TabIndex = 5;
            lblRebirthUpgrade.Text = "Rebirth upgrade";
            // 
            // lblDiamondUpgrade2
            // 
            lblDiamondUpgrade2.AutoSize = true;
            lblDiamondUpgrade2.Location = new Point(6, 47);
            lblDiamondUpgrade2.Name = "lblDiamondUpgrade2";
            lblDiamondUpgrade2.Size = new Size(112, 15);
            lblDiamondUpgrade2.TabIndex = 3;
            lblDiamondUpgrade2.Text = "Diamond upgrade 2";
            // 
            // groupSimulation
            // 
            groupSimulation.Controls.Add(progressSimulation);
            groupSimulation.Controls.Add(lblSimulationProgress);
            groupSimulation.Controls.Add(txtSimulationArrowLevel);
            groupSimulation.Controls.Add(lblSimulationArrowLevel);
            groupSimulation.Controls.Add(numericSimulationGenerations);
            groupSimulation.Controls.Add(lblSimulationGenerations);
            groupSimulation.Controls.Add(btnSimulateOptimalTeam);
            groupSimulation.Location = new Point(488, 242);
            groupSimulation.Name = "groupSimulation";
            groupSimulation.Size = new Size(263, 185);
            groupSimulation.TabIndex = 7;
            groupSimulation.TabStop = false;
            groupSimulation.Text = "Simulation";
            // 
            // progressSimulation
            // 
            progressSimulation.Location = new Point(6, 95);
            progressSimulation.Name = "progressSimulation";
            progressSimulation.Size = new Size(248, 23);
            progressSimulation.TabIndex = 64;
            // 
            // lblSimulationProgress
            // 
            lblSimulationProgress.AutoSize = true;
            lblSimulationProgress.Location = new Point(6, 77);
            lblSimulationProgress.Name = "lblSimulationProgress";
            lblSimulationProgress.Size = new Size(112, 15);
            lblSimulationProgress.TabIndex = 63;
            lblSimulationProgress.Text = "Simulation progress";
            // 
            // txtSimulationArrowLevel
            // 
            txtSimulationArrowLevel.Location = new Point(157, 45);
            txtSimulationArrowLevel.Name = "txtSimulationArrowLevel";
            txtSimulationArrowLevel.ReadOnly = true;
            txtSimulationArrowLevel.Size = new Size(97, 23);
            txtSimulationArrowLevel.TabIndex = 62;
            txtSimulationArrowLevel.Text = "0";
            // 
            // lblSimulationArrowLevel
            // 
            lblSimulationArrowLevel.AutoSize = true;
            lblSimulationArrowLevel.Location = new Point(6, 48);
            lblSimulationArrowLevel.Name = "lblSimulationArrowLevel";
            lblSimulationArrowLevel.Size = new Size(124, 15);
            lblSimulationArrowLevel.TabIndex = 61;
            lblSimulationArrowLevel.Text = "Simulation arrow level";
            // 
            // numericSimulationGenerations
            // 
            numericSimulationGenerations.Location = new Point(156, 17);
            numericSimulationGenerations.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericSimulationGenerations.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericSimulationGenerations.Name = "numericSimulationGenerations";
            numericSimulationGenerations.Size = new Size(98, 23);
            numericSimulationGenerations.TabIndex = 60;
            numericSimulationGenerations.Value = new decimal(new int[] { 200000, 0, 0, 0 });
            // 
            // lblSimulationGenerations
            // 
            lblSimulationGenerations.AutoSize = true;
            lblSimulationGenerations.Location = new Point(6, 19);
            lblSimulationGenerations.Name = "lblSimulationGenerations";
            lblSimulationGenerations.Size = new Size(129, 15);
            lblSimulationGenerations.TabIndex = 59;
            lblSimulationGenerations.Text = "Simulation generations";
            // 
            // btnSimulateOptimalTeam
            // 
            btnSimulateOptimalTeam.Location = new Point(6, 156);
            btnSimulateOptimalTeam.Name = "btnSimulateOptimalTeam";
            btnSimulateOptimalTeam.Size = new Size(248, 23);
            btnSimulateOptimalTeam.TabIndex = 57;
            btnSimulateOptimalTeam.Text = "Start optimal team simulation";
            btnSimulateOptimalTeam.UseVisualStyleBackColor = true;
            btnSimulateOptimalTeam.Click += btnSimulateOptimalTeam_Click;
            // 
            // groupOptions
            // 
            groupOptions.Controls.Add(btnViewStoneTeamAndEquip);
            groupOptions.Controls.Add(btnLoadPlayerStats);
            groupOptions.Controls.Add(btnSavePlayerStats);
            groupOptions.Controls.Add(btnViewGearList);
            groupOptions.Location = new Point(281, 242);
            groupOptions.Name = "groupOptions";
            groupOptions.Size = new Size(201, 185);
            groupOptions.TabIndex = 6;
            groupOptions.TabStop = false;
            groupOptions.Text = "Options";
            // 
            // btnViewStoneTeamAndEquip
            // 
            btnViewStoneTeamAndEquip.Location = new Point(6, 127);
            btnViewStoneTeamAndEquip.Name = "btnViewStoneTeamAndEquip";
            btnViewStoneTeamAndEquip.Size = new Size(187, 23);
            btnViewStoneTeamAndEquip.TabIndex = 7;
            btnViewStoneTeamAndEquip.Text = "View stone team and equip";
            btnViewStoneTeamAndEquip.UseVisualStyleBackColor = true;
            btnViewStoneTeamAndEquip.Click += btnViewStoneTeamAndEquip_Click;
            // 
            // btnLoadPlayerStats
            // 
            btnLoadPlayerStats.Location = new Point(6, 22);
            btnLoadPlayerStats.Name = "btnLoadPlayerStats";
            btnLoadPlayerStats.Size = new Size(187, 23);
            btnLoadPlayerStats.TabIndex = 8;
            btnLoadPlayerStats.Text = "Load player stats to file";
            btnLoadPlayerStats.UseVisualStyleBackColor = true;
            btnLoadPlayerStats.Click += btnLoadPlayerStats_Click;
            // 
            // btnSavePlayerStats
            // 
            btnSavePlayerStats.Location = new Point(6, 51);
            btnSavePlayerStats.Name = "btnSavePlayerStats";
            btnSavePlayerStats.Size = new Size(187, 23);
            btnSavePlayerStats.TabIndex = 7;
            btnSavePlayerStats.Text = "Save player stats to file";
            btnSavePlayerStats.UseVisualStyleBackColor = true;
            btnSavePlayerStats.Click += btnSavePlayerStats_Click;
            // 
            // groupCalculations
            // 
            groupCalculations.Controls.Add(lblBowAndBowAwakenCalcTotal);
            groupCalculations.Controls.Add(txtBowAndBowAwakenCalcTotal);
            groupCalculations.Controls.Add(lblALCalcTotal);
            groupCalculations.Controls.Add(txtALCalcTotal);
            groupCalculations.Controls.Add(btnCalculateAL);
            groupCalculations.Controls.Add(lblPercentIncreaseCalcTotal);
            groupCalculations.Controls.Add(txtPercentIncreaseCalcTotal);
            groupCalculations.Controls.Add(lblRuneCalcTotal);
            groupCalculations.Controls.Add(txtRuneCalcTotal);
            groupCalculations.Location = new Point(12, 242);
            groupCalculations.Name = "groupCalculations";
            groupCalculations.Size = new Size(263, 185);
            groupCalculations.TabIndex = 5;
            groupCalculations.TabStop = false;
            groupCalculations.Text = "Calculations";
            // 
            // lblBowAndBowAwakenCalcTotal
            // 
            lblBowAndBowAwakenCalcTotal.AutoSize = true;
            lblBowAndBowAwakenCalcTotal.Location = new Point(6, 48);
            lblBowAndBowAwakenCalcTotal.Name = "lblBowAndBowAwakenCalcTotal";
            lblBowAndBowAwakenCalcTotal.Size = new Size(139, 15);
            lblBowAndBowAwakenCalcTotal.TabIndex = 10;
            lblBowAndBowAwakenCalcTotal.Text = "Bow && bow awaken total";
            // 
            // txtBowAndBowAwakenCalcTotal
            // 
            txtBowAndBowAwakenCalcTotal.Location = new Point(151, 45);
            txtBowAndBowAwakenCalcTotal.Name = "txtBowAndBowAwakenCalcTotal";
            txtBowAndBowAwakenCalcTotal.ReadOnly = true;
            txtBowAndBowAwakenCalcTotal.Size = new Size(97, 23);
            txtBowAndBowAwakenCalcTotal.TabIndex = 9;
            txtBowAndBowAwakenCalcTotal.Text = "0";
            // 
            // lblALCalcTotal
            // 
            lblALCalcTotal.AutoSize = true;
            lblALCalcTotal.Location = new Point(6, 126);
            lblALCalcTotal.Name = "lblALCalcTotal";
            lblALCalcTotal.Size = new Size(92, 15);
            lblALCalcTotal.TabIndex = 8;
            lblALCalcTotal.Text = "Total arrow level";
            // 
            // txtALCalcTotal
            // 
            txtALCalcTotal.Location = new Point(151, 123);
            txtALCalcTotal.Name = "txtALCalcTotal";
            txtALCalcTotal.ReadOnly = true;
            txtALCalcTotal.Size = new Size(97, 23);
            txtALCalcTotal.TabIndex = 7;
            // 
            // btnCalculateAL
            // 
            btnCalculateAL.Location = new Point(3, 152);
            btnCalculateAL.Name = "btnCalculateAL";
            btnCalculateAL.Size = new Size(245, 23);
            btnCalculateAL.TabIndex = 6;
            btnCalculateAL.Text = "Calculate arrow level";
            btnCalculateAL.UseVisualStyleBackColor = true;
            btnCalculateAL.Click += btnCalculateAL_Click;
            // 
            // lblPercentIncreaseCalcTotal
            // 
            lblPercentIncreaseCalcTotal.AutoSize = true;
            lblPercentIncreaseCalcTotal.Location = new Point(6, 78);
            lblPercentIncreaseCalcTotal.Name = "lblPercentIncreaseCalcTotal";
            lblPercentIncreaseCalcTotal.Size = new Size(120, 15);
            lblPercentIncreaseCalcTotal.TabIndex = 5;
            lblPercentIncreaseCalcTotal.Text = "Percent increase total";
            // 
            // txtPercentIncreaseCalcTotal
            // 
            txtPercentIncreaseCalcTotal.Location = new Point(151, 74);
            txtPercentIncreaseCalcTotal.Name = "txtPercentIncreaseCalcTotal";
            txtPercentIncreaseCalcTotal.ReadOnly = true;
            txtPercentIncreaseCalcTotal.Size = new Size(97, 23);
            txtPercentIncreaseCalcTotal.TabIndex = 4;
            txtPercentIncreaseCalcTotal.Text = "0";
            // 
            // lblRuneCalcTotal
            // 
            lblRuneCalcTotal.AutoSize = true;
            lblRuneCalcTotal.Location = new Point(6, 19);
            lblRuneCalcTotal.Name = "lblRuneCalcTotal";
            lblRuneCalcTotal.Size = new Size(61, 15);
            lblRuneCalcTotal.TabIndex = 3;
            lblRuneCalcTotal.Text = "Rune total";
            // 
            // txtRuneCalcTotal
            // 
            txtRuneCalcTotal.Location = new Point(151, 16);
            txtRuneCalcTotal.Name = "txtRuneCalcTotal";
            txtRuneCalcTotal.ReadOnly = true;
            txtRuneCalcTotal.Size = new Size(97, 23);
            txtRuneCalcTotal.TabIndex = 2;
            txtRuneCalcTotal.Text = "0";
            // 
            // backgroundWorkerMachineLearning
            // 
            backgroundWorkerMachineLearning.WorkerReportsProgress = true;
            backgroundWorkerMachineLearning.WorkerSupportsCancellation = true;
            backgroundWorkerMachineLearning.DoWork += backgroundWorkerMachineLearning_DoWork;
            backgroundWorkerMachineLearning.ProgressChanged += backgroundWorkerMachineLearning_ProgressChanged;
            backgroundWorkerMachineLearning.RunWorkerCompleted += backgroundWorkerMachineLearning_RunWorkerCompleted;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 436);
            Controls.Add(groupSimulation);
            Controls.Add(groupPlayerStats);
            Controls.Add(groupOptions);
            Controls.Add(groupCalculations);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmMain";
            Text = "Archer Forest Stone Team Optimizer";
            Load += frmMain_Load;
            groupPlayerStats.ResumeLayout(false);
            groupMasterRunes.ResumeLayout(false);
            groupMasterRunes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericMasterRunes3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericMasterRunes2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericMasterRunes1).EndInit();
            groupPetProtectorLatent.ResumeLayout(false);
            groupPetProtectorLatent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericLatentPercent).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCocoLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericHowlerLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericRMLevel).EndInit();
            groupPlayerUpgrades.ResumeLayout(false);
            groupPlayerUpgrades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericLatentUpgrade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericAnvilUpgrade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericOwnedArchersAndPetsUpgrade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericGuildTraitUpgrade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericMemoryUpgrade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericVillageUpgrade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPVPUpgrade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericExquisiteUpgrade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericRebirthUpgrade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericDiamondUpgrade2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericDiamondUpgrade1).EndInit();
            groupSimulation.ResumeLayout(false);
            groupSimulation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericSimulationGenerations).EndInit();
            groupOptions.ResumeLayout(false);
            groupCalculations.ResumeLayout(false);
            groupCalculations.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnViewGearList;
        private Label lblDiamondUpgrade1;
        private GroupBox groupPlayerStats;
        private GroupBox groupPlayerUpgrades;
        private Label lblLatentUpgrade;
        private Label lblAnvilUpgrade;
        private Label lblOwnedArchersAndPetsUpgrade;
        private Label lblGuildTraitUpgrade;
        private Label lblMemoryUpgrade;
        private Label lblVillageUpgrade;
        private Label lblPVPUpgrade;
        private Label lblExquisiteUpgrade;
        private Label lblRebirthUpgrade;
        private Label lblDiamondUpgrade2;
        private GroupBox groupPetProtectorLatent;
        private Label lblLatentPercent;
        private Label lblCocoLevel;
        private Label lblHowlerLevel;
        private Label lblRMLevel;
        private GroupBox groupMasterRunes;
        private Label lblMasterRunes3;
        private Label lblMasterRunes2;
        private Label lblMasterRunes1;
        private GroupBox groupCalculations;
        private Button btnCalculateAL;
        private Label lblPercentIncreaseCalcTotal;
        private TextBox txtPercentIncreaseCalcTotal;
        private Label lblRuneCalcTotal;
        private TextBox txtRuneCalcTotal;
        private GroupBox groupOptions;
        private Button btnLoadPlayerStats;
        private Button btnSavePlayerStats;
        private Label lblALCalcTotal;
        private TextBox txtALCalcTotal;
        private Button btnViewStoneTeamAndEquip;
        private Label lblBowAndBowAwakenCalcTotal;
        private TextBox txtBowAndBowAwakenCalcTotal;
        private Button btnSimulateOptimalTeam;
        private System.ComponentModel.BackgroundWorker backgroundWorkerMachineLearning;
        private GroupBox groupSimulation;
        private NumericUpDown numericSimulationGenerations;
        private Label lblSimulationGenerations;
        private ProgressBar progressSimulation;
        private Label lblSimulationProgress;
        private TextBox txtSimulationArrowLevel;
        private Label lblSimulationArrowLevel;
        private NumericUpDown numericMasterRunes3;
        private NumericUpDown numericMasterRunes2;
        private NumericUpDown numericMasterRunes1;
        private NumericUpDown numericLatentPercent;
        private NumericUpDown numericCocoLevel;
        private NumericUpDown numericHowlerLevel;
        private NumericUpDown numericRMLevel;
        private NumericUpDown numericLatentUpgrade;
        private NumericUpDown numericAnvilUpgrade;
        private NumericUpDown numericOwnedArchersAndPetsUpgrade;
        private NumericUpDown numericGuildTraitUpgrade;
        private NumericUpDown numericMemoryUpgrade;
        private NumericUpDown numericVillageUpgrade;
        private NumericUpDown numericPVPUpgrade;
        private NumericUpDown numericExquisiteUpgrade;
        private NumericUpDown numericRebirthUpgrade;
        private NumericUpDown numericDiamondUpgrade2;
        private NumericUpDown numericDiamondUpgrade1;
    }
}
