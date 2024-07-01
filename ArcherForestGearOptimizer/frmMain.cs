using Newtonsoft.Json;
using System.Windows.Forms;

namespace ArcherForestGearOptimizer {
    public partial class frmMain : Form {

        public frmGear gearForm { get; set; }

        public frmStoneTeam stoneTeamForm { get; set; }

        public MachineLearning machineLearning { get; set; }

        public frmMain() {
            InitializeComponent();
        }
        private void calculateAndPopulateArrowLevel() {
            populatePlayerFromUI();

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

            double runeArrowLevel = ArrowLevelCalculator.calculateRuneArrowLevel();

            int bowArrowLevel = ArrowLevelCalculator.calculateBowArrowLevel();

            double totalPercentIncreaseArrowLevel = ArrowLevelCalculator.calculatePercentIncreaseArrowLevel(playerUpgradeArrowLevel, bowArrowLevel, runeArrowLevel);

            double totalArrowLevel = ArrowLevelCalculator.calculateTotalArrowLevel(playerUpgradeArrowLevel, runeArrowLevel, totalPercentIncreaseArrowLevel);

            GlobalData.player.runeArrowLevel = runeArrowLevel;

            GlobalData.player.percentIncreaseArrowLevel = totalPercentIncreaseArrowLevel;

            GlobalData.player.bowArrowLevel = bowArrowLevel;

            GlobalData.player.totalArrowLevel = totalArrowLevel;

            populateUIFromPlayer();
        }
        private void btnCalculateAL_Click(object sender, EventArgs e) {
            calculateAndPopulateArrowLevel();
        }

        private void btnSavePlayerStats_Click(object sender, EventArgs e) {
            // Create a SaveFileDialog to choose the location to save the state
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON files (*.json)|*.json";
            saveFileDialog.DefaultExt = "json";
            saveFileDialog.AddExtension = true;
            saveFileDialog.FileName = "player_data.json"; // Set default filename

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                populatePlayerFromUI();
                FileManager.savePlayerData(saveFileDialog.FileName);
            }
        }

