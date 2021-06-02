
namespace WeaponManager
{
    partial class AttachmentAdd
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxAttachmentAddClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.labelAttachmentName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAttachmentSave = new System.Windows.Forms.Button();
            this.buttonAttachmentUpdate = new System.Windows.Forms.Button();
            this.buttonAttachmentCancel = new System.Windows.Forms.Button();
            this.textBoxAttachmentName = new System.Windows.Forms.TextBox();
            this.textBoxAttachmentTypeNumber = new System.Windows.Forms.TextBox();
            this.textBoxAttachmentNumber = new System.Windows.Forms.TextBox();
            this.textBoxAccuracyChange = new System.Windows.Forms.TextBox();
            this.textBoxDamageChange = new System.Windows.Forms.TextBox();
            this.textBoxRangeChange = new System.Windows.Forms.TextBox();
            this.textBoxFirerateChange = new System.Windows.Forms.TextBox();
            this.textBoxMobilityChange = new System.Windows.Forms.TextBox();
            this.textBoxControlChange = new System.Windows.Forms.TextBox();
            this.errorProviderAttachmentName = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonWeaponNameCheck = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAttachmentAddClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAttachmentName)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.BackgroundImage = global::WeaponManager.Properties.Resources.whitetopoblur;
            this.panel1.Controls.Add(this.pictureBoxAttachmentAddClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 60);
            this.panel1.TabIndex = 1;
            // 
            // pictureBoxAttachmentAddClose
            // 
            this.pictureBoxAttachmentAddClose.BackgroundImage = global::WeaponManager.Properties.Resources.whitetopoblur;
            this.pictureBoxAttachmentAddClose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxAttachmentAddClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAttachmentAddClose.Image = global::WeaponManager.Properties.Resources.exit;
            this.pictureBoxAttachmentAddClose.Location = new System.Drawing.Point(699, 12);
            this.pictureBoxAttachmentAddClose.Name = "pictureBoxAttachmentAddClose";
            this.pictureBoxAttachmentAddClose.Size = new System.Drawing.Size(35, 32);
            this.pictureBoxAttachmentAddClose.TabIndex = 4;
            this.pictureBoxAttachmentAddClose.TabStop = false;
            this.pictureBoxAttachmentAddClose.Click += new System.EventHandler(this.pictureBoxAttachmentAddClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Image = global::WeaponManager.Properties.Resources.whitetopoblur;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add new or modifie Attachment Database";
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = global::WeaponManager.Properties.Resources.exit;
            this.pictureBoxClose.Location = new System.Drawing.Point(895, 12);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(35, 32);
            this.pictureBoxClose.TabIndex = 0;
            this.pictureBoxClose.TabStop = false;
            // 
            // labelAttachmentName
            // 
            this.labelAttachmentName.AutoSize = true;
            this.labelAttachmentName.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAttachmentName.Image = global::WeaponManager.Properties.Resources.whitetopoblur;
            this.labelAttachmentName.Location = new System.Drawing.Point(12, 20);
            this.labelAttachmentName.Name = "labelAttachmentName";
            this.labelAttachmentName.Size = new System.Drawing.Size(120, 14);
            this.labelAttachmentName.TabIndex = 2;
            this.labelAttachmentName.Text = "Attachment Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::WeaponManager.Properties.Resources.whitetopoblur;
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Attachment Type Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::WeaponManager.Properties.Resources.whitetopoblur;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Attachment Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::WeaponManager.Properties.Resources.whitetopoblur;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Accuracy Change:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::WeaponManager.Properties.Resources.whitetopoblur;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Damage Change:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = global::WeaponManager.Properties.Resources.whitetopoblur;
            this.label6.Location = new System.Drawing.Point(12, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 14);
            this.label6.TabIndex = 7;
            this.label6.Text = "Range Change:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = global::WeaponManager.Properties.Resources.whitetopoblur;
            this.label7.Location = new System.Drawing.Point(12, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 14);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fire rate Change:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = global::WeaponManager.Properties.Resources.whitetopoblur;
            this.label8.Location = new System.Drawing.Point(12, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 14);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mobility Change:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = global::WeaponManager.Properties.Resources.whitetopoblur;
            this.label9.Location = new System.Drawing.Point(12, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 14);
            this.label9.TabIndex = 10;
            this.label9.Text = "Control Change:";
            // 
            // buttonAttachmentSave
            // 
            this.buttonAttachmentSave.BackColor = System.Drawing.Color.SlateGray;
            this.buttonAttachmentSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAttachmentSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAttachmentSave.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAttachmentSave.Location = new System.Drawing.Point(439, 422);
            this.buttonAttachmentSave.Name = "buttonAttachmentSave";
            this.buttonAttachmentSave.Size = new System.Drawing.Size(87, 32);
            this.buttonAttachmentSave.TabIndex = 21;
            this.buttonAttachmentSave.Text = "&Save";
            this.buttonAttachmentSave.UseVisualStyleBackColor = false;
            this.buttonAttachmentSave.Click += new System.EventHandler(this.buttonAttachmentSave_Click);
            // 
            // buttonAttachmentUpdate
            // 
            this.buttonAttachmentUpdate.BackColor = System.Drawing.Color.SlateGray;
            this.buttonAttachmentUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAttachmentUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAttachmentUpdate.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAttachmentUpdate.Location = new System.Drawing.Point(532, 422);
            this.buttonAttachmentUpdate.Name = "buttonAttachmentUpdate";
            this.buttonAttachmentUpdate.Size = new System.Drawing.Size(77, 32);
            this.buttonAttachmentUpdate.TabIndex = 22;
            this.buttonAttachmentUpdate.Text = "&Update";
            this.buttonAttachmentUpdate.UseVisualStyleBackColor = false;
            this.buttonAttachmentUpdate.Click += new System.EventHandler(this.buttonAttachmentUpdate_Click);
            // 
            // buttonAttachmentCancel
            // 
            this.buttonAttachmentCancel.BackColor = System.Drawing.Color.Firebrick;
            this.buttonAttachmentCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAttachmentCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAttachmentCancel.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAttachmentCancel.ForeColor = System.Drawing.Color.White;
            this.buttonAttachmentCancel.Location = new System.Drawing.Point(613, 422);
            this.buttonAttachmentCancel.Name = "buttonAttachmentCancel";
            this.buttonAttachmentCancel.Size = new System.Drawing.Size(84, 32);
            this.buttonAttachmentCancel.TabIndex = 23;
            this.buttonAttachmentCancel.Text = "&Clear";
            this.buttonAttachmentCancel.UseVisualStyleBackColor = false;
            this.buttonAttachmentCancel.Click += new System.EventHandler(this.buttonAttachmentCancel_Click);
            // 
            // textBoxAttachmentName
            // 
            this.textBoxAttachmentName.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAttachmentName.Location = new System.Drawing.Point(181, 14);
            this.textBoxAttachmentName.Name = "textBoxAttachmentName";
            this.textBoxAttachmentName.Size = new System.Drawing.Size(156, 22);
            this.textBoxAttachmentName.TabIndex = 24;
            // 
            // textBoxAttachmentTypeNumber
            // 
            this.textBoxAttachmentTypeNumber.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAttachmentTypeNumber.Location = new System.Drawing.Point(184, 14);
            this.textBoxAttachmentTypeNumber.Name = "textBoxAttachmentTypeNumber";
            this.textBoxAttachmentTypeNumber.Size = new System.Drawing.Size(56, 22);
            this.textBoxAttachmentTypeNumber.TabIndex = 25;
            this.textBoxAttachmentTypeNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAttachmentTypeNumber_KeyPress);
            // 
            // textBoxAttachmentNumber
            // 
            this.textBoxAttachmentNumber.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAttachmentNumber.Location = new System.Drawing.Point(181, 68);
            this.textBoxAttachmentNumber.Name = "textBoxAttachmentNumber";
            this.textBoxAttachmentNumber.Size = new System.Drawing.Size(156, 22);
            this.textBoxAttachmentNumber.TabIndex = 26;
            this.textBoxAttachmentNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAttachmentNumber_KeyPress);
            // 
            // textBoxAccuracyChange
            // 
            this.textBoxAccuracyChange.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAccuracyChange.Location = new System.Drawing.Point(181, 94);
            this.textBoxAccuracyChange.Name = "textBoxAccuracyChange";
            this.textBoxAccuracyChange.Size = new System.Drawing.Size(156, 22);
            this.textBoxAccuracyChange.TabIndex = 27;
            this.textBoxAccuracyChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAccuracyChange_KeyPress);
            // 
            // textBoxDamageChange
            // 
            this.textBoxDamageChange.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDamageChange.Location = new System.Drawing.Point(181, 121);
            this.textBoxDamageChange.Name = "textBoxDamageChange";
            this.textBoxDamageChange.Size = new System.Drawing.Size(156, 22);
            this.textBoxDamageChange.TabIndex = 28;
            this.textBoxDamageChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDamageChange_KeyPress);
            // 
            // textBoxRangeChange
            // 
            this.textBoxRangeChange.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRangeChange.Location = new System.Drawing.Point(181, 148);
            this.textBoxRangeChange.Name = "textBoxRangeChange";
            this.textBoxRangeChange.Size = new System.Drawing.Size(156, 22);
            this.textBoxRangeChange.TabIndex = 29;
            this.textBoxRangeChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRangeChange_KeyPress);
            // 
            // textBoxFirerateChange
            // 
            this.textBoxFirerateChange.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirerateChange.Location = new System.Drawing.Point(181, 176);
            this.textBoxFirerateChange.Name = "textBoxFirerateChange";
            this.textBoxFirerateChange.Size = new System.Drawing.Size(156, 22);
            this.textBoxFirerateChange.TabIndex = 30;
            this.textBoxFirerateChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFirerateChange_KeyPress);
            // 
            // textBoxMobilityChange
            // 
            this.textBoxMobilityChange.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMobilityChange.Location = new System.Drawing.Point(181, 203);
            this.textBoxMobilityChange.Name = "textBoxMobilityChange";
            this.textBoxMobilityChange.Size = new System.Drawing.Size(156, 22);
            this.textBoxMobilityChange.TabIndex = 31;
            this.textBoxMobilityChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMobilityChange_KeyPress);
            // 
            // textBoxControlChange
            // 
            this.textBoxControlChange.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxControlChange.Location = new System.Drawing.Point(181, 230);
            this.textBoxControlChange.Name = "textBoxControlChange";
            this.textBoxControlChange.Size = new System.Drawing.Size(156, 22);
            this.textBoxControlChange.TabIndex = 32;
            this.textBoxControlChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxControlChange_KeyPress);
            // 
            // errorProviderAttachmentName
            // 
            this.errorProviderAttachmentName.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WeaponManager.Properties.Resources.whitetopoblur;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxAttachmentTypeNumber);
            this.panel2.Location = new System.Drawing.Point(399, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 278);
            this.panel2.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Image = global::WeaponManager.Properties.Resources.blacktopo;
            this.label10.Location = new System.Drawing.Point(13, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 208);
            this.label10.TabIndex = 26;
            this.label10.Text = "Attachment type numbers:\r\n\r\n1 - Muzzle\r\n2 - Rear grip \r\n3 - Stock\r\n4 - Optic\r\n5 -" +
    " Laser\r\n6 - Pump\r\n7 - Magazine\r\n8 - Barrel \r\n9 - Underbarrel\r\n10 - Guard\r\n11 - T" +
    "rigger action";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::WeaponManager.Properties.Resources.whitetopoblur;
            this.panel3.Controls.Add(this.buttonWeaponNameCheck);
            this.panel3.Controls.Add(this.labelAttachmentName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBoxControlChange);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textBoxMobilityChange);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBoxFirerateChange);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.textBoxRangeChange);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.textBoxDamageChange);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.textBoxAccuracyChange);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.textBoxAttachmentNumber);
            this.panel3.Controls.Add(this.textBoxAttachmentName);
            this.panel3.Location = new System.Drawing.Point(15, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(352, 278);
            this.panel3.TabIndex = 34;
            // 
            // buttonWeaponNameCheck
            // 
            this.buttonWeaponNameCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWeaponNameCheck.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWeaponNameCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonWeaponNameCheck.Location = new System.Drawing.Point(181, 35);
            this.buttonWeaponNameCheck.Name = "buttonWeaponNameCheck";
            this.buttonWeaponNameCheck.Size = new System.Drawing.Size(94, 24);
            this.buttonWeaponNameCheck.TabIndex = 33;
            this.buttonWeaponNameCheck.Text = "Name check!";
            this.buttonWeaponNameCheck.UseVisualStyleBackColor = true;
            this.buttonWeaponNameCheck.Click += new System.EventHandler(this.buttonWeaponNameCheck_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(3, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(725, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "In this interface you can edit the data or add a whole new attachment to the data" +
    "base. ";
            // 
            // AttachmentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = global::WeaponManager.Properties.Resources.blacktopo;
            this.ClientSize = new System.Drawing.Size(737, 466);
            this.ControlBox = false;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonAttachmentCancel);
            this.Controls.Add(this.buttonAttachmentUpdate);
            this.Controls.Add(this.buttonAttachmentSave);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AttachmentAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAttachmentAddClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAttachmentName)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label labelAttachmentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button buttonAttachmentSave;
        public System.Windows.Forms.Button buttonAttachmentUpdate;
        public System.Windows.Forms.Button buttonAttachmentCancel;
        private System.Windows.Forms.PictureBox pictureBoxAttachmentAddClose;
        public System.Windows.Forms.TextBox textBoxAttachmentName;
        public System.Windows.Forms.TextBox textBoxAttachmentTypeNumber;
        public System.Windows.Forms.TextBox textBoxAttachmentNumber;
        public System.Windows.Forms.TextBox textBoxAccuracyChange;
        public System.Windows.Forms.TextBox textBoxDamageChange;
        public System.Windows.Forms.TextBox textBoxRangeChange;
        public System.Windows.Forms.TextBox textBoxFirerateChange;
        public System.Windows.Forms.TextBox textBoxMobilityChange;
        public System.Windows.Forms.TextBox textBoxControlChange;
        private System.Windows.Forms.ErrorProvider errorProviderAttachmentName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonWeaponNameCheck;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
    }
}