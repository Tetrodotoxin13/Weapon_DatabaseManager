
namespace WeaponManager
{
    partial class WeaponDatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeaponDatabase));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMenu = new System.Windows.Forms.Label();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonAttachments = new System.Windows.Forms.Button();
            this.buttonWeaponDataload = new System.Windows.Forms.Button();
            this.dataGridViewWeapons = new System.Windows.Forms.DataGridView();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.picDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.labelAdd = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.AddNewPicture = new System.Windows.Forms.PictureBox();
            this.buttonAssaultRifles = new System.Windows.Forms.Button();
            this.buttonSniperRifles = new System.Windows.Forms.Button();
            this.buttonLMGs = new System.Windows.Forms.Button();
            this.buttonLaunchers = new System.Windows.Forms.Button();
            this.buttonMelee = new System.Windows.Forms.Button();
            this.buttonMarksmanRifles = new System.Windows.Forms.Button();
            this.buttonHandguns = new System.Windows.Forms.Button();
            this.buttonSMGs = new System.Windows.Forms.Button();
            this.buttonShotguns = new System.Windows.Forms.Button();
            this.groupBoxWeaponTypes = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeapons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddNewPicture)).BeginInit();
            this.groupBoxWeaponTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.BackgroundImage = global::WeaponManager.Properties.Resources.whitetopoblur;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Image = global::WeaponManager.Properties.Resources.whitetopoblur;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Weapon Database";
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackgroundImage = global::WeaponManager.Properties.Resources.whitetopoblur;
            this.pictureBoxClose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = global::WeaponManager.Properties.Resources.exit;
            this.pictureBoxClose.Location = new System.Drawing.Point(895, 12);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(35, 32);
            this.pictureBoxClose.TabIndex = 0;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.labelMenu);
            this.panel2.Controls.Add(this.buttonUsers);
            this.panel2.Controls.Add(this.buttonAttachments);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 46);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(558, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "On this interface you can add, update or delete from the database. ";
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.Location = new System.Drawing.Point(582, 12);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(65, 19);
            this.labelMenu.TabIndex = 6;
            this.labelMenu.Text = "| Menu |";
            // 
            // buttonUsers
            // 
            this.buttonUsers.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUsers.Font = new System.Drawing.Font("Stencil", 8.25F);
            this.buttonUsers.Location = new System.Drawing.Point(808, 6);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(115, 31);
            this.buttonUsers.TabIndex = 5;
            this.buttonUsers.Text = "User Monitoring";
            this.buttonUsers.UseVisualStyleBackColor = false;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonAttachments
            // 
            this.buttonAttachments.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonAttachments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAttachments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAttachments.Font = new System.Drawing.Font("Stencil", 8.25F);
            this.buttonAttachments.Location = new System.Drawing.Point(657, 6);
            this.buttonAttachments.Name = "buttonAttachments";
            this.buttonAttachments.Size = new System.Drawing.Size(145, 31);
            this.buttonAttachments.TabIndex = 2;
            this.buttonAttachments.Text = "Attachment Database";
            this.buttonAttachments.UseVisualStyleBackColor = false;
            this.buttonAttachments.Click += new System.EventHandler(this.buttonAttachments_Click);
            // 
            // buttonWeaponDataload
            // 
            this.buttonWeaponDataload.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonWeaponDataload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWeaponDataload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWeaponDataload.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWeaponDataload.Location = new System.Drawing.Point(14, 112);
            this.buttonWeaponDataload.Name = "buttonWeaponDataload";
            this.buttonWeaponDataload.Size = new System.Drawing.Size(240, 31);
            this.buttonWeaponDataload.TabIndex = 4;
            this.buttonWeaponDataload.Text = "Load Database";
            this.buttonWeaponDataload.UseVisualStyleBackColor = false;
            this.buttonWeaponDataload.Click += new System.EventHandler(this.buttonWeaponDataload_Click);
            // 
            // dataGridViewWeapons
            // 
            this.dataGridViewWeapons.AllowUserToAddRows = false;
            this.dataGridViewWeapons.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridViewWeapons.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewWeapons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewWeapons.ColumnHeadersHeight = 30;
            this.dataGridViewWeapons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewWeapons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column12,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.picEdit,
            this.picDelete});
            this.dataGridViewWeapons.EnableHeadersVisualStyles = false;
            this.dataGridViewWeapons.Location = new System.Drawing.Point(0, 378);
            this.dataGridViewWeapons.Name = "dataGridViewWeapons";
            this.dataGridViewWeapons.ReadOnly = true;
            this.dataGridViewWeapons.RowHeadersVisible = false;
            this.dataGridViewWeapons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewWeapons.Size = new System.Drawing.Size(937, 450);
            this.dataGridViewWeapons.TabIndex = 2;
            this.dataGridViewWeapons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWeapons_CellContentClick);
            this.dataGridViewWeapons.SelectionChanged += new System.EventHandler(this.dataGridViewWeapons_SelectionChanged);
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column12.HeaderText = "#";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 37;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Weapon Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 113;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Weapon Type Number";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 153;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Weapon Number";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 124;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Accuracy";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 78;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Damage";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 78;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Range";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 67;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "Fire Rate";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "Mobility";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 72;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "Control";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 69;
            // 
            // picEdit
            // 
            this.picEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.picEdit.HeaderText = "";
            this.picEdit.Image = global::WeaponManager.Properties.Resources.modifie;
            this.picEdit.Name = "picEdit";
            this.picEdit.ReadOnly = true;
            this.picEdit.Width = 5;
            // 
            // picDelete
            // 
            this.picDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.picDelete.HeaderText = "";
            this.picDelete.Image = global::WeaponManager.Properties.Resources.delete;
            this.picDelete.Name = "picDelete";
            this.picDelete.ReadOnly = true;
            this.picDelete.Width = 5;
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAdd.Image = global::WeaponManager.Properties.Resources.blacktopo;
            this.labelAdd.Location = new System.Drawing.Point(856, 347);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(32, 16);
            this.labelAdd.TabIndex = 3;
            this.labelAdd.Text = "Add";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::WeaponManager.Properties.Resources.modifie;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // AddNewPicture
            // 
            this.AddNewPicture.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AddNewPicture.BackgroundImage = global::WeaponManager.Properties.Resources.whitetopoblur;
            this.AddNewPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AddNewPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNewPicture.Image = global::WeaponManager.Properties.Resources.plus;
            this.AddNewPicture.Location = new System.Drawing.Point(890, 338);
            this.AddNewPicture.Name = "AddNewPicture";
            this.AddNewPicture.Size = new System.Drawing.Size(35, 34);
            this.AddNewPicture.TabIndex = 1;
            this.AddNewPicture.TabStop = false;
            this.AddNewPicture.Click += new System.EventHandler(this.AddNewPicture_Click);
            // 
            // buttonAssaultRifles
            // 
            this.buttonAssaultRifles.BackColor = System.Drawing.Color.Silver;
            this.buttonAssaultRifles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAssaultRifles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAssaultRifles.Location = new System.Drawing.Point(6, 20);
            this.buttonAssaultRifles.Name = "buttonAssaultRifles";
            this.buttonAssaultRifles.Size = new System.Drawing.Size(100, 45);
            this.buttonAssaultRifles.TabIndex = 6;
            this.buttonAssaultRifles.Text = "Assault Rifles";
            this.buttonAssaultRifles.UseVisualStyleBackColor = false;
            this.buttonAssaultRifles.Click += new System.EventHandler(this.buttonAssaultRifles_Click);
            // 
            // buttonSniperRifles
            // 
            this.buttonSniperRifles.BackColor = System.Drawing.Color.Silver;
            this.buttonSniperRifles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSniperRifles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSniperRifles.Location = new System.Drawing.Point(7, 119);
            this.buttonSniperRifles.Name = "buttonSniperRifles";
            this.buttonSniperRifles.Size = new System.Drawing.Size(99, 45);
            this.buttonSniperRifles.TabIndex = 7;
            this.buttonSniperRifles.Text = "Sniper Rifles";
            this.buttonSniperRifles.UseVisualStyleBackColor = false;
            this.buttonSniperRifles.Click += new System.EventHandler(this.buttonSniperRifles_Click);
            // 
            // buttonLMGs
            // 
            this.buttonLMGs.BackColor = System.Drawing.Color.Silver;
            this.buttonLMGs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLMGs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLMGs.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLMGs.Location = new System.Drawing.Point(112, 73);
            this.buttonLMGs.Name = "buttonLMGs";
            this.buttonLMGs.Size = new System.Drawing.Size(116, 40);
            this.buttonLMGs.TabIndex = 8;
            this.buttonLMGs.Text = "LMGs";
            this.buttonLMGs.UseVisualStyleBackColor = false;
            this.buttonLMGs.Click += new System.EventHandler(this.buttonLMGs_Click);
            // 
            // buttonLaunchers
            // 
            this.buttonLaunchers.BackColor = System.Drawing.Color.Silver;
            this.buttonLaunchers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLaunchers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLaunchers.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLaunchers.Location = new System.Drawing.Point(6, 170);
            this.buttonLaunchers.Name = "buttonLaunchers";
            this.buttonLaunchers.Size = new System.Drawing.Size(73, 40);
            this.buttonLaunchers.TabIndex = 9;
            this.buttonLaunchers.Text = "Launcher";
            this.buttonLaunchers.UseVisualStyleBackColor = false;
            this.buttonLaunchers.Click += new System.EventHandler(this.buttonLaunchers_Click);
            // 
            // buttonMelee
            // 
            this.buttonMelee.BackColor = System.Drawing.Color.Silver;
            this.buttonMelee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMelee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMelee.Location = new System.Drawing.Point(171, 170);
            this.buttonMelee.Name = "buttonMelee";
            this.buttonMelee.Size = new System.Drawing.Size(58, 40);
            this.buttonMelee.TabIndex = 10;
            this.buttonMelee.Text = "Melees";
            this.buttonMelee.UseVisualStyleBackColor = false;
            this.buttonMelee.Click += new System.EventHandler(this.buttonMelee_Click);
            // 
            // buttonMarksmanRifles
            // 
            this.buttonMarksmanRifles.BackColor = System.Drawing.Color.Silver;
            this.buttonMarksmanRifles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMarksmanRifles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMarksmanRifles.Location = new System.Drawing.Point(112, 119);
            this.buttonMarksmanRifles.Name = "buttonMarksmanRifles";
            this.buttonMarksmanRifles.Size = new System.Drawing.Size(117, 45);
            this.buttonMarksmanRifles.TabIndex = 11;
            this.buttonMarksmanRifles.Text = "Marksman Rifles";
            this.buttonMarksmanRifles.UseVisualStyleBackColor = false;
            this.buttonMarksmanRifles.Click += new System.EventHandler(this.buttonMarksmanRifles_Click);
            // 
            // buttonHandguns
            // 
            this.buttonHandguns.BackColor = System.Drawing.Color.Silver;
            this.buttonHandguns.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHandguns.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHandguns.Location = new System.Drawing.Point(85, 170);
            this.buttonHandguns.Name = "buttonHandguns";
            this.buttonHandguns.Size = new System.Drawing.Size(80, 40);
            this.buttonHandguns.TabIndex = 12;
            this.buttonHandguns.Text = "Handguns";
            this.buttonHandguns.UseVisualStyleBackColor = false;
            this.buttonHandguns.Click += new System.EventHandler(this.buttonHandguns_Click);
            // 
            // buttonSMGs
            // 
            this.buttonSMGs.BackColor = System.Drawing.Color.Silver;
            this.buttonSMGs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSMGs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSMGs.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSMGs.Location = new System.Drawing.Point(112, 20);
            this.buttonSMGs.Name = "buttonSMGs";
            this.buttonSMGs.Size = new System.Drawing.Size(116, 45);
            this.buttonSMGs.TabIndex = 13;
            this.buttonSMGs.Text = "SMGs";
            this.buttonSMGs.UseVisualStyleBackColor = false;
            this.buttonSMGs.Click += new System.EventHandler(this.buttonSMGs_Click);
            // 
            // buttonShotguns
            // 
            this.buttonShotguns.BackColor = System.Drawing.Color.Silver;
            this.buttonShotguns.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShotguns.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonShotguns.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShotguns.Location = new System.Drawing.Point(7, 71);
            this.buttonShotguns.Name = "buttonShotguns";
            this.buttonShotguns.Size = new System.Drawing.Size(99, 45);
            this.buttonShotguns.TabIndex = 14;
            this.buttonShotguns.Text = "Shotguns";
            this.buttonShotguns.UseVisualStyleBackColor = false;
            this.buttonShotguns.Click += new System.EventHandler(this.buttonShotguns_Click);
            // 
            // groupBoxWeaponTypes
            // 
            this.groupBoxWeaponTypes.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBoxWeaponTypes.Controls.Add(this.buttonAssaultRifles);
            this.groupBoxWeaponTypes.Controls.Add(this.buttonLaunchers);
            this.groupBoxWeaponTypes.Controls.Add(this.buttonMelee);
            this.groupBoxWeaponTypes.Controls.Add(this.buttonHandguns);
            this.groupBoxWeaponTypes.Controls.Add(this.buttonShotguns);
            this.groupBoxWeaponTypes.Controls.Add(this.buttonMarksmanRifles);
            this.groupBoxWeaponTypes.Controls.Add(this.buttonSMGs);
            this.groupBoxWeaponTypes.Controls.Add(this.buttonLMGs);
            this.groupBoxWeaponTypes.Controls.Add(this.buttonSniperRifles);
            this.groupBoxWeaponTypes.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxWeaponTypes.Location = new System.Drawing.Point(14, 149);
            this.groupBoxWeaponTypes.Name = "groupBoxWeaponTypes";
            this.groupBoxWeaponTypes.Size = new System.Drawing.Size(238, 223);
            this.groupBoxWeaponTypes.TabIndex = 15;
            this.groupBoxWeaponTypes.TabStop = false;
            this.groupBoxWeaponTypes.Text = "Weapon Types";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Image = global::WeaponManager.Properties.Resources.blacktopo;
            this.label2.Location = new System.Drawing.Point(764, 839);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Developed by Takács Leontin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WeaponManager.Properties.Resources.weapons;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(388, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 144);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // WeaponDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::WeaponManager.Properties.Resources.blacktopo;
            this.ClientSize = new System.Drawing.Size(937, 863);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonWeaponDataload);
            this.Controls.Add(this.groupBoxWeaponTypes);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.dataGridViewWeapons);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddNewPicture);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WeaponDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeapons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddNewPicture)).EndInit();
            this.groupBoxWeaponTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewWeapons;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox AddNewPicture;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewImageColumn picEdit;
        private System.Windows.Forms.DataGridViewImageColumn picDelete;
        private System.Windows.Forms.Button buttonAttachments;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Button buttonWeaponDataload;
        private System.Windows.Forms.Button buttonAssaultRifles;
        private System.Windows.Forms.Button buttonSniperRifles;
        private System.Windows.Forms.Button buttonLMGs;
        private System.Windows.Forms.Button buttonLaunchers;
        private System.Windows.Forms.Button buttonMelee;
        private System.Windows.Forms.Button buttonMarksmanRifles;
        private System.Windows.Forms.Button buttonHandguns;
        private System.Windows.Forms.Button buttonSMGs;
        private System.Windows.Forms.Button buttonShotguns;
        private System.Windows.Forms.GroupBox groupBoxWeaponTypes;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

