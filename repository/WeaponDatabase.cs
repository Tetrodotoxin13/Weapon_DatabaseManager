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
using WeaponManager.repository;

namespace WeaponManager
{
    public partial class WeaponDatabase : Form
    {
        #region Connecting
        /// <summary>
        /// variables for connetion
        /// </summary>
        MySqlConnection conn;
        MySqlCommand comm;
        MySqlDataReader dr;
        Connection connection = new Connection();
        #endregion

        #region Variables
        /// <summary>
        /// helping variables
        /// </summary>
        string weaponnameStr, weapontypenumberStr, weaponnumberStr, accuracyStr, damageStr, rangeStr, firerateStr, mobilityStr, controlStr;
        #endregion

        #region Load all and type database button click events
        /// <summary>
        /// load all data from database on click and load the selected type data from database on click methodes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWeaponDataload_Click(object sender, EventArgs e)
        {
            LoadAllRecords();
            labelAdd.Visible = true;
            AddNewPicture.Visible = true;
        }
        /// <summary>
        /// assault rifle type 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAssaultRifles_Click(object sender, EventArgs e)
        {
            LoadWeaponTypeRecords(1);
            labelAdd.Visible = false;
            AddNewPicture.Visible = false;
        }
        /// <summary>
        /// smg type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSMGs_Click(object sender, EventArgs e)
        {
            LoadWeaponTypeRecords(2);
            labelAdd.Visible = false;
            AddNewPicture.Visible = false;
        }
        /// <summary>
        /// shotgun type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShotguns_Click(object sender, EventArgs e)
        {
            LoadWeaponTypeRecords(3);
            labelAdd.Visible = false;
            AddNewPicture.Visible = false;

        }
        /// <summary>
        /// lmg type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLMGs_Click(object sender, EventArgs e)
        {
            LoadWeaponTypeRecords(5);
            labelAdd.Visible = false;
            AddNewPicture.Visible = false;

        }
        /// <summary>
        /// sniper rifle type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSniperRifles_Click(object sender, EventArgs e)
        {
            LoadWeaponTypeRecords(4);
            labelAdd.Visible = false;
            AddNewPicture.Visible = false;
        }
        /// <summary>
        /// marksman rifle type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMarksmanRifles_Click(object sender, EventArgs e)
        {
            LoadWeaponTypeRecords(6);
            labelAdd.Visible = false;
            AddNewPicture.Visible = false;
        }
        /// <summary>
        /// launcher type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLaunchers_Click(object sender, EventArgs e)
        {
            LoadWeaponTypeRecords(9);
            labelAdd.Visible = false;
            AddNewPicture.Visible = false;
        }
        /// <summary>
        /// handgun type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHandguns_Click(object sender, EventArgs e)
        {
            LoadWeaponTypeRecords(7);
            labelAdd.Visible = false;
            AddNewPicture.Visible = false;
        }
        /// <summary>
        /// melee type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMelee_Click(object sender, EventArgs e)
        {
            LoadWeaponTypeRecords(8);
            labelAdd.Visible = false;
            AddNewPicture.Visible = false;
        }
        #endregion

        #region Menu change -> Attachments page
        /// <summary>
        /// button click on attachment database button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAttachments_Click(object sender, EventArgs e)
        {
            this.Hide();
            AttachmentDatabase formAttachmentDatabase = new AttachmentDatabase();
            formAttachmentDatabase.ShowDialog();
            this.Show();
        }
        #endregion

        #region Onload event
        public WeaponDatabase()
        {
            InitializeComponent();
            conn = new MySqlConnection(connection.DatabaseConnection());
            labelAdd.Visible = false;
            AddNewPicture.Visible = false;
        }
        #endregion

