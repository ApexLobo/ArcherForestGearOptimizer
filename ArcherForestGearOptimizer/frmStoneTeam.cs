using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcherForestGearOptimizer {
    public partial class frmStoneTeam : Form {
        public class ComboBoxGearItem {
            public string displayString { get; set; }
            public Gear gear { get; set; }
            public ComboBoxGearItem(string displayString, Gear gear) {
                this.displayString = displayString;
                this.gear = gear;
            }
        }
        public frmStoneTeam() {
            InitializeComponent();
            populateComboBoxes();

            listViewArchers.View = View.Tile;
            listViewArchers.TileSize = new Size(listViewArchers.Width - 4, 120);
        }
        // Method to add "None" option and set DataSource for a ComboBox
        private void setComboBoxDataSourceWithNoneOption(ComboBox comboBox, IEnumerable<dynamic> source) {
            var itemsWithNone = new[] { new ComboBoxGearItem("None", null) }.Concat(source).ToList();
            comboBox.DataSource = itemsWithNone;
            comboBox.DisplayMember = "displayString";
        }
        private void populateComboBoxes() {
            // Populate GearCategory ComboBox
            cmbArcher.DataSource = Enum.GetValues(typeof(Archer.ArcherName));
            cmbArcher.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbArcher.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbArcher.DropDownStyle = ComboBoxStyle.DropDownList;



            // Populate Bows ComboBox
            var bows = GlobalData.availableGearList.bows.Select(gear => new ComboBoxGearItem(gear.ToShorterString(), gear)).ToList();
            setComboBoxDataSourceWithNoneOption(cmbBow, bows);

            // Populate Quiver ComboBox
            var quivers = GlobalData.availableGearList.quivers.Select(gear => new ComboBoxGearItem(gear.ToShorterString(), gear)).ToList();
            setComboBoxDataSourceWithNoneOption(cmbQuiver, quivers);

            // Populate BowAwaken1 ComboBox
            var bowAwakens = GlobalData.availableGearList.bowAwakens.Select(gear => new ComboBoxGearItem(gear.ToShorterString(), gear)).ToList();
            setComboBoxDataSourceWithNoneOption(cmbBowAwaken1, bowAwakens);

            // Populate BowAwaken2 ComboBox
            setComboBoxDataSourceWithNoneOption(cmbBowAwaken2, bowAwakens);

            // Populate QuiverAwaken1 ComboBox
            var quiverAwakens = GlobalData.availableGearList.quiverAwakens.Select(gear => new ComboBoxGearItem(gear.ToShorterString(), gear)).ToList();
            setComboBoxDataSourceWithNoneOption(cmbQuiverAwaken1, quiverAwakens);

            // Populate QuiverAwaken2 ComboBox
            setComboBoxDataSourceWithNoneOption(cmbQuiverAwaken2, quiverAwakens);

        }
        private void frmStoneTeam_Load(object sender, EventArgs e) {
            if (GlobalData.currentStoneTeam == null) {
                GlobalData.currentStoneTeam = new StoneTeam();
            }

            updateListView();
        }

        public void updateListView() {
            listViewArchers.Items.Clear();
            // Add column headers so the subitems will appear.
            listViewArchers.Columns.AddRange(new ColumnHeader[] { new ColumnHeader(), new ColumnHeader(), new ColumnHeader(), new ColumnHeader(), new ColumnHeader(), new ColumnHeader(), new ColumnHeader() });

            foreach (Archer archer in GlobalData.currentStoneTeam.archers) {
                //ListViewItem item = new ListViewItem($"{archer.name}\n{archer.equippedBow}\n{archer.equippedQuiver}\n{archer.equippedBowAwakening1}\n{archer.equippedBowAwakening2}\n{archer.equippedQuiverAwakening1}\n{archer.equippedQuiverAwakening2}");
                ListViewItem item = new ListViewItem(new string[] { $"{archer.name}", $"{archer.equippedBow}", $"{archer.equippedQuiver}", $"{archer.equippedBowAwakening1}", $"{archer.equippedBowAwakening2}", $"{archer.equippedQuiverAwakening1}", $"{archer.equippedQuiverAwakening2}" });

                item.ImageIndex = (int)archer.name;
                listViewArchers.Items.Add(item);
            }
        }

        private void btnAddNewTeamMember_Click(object sender, EventArgs e) {

            if (GlobalData.currentStoneTeam.archers.Count < 8) {
                Archer.ArcherName selectedArcherName = (Archer.ArcherName)cmbArcher.SelectedItem;
                Archer newArcher = new Archer(selectedArcherName);

                newArcher.equippedBow = ((ComboBoxGearItem)cmbBow.SelectedItem).gear;
                newArcher.equippedQuiver = ((ComboBoxGearItem)cmbQuiver.SelectedItem).gear;
                newArcher.equippedBowAwakening1 = ((ComboBoxGearItem)cmbBowAwaken1.SelectedItem).gear;
                newArcher.equippedBowAwakening2 = ((ComboBoxGearItem)cmbBowAwaken2.SelectedItem).gear;
                newArcher.equippedQuiverAwakening1 = ((ComboBoxGearItem)cmbQuiverAwaken1.SelectedItem).gear;
                newArcher.equippedQuiverAwakening2 = ((ComboBoxGearItem)cmbQuiverAwaken2.SelectedItem).gear;


                GlobalData.removeGearFromAvailableList(newArcher.equippedBow);
                GlobalData.removeGearFromAvailableList(newArcher.equippedQuiver);
                GlobalData.removeGearFromAvailableList(newArcher.equippedBowAwakening1);
                GlobalData.removeGearFromAvailableList(newArcher.equippedBowAwakening2);
                GlobalData.removeGearFromAvailableList(newArcher.equippedQuiverAwakening1);
                GlobalData.removeGearFromAvailableList(newArcher.equippedQuiverAwakening2);

                GlobalData.currentStoneTeam.archers.Add(newArcher);

                populateComboBoxes();
                updateListView();
            } else {
                MessageBox.Show("You already have 8 members on the stone team");
            }
        }

        private void btnSaveArchersToFile_Click(object sender, EventArgs e) {
            // Create a SaveFileDialog to choose the location to save the state
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON files (*.json)|*.json";
            saveFileDialog.DefaultExt = "json";
            saveFileDialog.AddExtension = true;
            saveFileDialog.FileName = "archer_data.json"; // Set default filename

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                FileManager.saveStoneTeamData(saveFileDialog.FileName);
            }
        }

        private void btnLoadArchersFromFile_Click(object sender, EventArgs e) {
            // Create an OpenFileDialog to choose the file to load the state from
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json";
            openFileDialog.DefaultExt = "json";
            openFileDialog.AddExtension = true;
            openFileDialog.FileName = "archer_data.json"; // Set default filename

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                GlobalData.currentStoneTeam = FileManager.loadStoneTeamData(openFileDialog.FileName);
                updateListView();
            }
        }

        private void btnClearStoneTeam_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show(
                            $"Do you want to clear the current team?",
                            "Clear Current Team",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                            );

            if (result == DialogResult.Yes) {
                GlobalData.currentStoneTeam = new StoneTeam();
                updateListView();
            }
        }

        private void listViewArchers_Resize(object sender, EventArgs e) {
            listViewArchers.TileSize = new Size(listViewArchers.Width - 4, listViewArchers.TileSize.Height);
        }
    }
}
