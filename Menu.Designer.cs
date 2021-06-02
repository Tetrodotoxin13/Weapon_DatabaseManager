
namespace WeaponManager
{
    partial class Menu
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
            this.buttonWeaponDatabase = new System.Windows.Forms.Button();
            this.buttonAttachmentDatabase = new System.Windows.Forms.Button();
            this.buttonUserDatabase = new System.Windows.Forms.Button();
            this.buttonMenuExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonWeaponDatabase
            // 
            this.buttonWeaponDatabase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWeaponDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWeaponDatabase.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWeaponDatabase.Image = global::WeaponManager.Properties.Resources.whitetopoblur;
            this.buttonWeaponDatabase.Location = new System.Drawing.Point(10, 126);
            this.buttonWeaponDatabase.Name = "buttonWeaponDatabase";
            this.buttonWeaponDatabase.Size = new System.Drawing.Size(208, 57);
            this.buttonWeaponDatabase.TabIndex = 0;
            this.buttonWeaponDatabase.Text = "Weapons";
            this.buttonWeaponDatabase.UseVisualStyleBackColor = true;
            this.buttonWeaponDatabase.Click += new System.EventHandler(this.buttonWeaponDatabase_Click);
            // 
            // buttonAttachmentDatabase
            // 
            this.buttonAttachmentDatabase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAttachmentDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAttachmentDatabase.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAttachmentDatabase.Image = global::WeaponManager.Properties.Resources.whitetopoblur;
            this.buttonAttachmentDatabase.Location = new System.Drawing.Point(404, 126);
            this.buttonAttachmentDatabase.Name = "buttonAttachmentDatabase";
            this.buttonAttachmentDatabase.Size = new System.Drawing.Size(208, 57);
            this.buttonAttachmentDatabase.TabIndex = 1;
            this.buttonAttachmentDatabase.Text = "Attachments";
            this.buttonAttachmentDatabase.UseVisualStyleBackColor = true;
            this.buttonAttachmentDatabase.Click += new System.EventHandler(this.buttonAttachmentDatabase_Click);
            // 
            // buttonUserDatabase
            // 
            this.buttonUserDatabase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUserDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUserDatabase.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserDatabase.Image = global::WeaponManager.Properties.Resources.whitetopoblur;
            this.buttonUserDatabase.Location = new System.Drawing.Point(244, 92);
            this.buttonUserDatabase.Name = "buttonUserDatabase";
            this.buttonUserDatabase.Size = new System.Drawing.Size(134, 27);
            this.buttonUserDatabase.TabIndex = 2;
            this.buttonUserDatabase.Text = "User monitoring";
            this.buttonUserDatabase.UseVisualStyleBackColor = true;
            this.buttonUserDatabase.Click += new System.EventHandler(this.buttonUserDatabase_Click);
            // 
            // buttonMenuExit
            // 
            this.buttonMenuExit.BackColor = System.Drawing.Color.Firebrick;
            this.buttonMenuExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenuExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMenuExit.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMenuExit.Location = new System.Drawing.Point(537, 289);
            this.buttonMenuExit.Name = "buttonMenuExit";
            this.buttonMenuExit.Size = new System.Drawing.Size(75, 23);
            this.buttonMenuExit.TabIndex = 3;
            this.buttonMenuExit.Text = "Exit";
            this.buttonMenuExit.UseVisualStyleBackColor = false;
            this.buttonMenuExit.Click += new System.EventHandler(this.buttonMenuExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Image = global::WeaponManager.Properties.Resources.blacktopo;
            this.label1.Location = new System.Drawing.Point(12, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Developed by Takács Leontin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(42, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(546, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Welcome to WarGun Database Management Software ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WeaponManager.Properties.Resources.ghosticon;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(224, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 273);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Image = global::WeaponManager.Properties.Resources.blacktopo;
            this.label3.Location = new System.Drawing.Point(235, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "WarGun Manager";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(12, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Hints";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DodgerBlue;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "You logged in!";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeaponManager.Properties.Resources.blacktopo;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMenuExit);
            this.Controls.Add(this.buttonUserDatabase);
            this.Controls.Add(this.buttonAttachmentDatabase);
            this.Controls.Add(this.buttonWeaponDatabase);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWeaponDatabase;
        private System.Windows.Forms.Button buttonAttachmentDatabase;
        private System.Windows.Forms.Button buttonUserDatabase;
        private System.Windows.Forms.Button buttonMenuExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}