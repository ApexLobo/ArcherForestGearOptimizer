namespace ArcherForestGearOptimizer {
    partial class frmStoneTeam {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStoneTeam));
            panelArchers = new Panel();
            listViewArchers = new ListView();
            imageListArchers = new ImageList(components);
            panelUI = new Panel();
            btnSaveArchersToFile = new Button();
            btnLoadArchersFromFile = new Button();
            cmbQuiverAwaken2 = new ComboBox();
            lblQuiverAwaken2 = new Label();
            cmbQuiverAwaken1 = new ComboBox();
            lblQuiverAwaken1 = new Label();
            cmbBowAwaken2 = new ComboBox();
            lblBowAwaken2 = new Label();
            cmbBowAwaken1 = new ComboBox();
            lblBowAwaken1 = new Label();
            cmbQuiver = new ComboBox();
            lblQuiver = new Label();
            cmbBow = new ComboBox();
            lblBow = new Label();
            cmbArcher = new ComboBox();
            lblArcher = new Label();
            btnAddNewTeamMember = new Button();
            btnClearStoneTeam = new Button();
            panelArchers.SuspendLayout();
            panelUI.SuspendLayout();
            SuspendLayout();
            // 
            // panelArchers
            // 
            panelArchers.Controls.Add(listViewArchers);
            panelArchers.Dock = DockStyle.Fill;
            panelArchers.Location = new Point(0, 0);
            panelArchers.Name = "panelArchers";
            panelArchers.Padding = new Padding(5);
            panelArchers.Size = new Size(422, 888);
            panelArchers.TabIndex = 0;
            // 
            // listViewArchers
            // 
            listViewArchers.Dock = DockStyle.Fill;
            listViewArchers.LargeImageList = imageListArchers;
            listViewArchers.Location = new Point(5, 5);
            listViewArchers.Name = "listViewArchers";
            listViewArchers.Size = new Size(412, 878);
            listViewArchers.TabIndex = 2;
            listViewArchers.UseCompatibleStateImageBehavior = false;
            listViewArchers.Resize += listViewArchers_Resize;
            // 
            // imageListArchers
            // 
            imageListArchers.ColorDepth = ColorDepth.Depth32Bit;
            imageListArchers.ImageStream = (ImageListStreamer)resources.GetObject("imageListArchers.ImageStream");
            imageListArchers.TransparentColor = Color.Transparent;
            imageListArchers.Images.SetKeyName(0, "0-Lily.png");
            imageListArchers.Images.SetKeyName(1, "1-Wong.png");
            imageListArchers.Images.SetKeyName(2, "2-Murphy.png");
            imageListArchers.Images.SetKeyName(3, "3-Carp.png");
            imageListArchers.Images.SetKeyName(4, "4-Genta.png");
            imageListArchers.Images.SetKeyName(5, "5-Patty.png");
            imageListArchers.Images.SetKeyName(6, "6-Brady.png");
            imageListArchers.Images.SetKeyName(7, "7-Hog.png");
            imageListArchers.Images.SetKeyName(8, "8-Spiegel.png");
            imageListArchers.Images.SetKeyName(9, "9-Rex.png");
            imageListArchers.Images.SetKeyName(10, "10-Gazelle.png");
            imageListArchers.Images.SetKeyName(11, "11-Tony.png");
            imageListArchers.Images.SetKeyName(12, "12-Raccoo.png");
            imageListArchers.Images.SetKeyName(13, "13-Chuchu.png");
            imageListArchers.Images.SetKeyName(14, "14-Kelpie.png");
            imageListArchers.Images.SetKeyName(15, "15-Dexter.png");
            imageListArchers.Images.SetKeyName(16, "16-Todd.png");
            imageListArchers.Images.SetKeyName(17, "17-Zorro.png");
            imageListArchers.Images.SetKeyName(18, "18-Hippo.png");
            imageListArchers.Images.SetKeyName(19, "19-Simon.png");
            imageListArchers.Images.SetKeyName(20, "20-Panther.png");
            imageListArchers.Images.SetKeyName(21, "21-Drake.png");
            imageListArchers.Images.SetKeyName(22, "22-Hound.png");
            imageListArchers.Images.SetKeyName(23, "23-Koruuno.png");
            imageListArchers.Images.SetKeyName(24, "24-Tuntun.png");
            imageListArchers.Images.SetKeyName(25, "25-Nelson.png");
            imageListArchers.Images.SetKeyName(26, "26-Nancy.png");
            imageListArchers.Images.SetKeyName(27, "27-Dino.png");
            imageListArchers.Images.SetKeyName(28, "28-Pandori.png");
            imageListArchers.Images.SetKeyName(29, "29-Pappitson.png");
            imageListArchers.Images.SetKeyName(30, "30-Momo.png");
            imageListArchers.Images.SetKeyName(31, "31-Kero.png");
            imageListArchers.Images.SetKeyName(32, "32-Marty.png");
            imageListArchers.Images.SetKeyName(33, "33-Zelda.png");
            imageListArchers.Images.SetKeyName(34, "34-Julian.png");
            imageListArchers.Images.SetKeyName(35, "35-Bunny.png");
            imageListArchers.Images.SetKeyName(36, "36-Beef.png");
            imageListArchers.Images.SetKeyName(37, "37-LilKong.png");
            imageListArchers.Images.SetKeyName(38, "38-Nereus.png");
            imageListArchers.Images.SetKeyName(39, "39-Tyger.png");
            imageListArchers.Images.SetKeyName(40, "40-Rhino.png");
            imageListArchers.Images.SetKeyName(41, "41-Taurus.png");
            imageListArchers.Images.SetKeyName(42, "42-Shaq.png");
            imageListArchers.Images.SetKeyName(43, "43-Raffe.png");
            imageListArchers.Images.SetKeyName(44, "44-Brownie.png");
            imageListArchers.Images.SetKeyName(45, "45-Scar.png");
            imageListArchers.Images.SetKeyName(46, "46-Olorun.png");
            imageListArchers.Images.SetKeyName(47, "47-Chronos.png");
            imageListArchers.Images.SetKeyName(48, "48-Kungbao.png");
            imageListArchers.Images.SetKeyName(49, "49-Hedwig.png");
            imageListArchers.Images.SetKeyName(50, "50-Kawiil.png");
            imageListArchers.Images.SetKeyName(51, "51-Sylphy.png");
            imageListArchers.Images.SetKeyName(52, "52-Isaac.png");
            // 
            // panelUI
            // 
            panelUI.Controls.Add(btnSaveArchersToFile);
            panelUI.Controls.Add(btnLoadArchersFromFile);
            panelUI.Controls.Add(cmbQuiverAwaken2);
            panelUI.Controls.Add(lblQuiverAwaken2);
            panelUI.Controls.Add(cmbQuiverAwaken1);
            panelUI.Controls.Add(lblQuiverAwaken1);
            panelUI.Controls.Add(cmbBowAwaken2);
            panelUI.Controls.Add(lblBowAwaken2);
            panelUI.Controls.Add(cmbBowAwaken1);
            panelUI.Controls.Add(lblBowAwaken1);
            panelUI.Controls.Add(cmbQuiver);
            panelUI.Controls.Add(lblQuiver);
            panelUI.Controls.Add(cmbBow);
            panelUI.Controls.Add(lblBow);
            panelUI.Controls.Add(cmbArcher);
            panelUI.Controls.Add(lblArcher);
            panelUI.Controls.Add(btnAddNewTeamMember);
            panelUI.Controls.Add(btnClearStoneTeam);
            panelUI.Dock = DockStyle.Right;
            panelUI.Location = new Point(422, 0);
            panelUI.Name = "panelUI";
            panelUI.Padding = new Padding(0, 0, 0, 10);
            panelUI.Size = new Size(347, 888);
            panelUI.TabIndex = 1;
            // 
            // btnSaveArchersToFile
            // 
            btnSaveArchersToFile.Dock = DockStyle.Bottom;
            btnSaveArchersToFile.Location = new Point(0, 807);
            btnSaveArchersToFile.Name = "btnSaveArchersToFile";
            btnSaveArchersToFile.Size = new Size(347, 23);
            btnSaveArchersToFile.TabIndex = 54;
            btnSaveArchersToFile.Text = "Save archers to file";
            btnSaveArchersToFile.UseVisualStyleBackColor = true;
            btnSaveArchersToFile.Click += btnSaveArchersToFile_Click;
            // 
            // btnLoadArchersFromFile
            // 
            btnLoadArchersFromFile.Dock = DockStyle.Bottom;
            btnLoadArchersFromFile.Location = new Point(0, 830);
            btnLoadArchersFromFile.Name = "btnLoadArchersFromFile";
            btnLoadArchersFromFile.Size = new Size(347, 23);
            btnLoadArchersFromFile.TabIndex = 53;
            btnLoadArchersFromFile.Text = "Load archers from file";
            btnLoadArchersFromFile.UseVisualStyleBackColor = true;
            btnLoadArchersFromFile.Click += btnLoadArchersFromFile_Click;
            // 
            // cmbQuiverAwaken2
            // 
            cmbQuiverAwaken2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbQuiverAwaken2.FormattingEnabled = true;
            cmbQuiverAwaken2.Location = new Point(110, 186);
            cmbQuiverAwaken2.Name = "cmbQuiverAwaken2";
            cmbQuiverAwaken2.Size = new Size(225, 23);
            cmbQuiverAwaken2.TabIndex = 52;
            // 
            // lblQuiverAwaken2
            // 
            lblQuiverAwaken2.AutoSize = true;
            lblQuiverAwaken2.Location = new Point(8, 189);
            lblQuiverAwaken2.Name = "lblQuiverAwaken2";
            lblQuiverAwaken2.Size = new Size(96, 15);
            lblQuiverAwaken2.TabIndex = 51;
            lblQuiverAwaken2.Text = "Quiver Awaken 2";
            // 
            // cmbQuiverAwaken1
            // 
            cmbQuiverAwaken1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbQuiverAwaken1.FormattingEnabled = true;
            cmbQuiverAwaken1.Location = new Point(110, 157);
            cmbQuiverAwaken1.Name = "cmbQuiverAwaken1";
            cmbQuiverAwaken1.Size = new Size(225, 23);
            cmbQuiverAwaken1.TabIndex = 50;
            // 
            // lblQuiverAwaken1
            // 
            lblQuiverAwaken1.AutoSize = true;
            lblQuiverAwaken1.Location = new Point(8, 160);
            lblQuiverAwaken1.Name = "lblQuiverAwaken1";
            lblQuiverAwaken1.Size = new Size(96, 15);
            lblQuiverAwaken1.TabIndex = 49;
            lblQuiverAwaken1.Text = "Quiver Awaken 1";
            // 
            // cmbBowAwaken2
            // 
            cmbBowAwaken2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBowAwaken2.FormattingEnabled = true;
            cmbBowAwaken2.Location = new Point(110, 128);
            cmbBowAwaken2.Name = "cmbBowAwaken2";
            cmbBowAwaken2.Size = new Size(225, 23);
            cmbBowAwaken2.TabIndex = 48;
            // 
            // lblBowAwaken2
            // 
            lblBowAwaken2.AutoSize = true;
            lblBowAwaken2.Location = new Point(8, 131);
            lblBowAwaken2.Name = "lblBowAwaken2";
            lblBowAwaken2.Size = new Size(84, 15);
            lblBowAwaken2.TabIndex = 47;
            lblBowAwaken2.Text = "Bow Awaken 2";
            // 
            // cmbBowAwaken1
            // 
            cmbBowAwaken1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBowAwaken1.FormattingEnabled = true;
            cmbBowAwaken1.Location = new Point(110, 99);
            cmbBowAwaken1.Name = "cmbBowAwaken1";
            cmbBowAwaken1.Size = new Size(225, 23);
            cmbBowAwaken1.TabIndex = 46;
            // 
            // lblBowAwaken1
            // 
            lblBowAwaken1.AutoSize = true;
            lblBowAwaken1.Location = new Point(8, 102);
            lblBowAwaken1.Name = "lblBowAwaken1";
            lblBowAwaken1.Size = new Size(84, 15);
            lblBowAwaken1.TabIndex = 45;
            lblBowAwaken1.Text = "Bow Awaken 1";
            // 
            // cmbQuiver
            // 
            cmbQuiver.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbQuiver.FormattingEnabled = true;
            cmbQuiver.Location = new Point(110, 70);
            cmbQuiver.Name = "cmbQuiver";
            cmbQuiver.Size = new Size(225, 23);
            cmbQuiver.TabIndex = 44;
            // 
            // lblQuiver
            // 
            lblQuiver.AutoSize = true;
            lblQuiver.Location = new Point(8, 73);
            lblQuiver.Name = "lblQuiver";
            lblQuiver.Size = new Size(42, 15);
            lblQuiver.TabIndex = 43;
            lblQuiver.Text = "Quiver";
            // 
            // cmbBow
            // 
            cmbBow.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBow.FormattingEnabled = true;
            cmbBow.Location = new Point(110, 41);
            cmbBow.Name = "cmbBow";
            cmbBow.Size = new Size(225, 23);
            cmbBow.TabIndex = 42;
            // 
            // lblBow
            // 
            lblBow.AutoSize = true;
            lblBow.Location = new Point(8, 44);
            lblBow.Name = "lblBow";
            lblBow.Size = new Size(30, 15);
            lblBow.TabIndex = 41;
            lblBow.Text = "Bow";
            // 
            // cmbArcher
            // 
            cmbArcher.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbArcher.FormattingEnabled = true;
            cmbArcher.Location = new Point(110, 12);
            cmbArcher.Name = "cmbArcher";
            cmbArcher.Size = new Size(225, 23);
            cmbArcher.TabIndex = 36;
            // 
            // lblArcher
            // 
            lblArcher.AutoSize = true;
            lblArcher.Location = new Point(8, 15);
            lblArcher.Name = "lblArcher";
            lblArcher.Size = new Size(42, 15);
            lblArcher.TabIndex = 35;
            lblArcher.Text = "Archer";
            // 
            // btnAddNewTeamMember
            // 
            btnAddNewTeamMember.Location = new Point(8, 215);
            btnAddNewTeamMember.Name = "btnAddNewTeamMember";
            btnAddNewTeamMember.Size = new Size(327, 23);
            btnAddNewTeamMember.TabIndex = 28;
            btnAddNewTeamMember.Text = "Add new team member";
            btnAddNewTeamMember.UseVisualStyleBackColor = true;
            btnAddNewTeamMember.Click += btnAddNewTeamMember_Click;
            // 
            // btnClearStoneTeam
            // 
            btnClearStoneTeam.Dock = DockStyle.Bottom;
            btnClearStoneTeam.Location = new Point(0, 853);
            btnClearStoneTeam.Name = "btnClearStoneTeam";
            btnClearStoneTeam.Size = new Size(347, 25);
            btnClearStoneTeam.TabIndex = 55;
            btnClearStoneTeam.Text = "Clear stone team";
            btnClearStoneTeam.UseVisualStyleBackColor = true;
            btnClearStoneTeam.Click += btnClearStoneTeam_Click;
            // 
            // frmStoneTeam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 888);
            Controls.Add(panelArchers);
            Controls.Add(panelUI);
            Name = "frmStoneTeam";
            Text = "Stone team";
            Load += frmStoneTeam_Load;
            panelArchers.ResumeLayout(false);
            panelUI.ResumeLayout(false);
            panelUI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelArchers;
        private Panel panelUI;
        private ListView listViewArchers;
        private ImageList imageListArchers;
        private ComboBox cmbBow;
        private Label lblBow;
        private ComboBox cmbArcher;
        private Label lblArcher;
        private Button btnAddNewTeamMember;
        private ComboBox cmbQuiver;
        private Label lblQuiver;
        private ComboBox cmbQuiverAwaken2;
        private Label lblQuiverAwaken2;
        private ComboBox cmbQuiverAwaken1;
        private Label lblQuiverAwaken1;
        private ComboBox cmbBowAwaken2;
        private Label lblBowAwaken2;
        private ComboBox cmbBowAwaken1;
        private Label lblBowAwaken1;
        private Button btnSaveArchersToFile;
        private Button btnLoadArchersFromFile;
        private Button btnClearStoneTeam;
    }
}