        private void btnLoadPlayerStats_Click(object sender, EventArgs e) {
            // Create an OpenFileDialog to choose the file to load the state from
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json";
            openFileDialog.DefaultExt = "json";
            openFileDialog.AddExtension = true;
            openFileDialog.FileName = "player_data.json"; // Set default filename

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                FileManager.loadPlayerData(openFileDialog.FileName);
                populateUIFromPlayer();
            }
        }
        private void populatePlayerFromUI() {
            GlobalData.player.diamondUpgrade1 = int.Parse(numericDiamondUpgrade1.Text);
            GlobalData.player.diamondUpgrade2 = int.Parse(numericDiamondUpgrade2.Text);
            GlobalData.player.rebirthUpgrade = int.Parse(numericRebirthUpgrade.Text);
            GlobalData.player.exquisiteUpgrade = int.Parse(numericExquisiteUpgrade.Text);
            GlobalData.player.pvpUpgrade = int.Parse(numericPVPUpgrade.Text);
            GlobalData.player.villageUpgrade = int.Parse(numericVillageUpgrade.Text);
            GlobalData.player.memoryOfBowUpgrade = int.Parse(numericMemoryUpgrade.Text);
            GlobalData.player.guildTraitUpgrade = int.Parse(numericGuildTraitUpgrade.Text);
            GlobalData.player.ownedArchersAndPetsUpgrade = int.Parse(numericOwnedArchersAndPetsUpgrade.Text);
            GlobalData.player.anvilUpgrade = int.Parse(numericAnvilUpgrade.Text);
            GlobalData.player.latentUpgrade = int.Parse(numericLatentUpgrade.Text);

            GlobalData.player.rmLevel = int.Parse(numericRMLevel.Text);
            GlobalData.player.howlerLevel = int.Parse(numericHowlerLevel.Text);
            GlobalData.player.cocoLevel = int.Parse(numericCocoLevel.Text);
            GlobalData.player.latentPercent = int.Parse(numericLatentPercent.Text);

            GlobalData.player.masterRune1 = int.Parse(numericMasterRunes1.Text);
            GlobalData.player.masterRune2 = int.Parse(numericMasterRunes2.Text);
            GlobalData.player.masterRune3 = int.Parse(numericMasterRunes3.Text);


            if (txtRuneCalcTotal.Text != "") {
                GlobalData.player.runeArrowLevel = double.Parse(txtRuneCalcTotal.Text);
            } else {
                GlobalData.player.runeArrowLevel = 0;
            }

            if (txtBowAndBowAwakenCalcTotal.Text != "") {
                GlobalData.player.bowArrowLevel = int.Parse(txtBowAndBowAwakenCalcTotal.Text);
            } else {
                GlobalData.player.bowArrowLevel = 0;
            }

            if (txtPercentIncreaseCalcTotal.Text != "") {
                GlobalData.player.percentIncreaseArrowLevel = double.Parse(txtPercentIncreaseCalcTotal.Text);
            } else {
                GlobalData.player.percentIncreaseArrowLevel = 0;
            }

            if (txtALCalcTotal.Text != "") {
                GlobalData.player.totalArrowLevel = double.Parse(txtALCalcTotal.Text);
            } else {
                GlobalData.player.totalArrowLevel = 0;
            }
        }
        private void populateUIFromPlayer() {
            numericDiamondUpgrade1.Text = GlobalData.player.diamondUpgrade1.ToString();
            numericDiamondUpgrade2.Text = GlobalData.player.diamondUpgrade2.ToString();
            numericRebirthUpgrade.Text = GlobalData.player.rebirthUpgrade.ToString();
            numericExquisiteUpgrade.Text = GlobalData.player.exquisiteUpgrade.ToString();
            numericPVPUpgrade.Text = GlobalData.player.pvpUpgrade.ToString();
            numericVillageUpgrade.Text = GlobalData.player.villageUpgrade.ToString();
            numericMemoryUpgrade.Text = GlobalData.player.memoryOfBowUpgrade.ToString();
            numericGuildTraitUpgrade.Text = GlobalData.player.guildTraitUpgrade.ToString();
            numericOwnedArchersAndPetsUpgrade.Text = GlobalData.player.ownedArchersAndPetsUpgrade.ToString();
            numericAnvilUpgrade.Text = GlobalData.player.anvilUpgrade.ToString();
            numericLatentUpgrade.Text = GlobalData.player.latentUpgrade.ToString();

            numericRMLevel.Text = GlobalData.player.rmLevel.ToString();
            numericHowlerLevel.Text = GlobalData.player.howlerLevel.ToString();
            numericCocoLevel.Text = GlobalData.player.cocoLevel.ToString();
            numericLatentPercent.Text = GlobalData.player.latentPercent.ToString();

            numericMasterRunes1.Text = GlobalData.player.masterRune1.ToString();
            numericMasterRunes2.Text = GlobalData.player.masterRune2.ToString();
            numericMasterRunes3.Text = GlobalData.player.masterRune3.ToString();

            txtRuneCalcTotal.Text = GlobalData.player.runeArrowLevel.ToString("F2");

            txtBowAndBowAwakenCalcTotal.Text = GlobalData.player.bowArrowLevel.ToString();

            txtPercentIncreaseCalcTotal.Text = GlobalData.player.percentIncreaseArrowLevel.ToString("F2");

            txtALCalcTotal.Text = GlobalData.player.totalArrowLevel.ToString("F2");
        }

        private void btnViewGearList_Click(object sender, EventArgs e) {
            if (gearForm.IsDisposed) {
                gearForm = new frmGear();
            }
            gearForm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            GlobalData.player = FileManager.loadPlayerData();
            if (GlobalData.player == null) {
                GlobalData.player = new Player();
            }

            GlobalData.gearList = FileManager.loadGearData();
            if (GlobalData.gearList == null) {
                GlobalData.gearList = new GearList();
            }

            // Reverse the lists so that the highest level gear is at the top
            GlobalData.gearList.bows.Reverse();
            GlobalData.gearList.bowAwakens.Reverse();
            GlobalData.gearList.quiverAwakens.Reverse();
            GlobalData.gearList.quivers.Reverse();

            GlobalData.availableGearList = GlobalData.gearList.clone();


            GlobalData.currentStoneTeam = FileManager.loadStoneTeamData();

            if (GlobalData.currentStoneTeam == null) {
                GlobalData.currentStoneTeam = new StoneTeam();
            }

            populateUIFromPlayer();

            gearForm = new frmGear();

            stoneTeamForm = new frmStoneTeam();
        }

        private void btnViewStoneTeamAndEquip_Click(object sender, EventArgs e) {
            if (stoneTeamForm.IsDisposed) {
                stoneTeamForm = new frmStoneTeam();
            }
            stoneTeamForm.Show();
        }

        private void btnSimulateOptimalTeam_Click(object sender, EventArgs e) {

            if (btnSimulateOptimalTeam.Text == "Start optimal team simulation") {
                btnSimulateOptimalTeam.Text = "Stop optimal team simulation";
                // Start the calculation
                backgroundWorkerMachineLearning.RunWorkerAsync();
            } else { // Stop the calculation
                btnSimulateOptimalTeam.Text = "Start optimal team simulation";
                if (backgroundWorkerMachineLearning.IsBusy) {
                    backgroundWorkerMachineLearning.CancelAsync();
                }
            }

        }

        private void backgroundWorkerMachineLearning_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e) {
            if (machineLearning == null) {
                machineLearning = new MachineLearning();
            }

            StoneTeam bestTeam = machineLearning.getBestStoneTeam(backgroundWorkerMachineLearning,(int)numericSimulationGenerations.Value);

            // Store the best team in the result
            e.Result = bestTeam;
        }

        private void backgroundWorkerMachineLearning_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e) {
            int progressPercentage = e.ProgressPercentage;
            double bestFitness = (double)e.UserState;

            // Update UI with the progress and best arrow level
            if (InvokeRequired) {
                Invoke(new Action(() => {
                    progressSimulation.Value = progressPercentage;
                    txtSimulationArrowLevel.Text = bestFitness.ToString("F2");
                }));
            } else {
                progressSimulation.Value = progressPercentage;
                txtSimulationArrowLevel.Text = bestFitness.ToString("F2");
            }
        }

        private void backgroundWorkerMachineLearning_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e) {
            if (e.Cancelled) {
                // Handle cancellation
            } else if (e.Error != null) {
                Console.WriteLine($"Error: {e.Error.Message}");
            } else {
                // Retrieve the best team from the result
                StoneTeam bestTeam = e.Result as StoneTeam;

                if (bestTeam != null) {
                    double bestTeamFitness = bestTeam.calculateTeamArrowLevel();
                    double currentTeamFitness = GlobalData.currentStoneTeam.calculateTeamArrowLevel();

                    if (bestTeamFitness > currentTeamFitness) {
                        // Ask the user if they want to replace the current team with the best team
                        DialogResult result = MessageBox.Show(
                            $"The best team found has an arrow level of {bestTeamFitness:F2}, which is greater than the current team's arrow level of {currentTeamFitness:F2}. Do you want to replace the current team with the best team?",
                            "Replace Current Team",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                        if (result == DialogResult.Yes) {
                            // Replace the current team with the best team
                            GlobalData.currentStoneTeam = bestTeam;

                            // Update the UI in frmStoneTeam
                            if (stoneTeamForm != null) {
                                stoneTeamForm.Show();
                                stoneTeamForm.updateListView();
                            }

                            calculateAndPopulateArrowLevel();
                        }
                    }
                }

                // Update the progress bar to 100%
                if (InvokeRequired) {
                    Invoke(new Action(() => {
                        progressSimulation.Value = 100;
                        btnSimulateOptimalTeam.Text = "Start optimal team simulation";
                    }));
                } else {
                    progressSimulation.Value = 100;
                    btnSimulateOptimalTeam.Text = "Start optimal team simulation";
                }
            }
        }
    }
}
