namespace ArcherForestGearOptimizer {
    partial class frmGear {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGear));
            btnAddNewGear = new Button();
            btnLoadGearFromFile = new Button();
            tabControlGear = new TabControl();
            tabPageBows = new TabPage();
            listViewBows = new ListView();
            imageListBows = new ImageList(components);
            tabPageQuivers = new TabPage();
            listViewQuivers = new ListView();
            imageListQuivers = new ImageList(components);
            tabPageBowAwaken = new TabPage();
            listViewBowAwakens = new ListView();
            imageListBowAwakens = new ImageList(components);
            tabPageQuiverAwaken = new TabPage();
            listViewQuiverAwakens = new ListView();
            imageListQuiverAwakens = new ImageList(components);
            panel1 = new Panel();
            panel2 = new Panel();
            cmbBonusStat = new ComboBox();
            lblBonusStat = new Label();
            cmbArcherStat = new ComboBox();
            lblArcherStat = new Label();
            cmbMainStat = new ComboBox();
            lblMainStat = new Label();
            cmbArcher = new ComboBox();
            lblArcher = new Label();
            cmbQuality = new ComboBox();
            lblQuality = new Label();
            cmbType = new ComboBox();
            lblType = new Label();
            cmbCategory = new ComboBox();
            lblCategory = new Label();
            btnSaveGearToFile = new Button();
            tabControlGear.SuspendLayout();
            tabPageBows.SuspendLayout();
            tabPageQuivers.SuspendLayout();
            tabPageBowAwaken.SuspendLayout();
            tabPageQuiverAwaken.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddNewGear
            // 
            btnAddNewGear.Location = new Point(3, 209);
            btnAddNewGear.Name = "btnAddNewGear";
            btnAddNewGear.Size = new Size(191, 23);
            btnAddNewGear.TabIndex = 0;
            btnAddNewGear.Text = "Add new gear";
            btnAddNewGear.UseVisualStyleBackColor = true;
            btnAddNewGear.Click += btnAddNewGear_Click;
            // 
            // btnLoadGearFromFile
            // 
            btnLoadGearFromFile.Dock = DockStyle.Bottom;
            btnLoadGearFromFile.Location = new Point(0, 551);
            btnLoadGearFromFile.Name = "btnLoadGearFromFile";
            btnLoadGearFromFile.Size = new Size(200, 23);
            btnLoadGearFromFile.TabIndex = 1;
            btnLoadGearFromFile.Text = "Load gear from file";
            btnLoadGearFromFile.UseVisualStyleBackColor = true;
            btnLoadGearFromFile.Click += btnLoadGearFromFile_Click;
            // 
            // tabControlGear
            // 
            tabControlGear.Controls.Add(tabPageBows);
            tabControlGear.Controls.Add(tabPageQuivers);
            tabControlGear.Controls.Add(tabPageBowAwaken);
            tabControlGear.Controls.Add(tabPageQuiverAwaken);
            tabControlGear.Dock = DockStyle.Fill;
            tabControlGear.Location = new Point(0, 0);
            tabControlGear.Name = "tabControlGear";
            tabControlGear.SelectedIndex = 0;
            tabControlGear.Size = new Size(678, 584);
            tabControlGear.TabIndex = 2;
            // 
            // tabPageBows
            // 
            tabPageBows.Controls.Add(listViewBows);
            tabPageBows.Location = new Point(4, 24);
            tabPageBows.Name = "tabPageBows";
            tabPageBows.Padding = new Padding(3);
            tabPageBows.Size = new Size(670, 556);
            tabPageBows.TabIndex = 0;
            tabPageBows.Text = "Bows";
            tabPageBows.UseVisualStyleBackColor = true;
            // 
            // listViewBows
            // 
            listViewBows.Dock = DockStyle.Fill;
            listViewBows.LargeImageList = imageListBows;
            listViewBows.Location = new Point(3, 3);
            listViewBows.Name = "listViewBows";
            listViewBows.Size = new Size(664, 550);
            listViewBows.TabIndex = 2;
            listViewBows.UseCompatibleStateImageBehavior = false;
            // 
            // imageListBows
            // 
            imageListBows.ColorDepth = ColorDepth.Depth32Bit;
            imageListBows.ImageStream = (ImageListStreamer)resources.GetObject("imageListBows.ImageStream");
            imageListBows.TransparentColor = Color.White;
            imageListBows.Images.SetKeyName(0, "t1_stone_bow.png");
            imageListBows.Images.SetKeyName(1, "t2_stone_bow.png");
            imageListBows.Images.SetKeyName(2, "t3_stone_bow.png");
            imageListBows.Images.SetKeyName(3, "t4_stone_bow.png");
            imageListBows.Images.SetKeyName(4, "t5_stone_bow.png");
            // 
            // tabPageQuivers
            // 
            tabPageQuivers.Controls.Add(listViewQuivers);
            tabPageQuivers.Location = new Point(4, 24);
            tabPageQuivers.Name = "tabPageQuivers";
            tabPageQuivers.Padding = new Padding(3);
            tabPageQuivers.Size = new Size(670, 556);
            tabPageQuivers.TabIndex = 1;
            tabPageQuivers.Text = "Quivers";
            tabPageQuivers.UseVisualStyleBackColor = true;
            // 
            // listViewQuivers
            // 
            listViewQuivers.Dock = DockStyle.Fill;
            listViewQuivers.LargeImageList = imageListQuivers;
            listViewQuivers.Location = new Point(3, 3);
            listViewQuivers.Name = "listViewQuivers";
            listViewQuivers.Size = new Size(664, 550);
            listViewQuivers.TabIndex = 3;
            listViewQuivers.UseCompatibleStateImageBehavior = false;
            // 
            // imageListQuivers
            // 
            imageListQuivers.ColorDepth = ColorDepth.Depth32Bit;
            imageListQuivers.ImageStream = (ImageListStreamer)resources.GetObject("imageListQuivers.ImageStream");
            imageListQuivers.TransparentColor = Color.White;
            imageListQuivers.Images.SetKeyName(0, "t1_stone_quiver.png");
            imageListQuivers.Images.SetKeyName(1, "t2_stone_quiver.png");
            imageListQuivers.Images.SetKeyName(2, "t3_stone_quiver.png");
            imageListQuivers.Images.SetKeyName(3, "t4_stone_quiver.png");
            imageListQuivers.Images.SetKeyName(4, "t5_stone_quiver.png");
            // 
            // tabPageBowAwaken
            // 
            tabPageBowAwaken.Controls.Add(listViewBowAwakens);
            tabPageBowAwaken.Location = new Point(4, 24);
            tabPageBowAwaken.Name = "tabPageBowAwaken";
            tabPageBowAwaken.Size = new Size(670, 556);
            tabPageBowAwaken.TabIndex = 2;
            tabPageBowAwaken.Text = "Bow Awaken";
            tabPageBowAwaken.UseVisualStyleBackColor = true;
            // 
            // listViewBowAwakens
            // 
            listViewBowAwakens.Dock = DockStyle.Fill;
            listViewBowAwakens.LargeImageList = imageListBowAwakens;
            listViewBowAwakens.Location = new Point(0, 0);
            listViewBowAwakens.Name = "listViewBowAwakens";
            listViewBowAwakens.Size = new Size(670, 556);
            listViewBowAwakens.TabIndex = 4;
            listViewBowAwakens.UseCompatibleStateImageBehavior = false;
            // 
            // imageListBowAwakens
            // 
            imageListBowAwakens.ColorDepth = ColorDepth.Depth32Bit;
            imageListBowAwakens.ImageStream = (ImageListStreamer)resources.GetObject("imageListBowAwakens.ImageStream");
            imageListBowAwakens.TransparentColor = Color.White;
            imageListBowAwakens.Images.SetKeyName(0, "t1_stone_ba.png");
            imageListBowAwakens.Images.SetKeyName(1, "t2_stone_ba.png");
            imageListBowAwakens.Images.SetKeyName(2, "t3_stone_ba.png");
            imageListBowAwakens.Images.SetKeyName(3, "t4_stone_ba.png");
            imageListBowAwakens.Images.SetKeyName(4, "t5_stone_ba.png");
            // 
            // tabPageQuiverAwaken
            // 
            tabPageQuiverAwaken.Controls.Add(listViewQuiverAwakens);
            tabPageQuiverAwaken.Location = new Point(4, 24);
            tabPageQuiverAwaken.Name = "tabPageQuiverAwaken";
            tabPageQuiverAwaken.Size = new Size(670, 556);
            tabPageQuiverAwaken.TabIndex = 3;
            tabPageQuiverAwaken.Text = "Quiver Awaken";
            tabPageQuiverAwaken.UseVisualStyleBackColor = true;
            // 
            // listViewQuiverAwakens
            // 
            listViewQuiverAwakens.Dock = DockStyle.Fill;
            listViewQuiverAwakens.LargeImageList = imageListQuiverAwakens;
            listViewQuiverAwakens.Location = new Point(0, 0);
            listViewQuiverAwakens.Name = "listViewQuiverAwakens";
            listViewQuiverAwakens.Size = new Size(670, 556);
            listViewQuiverAwakens.TabIndex = 4;
            listViewQuiverAwakens.UseCompatibleStateImageBehavior = false;
            // 
            // imageListQuiverAwakens
            // 
            imageListQuiverAwakens.ColorDepth = ColorDepth.Depth32Bit;
            imageListQuiverAwakens.ImageStream = (ImageListStreamer)resources.GetObject("imageListQuiverAwakens.ImageStream");
            imageListQuiverAwakens.TransparentColor = Color.White;
            imageListQuiverAwakens.Images.SetKeyName(0, "t1_stone_qa.png");
            imageListQuiverAwakens.Images.SetKeyName(1, "t2_stone_qa.png");
            imageListQuiverAwakens.Images.SetKeyName(2, "t3_stone_qa.png");
            imageListQuiverAwakens.Images.SetKeyName(3, "t4_stone_qa.png");
            imageListQuiverAwakens.Images.SetKeyName(4, "t5_stone_qa.png");
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControlGear);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(678, 584);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(cmbBonusStat);
            panel2.Controls.Add(lblBonusStat);
            panel2.Controls.Add(cmbArcherStat);
            panel2.Controls.Add(lblArcherStat);
            panel2.Controls.Add(cmbMainStat);
            panel2.Controls.Add(lblMainStat);
            panel2.Controls.Add(cmbArcher);
            panel2.Controls.Add(lblArcher);
            panel2.Controls.Add(cmbQuality);
            panel2.Controls.Add(lblQuality);
            panel2.Controls.Add(cmbType);
            panel2.Controls.Add(lblType);
            panel2.Controls.Add(cmbCategory);
            panel2.Controls.Add(lblCategory);
            panel2.Controls.Add(btnSaveGearToFile);
            panel2.Controls.Add(btnAddNewGear);
            panel2.Controls.Add(btnLoadGearFromFile);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(678, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 0, 0, 10);
            panel2.Size = new Size(200, 584);
            panel2.TabIndex = 4;
            // 
            // cmbBonusStat
            // 
            cmbBonusStat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBonusStat.FormattingEnabled = true;
            cmbBonusStat.Location = new Point(73, 180);
            cmbBonusStat.Name = "cmbBonusStat";
            cmbBonusStat.Size = new Size(121, 23);
            cmbBonusStat.TabIndex = 27;
            // 
            // lblBonusStat
            // 
            lblBonusStat.AutoSize = true;
            lblBonusStat.Location = new Point(3, 183);
            lblBonusStat.Name = "lblBonusStat";
            lblBonusStat.Size = new Size(62, 15);
            lblBonusStat.TabIndex = 26;
            lblBonusStat.Text = "Bonus stat";
            // 
            // cmbArcherStat
            // 
            cmbArcherStat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbArcherStat.FormattingEnabled = true;
            cmbArcherStat.Location = new Point(73, 151);
            cmbArcherStat.Name = "cmbArcherStat";
            cmbArcherStat.Size = new Size(121, 23);
            cmbArcherStat.TabIndex = 25;
            // 
            // lblArcherStat
            // 
            lblArcherStat.AutoSize = true;
            lblArcherStat.Location = new Point(3, 154);
            lblArcherStat.Name = "lblArcherStat";
            lblArcherStat.Size = new Size(64, 15);
            lblArcherStat.TabIndex = 24;
            lblArcherStat.Text = "Archer stat";
            // 
            // cmbMainStat
            // 
            cmbMainStat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMainStat.FormattingEnabled = true;
            cmbMainStat.Location = new Point(73, 122);
            cmbMainStat.Name = "cmbMainStat";
            cmbMainStat.Size = new Size(121, 23);
            cmbMainStat.TabIndex = 23;
            // 
            // lblMainStat
            // 
            lblMainStat.AutoSize = true;
            lblMainStat.Location = new Point(3, 125);
            lblMainStat.Name = "lblMainStat";
            lblMainStat.Size = new Size(56, 15);
            lblMainStat.TabIndex = 22;
            lblMainStat.Text = "Main stat";
            // 
            // cmbArcher
            // 
            cmbArcher.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbArcher.FormattingEnabled = true;
            cmbArcher.Location = new Point(73, 93);
            cmbArcher.Name = "cmbArcher";
            cmbArcher.Size = new Size(121, 23);
            cmbArcher.TabIndex = 21;
            // 
            // lblArcher
            // 
            lblArcher.AutoSize = true;
            lblArcher.Location = new Point(3, 96);
            lblArcher.Name = "lblArcher";
            lblArcher.Size = new Size(42, 15);
            lblArcher.TabIndex = 20;
            lblArcher.Text = "Archer";
            // 
            // cmbQuality
            // 
            cmbQuality.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbQuality.FormattingEnabled = true;
            cmbQuality.Location = new Point(73, 64);
            cmbQuality.Name = "cmbQuality";
            cmbQuality.Size = new Size(121, 23);
            cmbQuality.TabIndex = 19;
            // 
            // lblQuality
            // 
            lblQuality.AutoSize = true;
            lblQuality.Location = new Point(3, 67);
            lblQuality.Name = "lblQuality";
            lblQuality.Size = new Size(45, 15);
            lblQuality.TabIndex = 18;
            lblQuality.Text = "Quality";
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.Enabled = false;
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(73, 35);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(121, 23);
            cmbType.TabIndex = 17;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(3, 38);
            lblType.Name = "lblType";
            lblType.Size = new Size(31, 15);
            lblType.TabIndex = 16;
            lblType.Text = "Type";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(73, 6);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 23);
            cmbCategory.TabIndex = 15;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(3, 9);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 14;
            lblCategory.Text = "Category";
            // 
            // btnSaveGearToFile
            // 
            btnSaveGearToFile.Dock = DockStyle.Bottom;
            btnSaveGearToFile.Location = new Point(0, 528);
            btnSaveGearToFile.Name = "btnSaveGearToFile";
            btnSaveGearToFile.Size = new Size(200, 23);
            btnSaveGearToFile.TabIndex = 2;
            btnSaveGearToFile.Text = "Save gear to file";
            btnSaveGearToFile.UseVisualStyleBackColor = true;
            btnSaveGearToFile.Click += btnSaveGearToFile_Click;
            // 
            // frmGear
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 584);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "frmGear";
            Text = "Gear inventory";
            Load += frmGear_Load;
            tabControlGear.ResumeLayout(false);
            tabPageBows.ResumeLayout(false);
            tabPageQuivers.ResumeLayout(false);
            tabPageBowAwaken.ResumeLayout(false);
            tabPageQuiverAwaken.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddNewGear;
        private Button btnLoadGearFromFile;
        private TabControl tabControlGear;
        private TabPage tabPageBows;
        private TabPage tabPageQuivers;
        private TabPage tabPageBowAwaken;
        private TabPage tabPageQuiverAwaken;
        private Panel panel1;
        private Panel panel2;
        private ListView listViewBows;
        private ImageList imageListBows;
        private Button btnSaveGearToFile;
        private ImageList imageListQuivers;
        private ImageList imageListBowAwakens;
        private ImageList imageListQuiverAwakens;
        private ListView listViewQuivers;
        private ListView listViewBowAwakens;
        private ListView listViewQuiverAwakens;
        private ComboBox cmbBonusStat;
        private Label lblBonusStat;
        private ComboBox cmbArcherStat;
        private Label lblArcherStat;
        private ComboBox cmbMainStat;
        private Label lblMainStat;
        private ComboBox cmbArcher;
        private Label lblArcher;
        private ComboBox cmbQuality;
        private Label lblQuality;
        private ComboBox cmbType;
        private Label lblType;
        private ComboBox cmbCategory;
        private Label lblCategory;
    }
}