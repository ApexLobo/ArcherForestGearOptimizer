using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcherForestGearOptimizer {
    public partial class frmGear : Form {
        public frmGear() {
            InitializeComponent();
            populateComboBoxes();
        }
        private void populateComboBoxes() {
            // Populate GearCategory ComboBox
            cmbCategory.DataSource = Enum.GetValues(typeof(Gear.GearCategory));
            cmbQuality.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbQuality.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbQuality.DropDownStyle = ComboBoxStyle.DropDownList;

            // Populate GearType ComboBox
            cmbType.DataSource = Enum.GetValues(typeof(Gear.GearType));
            cmbType.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;

            // Populate GearQuality ComboBox
            cmbQuality.DataSource = Enum.GetValues(typeof(Gear.GearQuality));
            cmbQuality.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbQuality.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbQuality.DropDownStyle = ComboBoxStyle.DropDownList;

            // Populate CompatibleArcherType ComboBox
            cmbArcher.DataSource = Enum.GetValues(typeof(Archer.ArcherName));
            cmbArcher.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbArcher.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbArcher.DropDownStyle = ComboBoxStyle.DropDownList;




            // Populate MainStat ComboBox with values from 1 to 20
            for (int i = 1; i <= 20; i++) {
                cmbMainStat.Items.Add(i);
            }
            cmbMainStat.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbMainStat.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMainStat.DropDownStyle = ComboBoxStyle.DropDownList;

            // Populate ArcherStat ComboBox with values from 1 to 6
            for (int i = 1; i <= 6; i++) {
                cmbArcherStat.Items.Add(i);
            }
            cmbArcherStat.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbArcherStat.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbArcherStat.DropDownStyle = ComboBoxStyle.DropDownList;


            // Populate BonusStat ComboBox with values from 1 to 100
            for (int i = 0; i <= 100; i++) {
                cmbBonusStat.Items.Add(i);
            }
            cmbBonusStat.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbBonusStat.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBonusStat.DropDownStyle = ComboBoxStyle.DropDownList;


            cmbCategory.SelectedIndex = 0;
            cmbType.SelectedIndex = 1;
            cmbQuality.SelectedIndex = 0;
            cmbArcher.SelectedIndex = 0;
            cmbBonusStat.SelectedIndex = 0;
            cmbArcherStat.SelectedIndex = 0;
            cmbMainStat.SelectedIndex = 0;
            cmbBonusStat.SelectedIndex = 0;

        }
        public void populateUIFromGearList() {
            // Clear the UI
            listViewBows.Items.Clear();
            listViewQuivers.Items.Clear();
            listViewBowAwakens.Items.Clear();
            listViewQuiverAwakens.Items.Clear();

            // Populate the UI with the gear in the gear list
            foreach (Gear gear in GlobalData.gearList.bows) {
                ListViewItem item = new ListViewItem($"{gear.archerType}\n{gear.mainStat}/{gear.compatibleArcherStat}/{gear.bonusStat}");
                switch (gear.quality) {
                    case Gear.GearQuality.OneStar:
                        item.ImageIndex = 0;
                        break;
                    case Gear.GearQuality.TwoStar:
                        item.ImageIndex = 1;
                        break;
                    case Gear.GearQuality.ThreeStar:
                        item.ImageIndex = 2;
                        break;
                    case Gear.GearQuality.FourStar:
                        item.ImageIndex = 3;
                        break;
                    case Gear.GearQuality.FiveStar:
                        item.ImageIndex = 4;
                        break;
                }
                listViewBows.Items.Add(item);
            }

            foreach (Gear gear in GlobalData.gearList.quivers) {
                ListViewItem item = new ListViewItem($"{gear.archerType}\n{gear.mainStat}/{gear.compatibleArcherStat}/{gear.bonusStat}");
                switch (gear.quality) {
                    case Gear.GearQuality.OneStar:
                        item.ImageIndex = 0;
                        break;
                    case Gear.GearQuality.TwoStar:
                        item.ImageIndex = 1;
                        break;
                    case Gear.GearQuality.ThreeStar:
                        item.ImageIndex = 2;
                        break;
                    case Gear.GearQuality.FourStar:
                        item.ImageIndex = 3;
                        break;
                    case Gear.GearQuality.FiveStar:
                        item.ImageIndex = 4;
                        break;
                }
                listViewQuivers.Items.Add(item);
            }

            foreach(Gear gear in GlobalData.gearList.bowAwakens) {
                ListViewItem item = new ListViewItem($"{gear.archerType}\n{gear.mainStat}/{gear.compatibleArcherStat}/{gear.bonusStat}");
                switch (gear.quality) {
                    case Gear.GearQuality.OneStar:
                        item.ImageIndex = 0;
                        break;
                    case Gear.GearQuality.TwoStar:
                        item.ImageIndex = 1;
                        break;
                    case Gear.GearQuality.ThreeStar:
                        item.ImageIndex = 2;
                        break;
                    case Gear.GearQuality.FourStar:
                        item.ImageIndex = 3;
                        break;
                    case Gear.GearQuality.FiveStar:
                        item.ImageIndex = 4;
                        break;
                }
                listViewBowAwakens.Items.Add(item);
            }

            foreach(Gear gear in GlobalData.gearList.quiverAwakens) {
                ListViewItem item = new ListViewItem($"{gear.archerType}\n{gear.mainStat}/{gear.compatibleArcherStat}/{gear.bonusStat}");
                switch (gear.quality) {
                    case Gear.GearQuality.OneStar:
                        item.ImageIndex = 0;
                        break;
                    case Gear.GearQuality.TwoStar:
                        item.ImageIndex = 1;
                        break;
                    case Gear.GearQuality.ThreeStar:
                        item.ImageIndex = 2;
                        break;
                    case Gear.GearQuality.FourStar:
                        item.ImageIndex = 3;
                        break;
                    case Gear.GearQuality.FiveStar:
                        item.ImageIndex = 4;
                        break;
                }
                listViewQuiverAwakens.Items.Add(item);
            }   
        }
        private void frmGear_Load(object sender, EventArgs e) {
            if (GlobalData.gearList == null) { // If the gear list is null, create a new one
                GlobalData.gearList = new GearList();
            }
            populateUIFromGearList();
        }

        private void btnSaveGearToFile_Click(object sender, EventArgs e) {
            // Create a SaveFileDialog to choose the location to save the state
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON files (*.json)|*.json";
            saveFileDialog.DefaultExt = "json";
            saveFileDialog.AddExtension = true;
            saveFileDialog.FileName = "gear_data.json"; // Set default filename

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                FileManager.saveGearData(saveFileDialog.FileName);
            }
        }

        private void btnLoadGearFromFile_Click(object sender, EventArgs e) {
            // Create an OpenFileDialog to choose the file to load the state from
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json";
            openFileDialog.DefaultExt = "json";
            openFileDialog.AddExtension = true;
            openFileDialog.FileName = "gear_data.json"; // Set default filename

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                GlobalData.gearList = FileManager.loadGearData(openFileDialog.FileName);
                populateUIFromGearList();
            }
            
        }

        private void btnAddNewGear_Click(object sender, EventArgs e) {
            if (cmbCategory.SelectedItem == null || cmbType.SelectedItem == null || cmbQuality.SelectedItem == null || cmbArcher.SelectedItem == null || cmbMainStat.SelectedItem == null || cmbArcherStat.SelectedItem == null || cmbBonusStat.SelectedItem == null) {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            switch (cmbCategory.SelectedItem) {
                case Gear.GearCategory.Bow:
                    Gear gear = new Gear(Gear.GearCategory.Bow, (Gear.GearType)cmbType.SelectedItem, (Gear.GearQuality)cmbQuality.SelectedItem, (Archer.ArcherName)cmbArcher.SelectedItem, (int)cmbMainStat.SelectedItem, (int)cmbArcherStat.SelectedItem, (int)cmbBonusStat.SelectedItem);
                    GlobalData.gearList.bows.Add(gear);
                    break;
                case Gear.GearCategory.Quiver:
                    Gear quiver = new Gear(Gear.GearCategory.Quiver, (Gear.GearType)cmbType.SelectedItem, (Gear.GearQuality)cmbQuality.SelectedItem, (Archer.ArcherName)cmbArcher.SelectedItem, (int)cmbMainStat.SelectedItem, (int)cmbArcherStat.SelectedItem, (int)cmbBonusStat.SelectedItem);
                    GlobalData.gearList.quivers.Add(quiver);
                    break;
                case Gear.GearCategory.BowAwakening:
                    Gear bowAwakening = new Gear(Gear.GearCategory.BowAwakening, (Gear.GearType)cmbType.SelectedItem, (Gear.GearQuality)cmbQuality.SelectedItem, (Archer.ArcherName)cmbArcher.SelectedItem, (int)cmbMainStat.SelectedItem, (int)cmbArcherStat.SelectedItem, (int)cmbBonusStat.SelectedItem);
                    GlobalData.gearList.bowAwakens.Add(bowAwakening);
                    break;
                case Gear.GearCategory.QuiverAwakening:
                    Gear quiverAwakening = new Gear(Gear.GearCategory.QuiverAwakening, (Gear.GearType)cmbType.SelectedItem, (Gear.GearQuality)cmbQuality.SelectedItem, (Archer.ArcherName)cmbArcher.SelectedItem, (int)cmbMainStat.SelectedItem, (int)cmbArcherStat.SelectedItem, (int)cmbBonusStat.SelectedItem);
                    GlobalData.gearList.quiverAwakens.Add(quiverAwakening);
                    break;
            }


            // Update the ListView
            populateUIFromGearList();
        }
    }
}
