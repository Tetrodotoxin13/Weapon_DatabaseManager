using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeaponManager.repository;

namespace WeaponManager
{
    public partial class Menu : Form
    {
        #region Onload
        public Menu()
        {
            InitializeComponent();
        }
        #endregion

        #region Weapons
        /// <summary>
        /// weapon database open if click on this button methode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWeaponDatabase_Click(object sender, EventArgs e)
        {
            this.Hide();
            WeaponDatabase formWeaponDatabase = new WeaponDatabase();
            formWeaponDatabase.ShowDialog();
            this.Show();
        }
        #endregion

        #region Attachments
        /// <summary>
        /// attachment database open if click on this button methode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAttachmentDatabase_Click(object sender, EventArgs e)
        {
            this.Hide();
            AttachmentDatabase formAttachmentDatabase = new AttachmentDatabase();
            formAttachmentDatabase.ShowDialog();
            this.Show();
        }
        #endregion

        #region Close menu
        /// <summary>
        /// close button methode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMenuExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
        #endregion

        #region User monitoring
        /// <summary>
        /// user monitorin databse open if click this button methode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUserDatabase_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDatabase formUserDatabase = new UserDatabase();
            formUserDatabase.ShowDialog();
            this.Show();
        }
        #endregion

        #region Hints 
        /// <summary>
        /// hints form open 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hint hint = new Hint();
            hint.ShowDialog();
            this.Show();
        }
        #endregion
    }
}
