using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WeaponManager.repository
{
    public partial class UserDatabase : Form
    {
        #region Variables
        /// <summary>
        /// variables
        /// </summary>
        string useridString, usernameString, emailString, passwordString;
        #endregion

        #region Connection
        /// <summary>
        /// connection varibales
        /// </summary>
        MySqlConnection connU;
        MySqlCommand commU;
        MySqlDataReader drU;
        ConnectionUsers connectionUsers = new ConnectionUsers();
        #endregion

        #region Onload event
        public UserDatabase()
        {
            InitializeComponent();
            connU = new MySqlConnection(connectionUsers.dbconnectionUser());
        }
        #endregion

        #region Close button
        /// <summary>
        /// close this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxCloseUser_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Menu menu = new Menu();
            menu.ShowDialog();
            this.Dispose();
        }
        #endregion

        #region Load all records from database methode
        /// <summary>
        /// load all record from database methode
        /// </summary>
        public void LoadAllRecord() 
        {
            int i = 0;
            dataGridViewUsers.Rows.Clear();
            //try to connect
            try
            {
                connU.Open();
            }
            catch (Exception e)
            {
                //if not found the database message
                MessageBox.Show("I dont found the database", "Database error", MessageBoxButtons.OK);
                return;
            }
            //sql string command
            commU = new MySqlCommand("select * from users order by id, username, email, password", connU);
            drU = commU.ExecuteReader();
            //read the data from the database
            while (drU.Read()) 
            {
                i = i + 1;
                dataGridViewUsers.Rows.Add(i, drU[0].ToString(), drU[1].ToString(), drU[2].ToString(), drU[3].ToString());
            }
            drU.Close();
            connU.Close();
        }
        #endregion

        #region Load all records Button click methode
        /// <summary>
        /// load all recotd button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUserDataload_Click(object sender, EventArgs e)
        {
            //load methode call
            LoadAllRecord();
        }
        #endregion

        #region Menu change -> Weapon Database page
        /// <summary>
        /// open the weapon database page on click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWeaponsDatabase_Click(object sender, EventArgs e)
        {
            this.Hide();
            WeaponDatabase formWeaponDatabase = new WeaponDatabase();
            formWeaponDatabase.ShowDialog();
            this.Show();
        }
        #endregion

        #region Menu change -> Attachment Databse page
        /// <summary>
        /// open the attachment databse page on click event
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

        #region Datagridview selection change
        /// <summary>
        /// one row select in the database table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridViewUsers.CurrentRow.Index;
            useridString = dataGridViewUsers[1, i].Value.ToString();
            usernameString = dataGridViewUsers[2, i].Value.ToString();
            emailString = dataGridViewUsers[3, i].Value.ToString();
            passwordString = dataGridViewUsers[4, i].Value.ToString();
        }
        #endregion

        #region Delete click event
        /// <summary>
        /// delete one person or user from the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string collumnName = dataGridViewUsers.Columns[e.ColumnIndex].Name;
            //click on the ban button
            if (collumnName == "picDelete") 
            {
                if(MessageBox.Show("Ban this record?", "Ban User", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connU.Open();
                    commU = new MySqlCommand("delete from users where username like '" + usernameString + "'", connU);
                    commU.ExecuteNonQuery();
                    connU.Close();
                    MessageBox.Show("User successfull banned from webpage!", "Ban users", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllRecord();
                }
            }
        }
        #endregion

    }
}