        #region Edit or delete click event
        /// <summary>
        /// Edit or delete picture click methode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewWeapons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dataGridViewWeapons.Columns[e.ColumnIndex].Name;
            //update click
            if (columnName == "picEdit")
            {
                WeaponAdd form2 = new WeaponAdd(this);
                form2.buttonWeaponSave.Enabled = false;
                form2.buttonWeaponCancel.Enabled = false;
                form2.buttonWeaponUpdate.Enabled = true;
                form2.textBoxWeaponName.Enabled = true;

                form2.textBoxWeaponName.Text = weaponnameStr;
                form2.textBoxWeaponTypeNumber.Text = weapontypenumberStr;
                form2.textBoxWeaponNumber.Text = weaponnumberStr;
                form2.textBoxAccuracy.Text = accuracyStr;
                form2.textBoxDamage.Text = damageStr;
                form2.textBoxRange.Text = rangeStr;
                form2.textBoxFirerate.Text = firerateStr;
                form2.textBoxMobility.Text = mobilityStr;
                form2.textBoxControl.Text = controlStr;
                form2.ShowDialog();
            }
            //delete click
            else if (columnName == "picDelete")
            {
                if (MessageBox.Show("Are you sure that delete this weapon?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //connection open and delete sql command
                    conn.Open();
                    comm = new MySqlCommand("DELETE FROM `weapons` WHERE weaponname = '" + weaponnameStr + "'", conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record has been successfully deleten from weapons.", "Deleted records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllRecords();
                }
            }
        }
        #endregion
 
        #region DataGridView selection change
        /// <summary>
        /// datagridview selection when changed and get the values into a string variable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewWeapons_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridViewWeapons.CurrentRow.Index;
            weaponnameStr = dataGridViewWeapons[1, i].Value.ToString();
            weapontypenumberStr = dataGridViewWeapons[2, i].Value.ToString();
            weaponnumberStr = dataGridViewWeapons[3, i].Value.ToString();
            accuracyStr = dataGridViewWeapons[4, i].Value.ToString();
            damageStr = dataGridViewWeapons[5, i].Value.ToString();
            rangeStr = dataGridViewWeapons[6, i].Value.ToString();
            firerateStr = dataGridViewWeapons[7, i].Value.ToString();
            mobilityStr = dataGridViewWeapons[8, i].Value.ToString();
            controlStr = dataGridViewWeapons[9, i].Value.ToString();
        }
        #endregion

        #region Add button
        /// <summary>
        /// clicked on the add new picture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewPicture_Click(object sender, EventArgs e)
        {
            WeaponAdd weaponadd = new WeaponAdd(this);
            weaponadd.textBoxWeaponName.Enabled = true;
            weaponadd.buttonWeaponSave.Enabled = true;
            weaponadd.buttonWeaponUpdate.Enabled = false;
            weaponadd.ShowDialog();
        }
        #endregion

        #region Close window
        /// <summary>
        /// close the weapons page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Menu menu = new Menu();
            menu.ShowDialog();
            this.Dispose();
        }
        #endregion

        #region Load all record and type records methodes
        /// <summary>
        /// load all weapons form database
        /// </summary>
        public void LoadAllRecords()
        {
            //variable to get the selected index in the datagridview 
            int i = 0;
            dataGridViewWeapons.Rows.Clear();

            //try open the database but the connection have problem drop a message box
            try
            {
                conn.Open();
            }
            catch (Exception e) 
            {
                MessageBox.Show("I dont found the database", "Database error",MessageBoxButtons.OK);
                return;
            }

            //Sql string to get all weapon
            comm = new MySqlCommand("select * from weapons", conn);
            dr = comm.ExecuteReader();
            while (dr.Read()) 
            {
                i += 1;
                dataGridViewWeapons.Rows.Add(i, dr[0].ToString(),dr[1].ToString(),dr[2].ToString(),dr[3].ToString(),dr[4].ToString(),dr[5].ToString(),dr[6].ToString(),dr[7].ToString(),dr[8].ToString());    
            }

            //close datareader and connection
            dr.Close();
            conn.Close();
        }
        /// <summary>
        /// Load the database when one type selected
        /// </summary>
        /// <param name="number">the selected type number</param>
        public void LoadWeaponTypeRecords(int number)
        {
            //variable to get the selected index in the datagridview 
            int i = 0;
            dataGridViewWeapons.Rows.Clear();
            
            //try open the database but the connection have problem drop a message box
            try
            {
                conn.Open();
            }
            catch (Exception e) 
            {
                MessageBox.Show("I dont found the database", "Database error", MessageBoxButtons.OK);
                return;
            }

            //Sql string to get the selected type
            comm = new MySqlCommand("select * from weapons where weapons.weapontypenumber = '" + number + "' ", conn);
            dr = comm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridViewWeapons.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
            }

            //close datareader and connection
            dr.Close();
            conn.Close();
        }
        #endregion

        #region Menu change -> User monitoring page
        /// <summary>
        /// go to the user monitoring page button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDatabase formUserDatabase = new UserDatabase();
            formUserDatabase.ShowDialog();
            this.Show();
        }
        #endregion
    }
}
