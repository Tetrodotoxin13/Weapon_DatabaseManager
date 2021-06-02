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
    public partial class AttachmentDatabase : Form
    {
        #region Connection
        /// <summary>
        /// connection variables
        /// </summary>
        MySqlConnection connA;
        MySqlCommand commA;
        MySqlDataReader drA;
        Connection connectionA = new Connection();
        #endregion

        #region Variables
        /// <summary>
        /// variables
        /// </summary>
        string attachmentnameStr, 
            attahcmenttypenumberStr, 
            attachmentnumberStr,
            accuracychangeStr, 
            damagechangeStr, 
            rangechangeStr, 
            fireratechagneStr, 
            mobilitychangeStr, 
            controlchangeStr;
        #endregion

        #region Load all and type database button click event
        /// <summary>
        /// load all attachment from database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAttachmentDataload_Click(object sender, EventArgs e)
        {
            LoadAllAttachmentRecords();
            labelAdd.Visible = true;
            AddNewPicture.Visible = true;
        }
        /// <summary>
        /// muzzle type load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMuzzle_Click(object sender, EventArgs e)
        {
            LoadAttachmentTypeRecord(1);
            labelAdd.Visible = false;
            AddNewPicture.Visible = false;
        }
        /// <summary>
        /// rear grip type load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSMGs_Click(object sender, EventArgs e)
        {
            LoadAttachmentTypeRecord(2);
            labelAdd.Visible = false;
            AddNewPicture.Visible = false;
        }
        /// <summary>
        /// stock type load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShotguns_Click(object sender, EventArgs e)
        {
            LoadAttachmentTypeRecord(3);
            labelAdd.Visible = false;
            AddNewPicture.Visible = false;
        }
        /// <summary>
        /// optic type load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLMGs_Click(object sender, EventArgs e)
        {
            LoadAttachmentTypeRecord(4);
            labelAdd.Visible = false;
            AddNewPicture.Visible = false;
        }
        /// <summary>
        /// laser type load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSniperRifles_Click(object sender, EventArgs e)
        {
            LoadAttachmentTypeRecord(5);
            labelAdd.Visible = false;
            AddNewPicture.Visible = false;
        }
        /// <summary>
        /// pump type load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMarksmanRifles_Click(object sender, EventArgs e)
        {
            LoadAttachmentTypeRecord(6);
            labelAdd.Visible = false;
            AddNewPicture.Visible = false;
        }
        /// <summary>
        /// magazine type load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLaunchers_Click(object sender, EventArgs e)
        {
            LoadAttachmentTypeRecord(7);
            labelAdd.Visible = false;
            AddNewPicture.Visible = false;
        }
        /// <summary>
        /// barrel type load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHandguns_Click(object sender, EventArgs e)
        {
            LoadAttachmentTypeRecord(8);
            labelAdd.Visible = false;
            AddNewPicture.Visible = false;
        }
        /// <summary>
        /// underbarrel type load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            LoadAttachmentTypeRecord(10);
            labelAdd.Visible = false;
            AddNewPicture.Visible = false;
        }
        /// <summary>
        /// guard type load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            LoadAttachmentTypeRecord(11);
            labelAdd.Visible = false;
            AddNewPicture.Visible = false;
        }
        /// <summary>
        /// trigger action type load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMelee_Click(object sender, EventArgs e)
        {
            LoadAttachmentTypeRecord(9);
            labelAdd.Visible = false;
            AddNewPicture.Visible = false;
        }
        #endregion

        #region Edit or delete click event
        /// <summary>
        /// this methode check that delete or update the selected field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewAttachmentDatabase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnNameA = dataGridViewAttachmentDatabase.Columns[e.ColumnIndex].Name;
            //update
            if (columnNameA == "PicEditA")
            {
                AttachmentAdd formAttacAdd = new AttachmentAdd(this);
                formAttacAdd.buttonAttachmentSave.Enabled = false;
                formAttacAdd.buttonAttachmentUpdate.Enabled = true;
                formAttacAdd.buttonAttachmentCancel.Enabled = false;
                formAttacAdd.textBoxAttachmentName.Enabled = true;
                formAttacAdd.textBoxAttachmentName.Text = attachmentnameStr;
                formAttacAdd.textBoxAttachmentTypeNumber.Text = attahcmenttypenumberStr;
                formAttacAdd.textBoxAttachmentNumber.Text = attachmentnumberStr;
                formAttacAdd.textBoxAccuracyChange.Text = accuracychangeStr;
                formAttacAdd.textBoxDamageChange.Text = damagechangeStr;
                formAttacAdd.textBoxRangeChange.Text = rangechangeStr;
                formAttacAdd.textBoxFirerateChange.Text = fireratechagneStr;
                formAttacAdd.textBoxMobilityChange.Text = mobilitychangeStr;
                formAttacAdd.textBoxControlChange.Text = controlchangeStr;
                formAttacAdd.ShowDialog();
            }
            //delete 
            else if (columnNameA == "PicDeleteA") 
            {
                if (MessageBox.Show("Want to delete this attachment record?", "Delete attachment record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                {
                    connA.Open();
                    commA = new MySqlCommand("DELETE FROM `attachments` WHERE attachmentname = '" + attachmentnameStr + "'", connA);
                    commA.ExecuteNonQuery();
                    connA.Close();
                    MessageBox.Show("Attachment successfull deleted!", "Delete attachment record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllAttachmentRecords();
                } 
            }
        }
        #endregion

        #region DataGridView Selection change
        /// <summary>
        /// datatgridview selection change in the table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewAttachmentDatabase_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridViewAttachmentDatabase.CurrentRow.Index;
            attachmentnameStr = dataGridViewAttachmentDatabase[1, i].Value.ToString();
            attahcmenttypenumberStr = dataGridViewAttachmentDatabase[2, i].Value.ToString();
            attachmentnumberStr = dataGridViewAttachmentDatabase[3, i].Value.ToString();
            accuracychangeStr = dataGridViewAttachmentDatabase[4, i].Value.ToString();
            damagechangeStr = dataGridViewAttachmentDatabase[5, i].Value.ToString();
            rangechangeStr = dataGridViewAttachmentDatabase[6, i].Value.ToString();
            fireratechagneStr = dataGridViewAttachmentDatabase[7, i].Value.ToString();
            mobilitychangeStr = dataGridViewAttachmentDatabase[8, i].Value.ToString();
            controlchangeStr = dataGridViewAttachmentDatabase[9, i].Value.ToString();

        }
        #endregion

        #region Onload event
        public AttachmentDatabase()
        {
            InitializeComponent();
            connA = new MySqlConnection(connectionA.DatabaseConnection());
            labelAdd.Visible = false;
            AddNewPicture.Visible = false;
        }
        #endregion

        #region Close window
        /// <summary>
        /// window close methode onclick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxCloseAttachment_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Menu menu = new Menu();
            menu.ShowDialog();
            this.Dispose();
        }
        #endregion

        #region Menu change -> Weapons database
        /// <summary>
        /// in menubar selected the weapons button and navigate to database manager page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBackWeaponDatabase_Click(object sender, EventArgs e)
        {
            this.Hide();
            WeaponDatabase formWeaponDatabase = new WeaponDatabase();
            formWeaponDatabase.ShowDialog();
            this.Show();
        }
        #endregion

        #region Add new button
        /// <summary>
        /// add new attachment into database button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewPicture_Click(object sender, EventArgs e)
        {
            AttachmentAdd attachmentadd = new AttachmentAdd(this);
            attachmentadd.textBoxAttachmentName.Enabled = true;
            attachmentadd.buttonAttachmentSave.Enabled = true;
            attachmentadd.buttonAttachmentUpdate.Enabled = false;
            attachmentadd.ShowDialog();
        }
        #endregion

        #region Load all attachment and type records methodes
        /// <summary>
        /// load all attachment from database
        /// </summary>
        public void LoadAllAttachmentRecords()
        {
            //variable to get the selected index in the datagridview 
            int i = 0;
            dataGridViewAttachmentDatabase.Rows.Clear();

            //try open the database but the connection have problem drop a message box
            try
            {
                connA.Open();
            }
            catch (Exception e) 
            {
                MessageBox.Show("I dont found the database!", "Database error", MessageBoxButtons.OK);
                return;
            }
            
            commA = new MySqlCommand("select * from attachments", connA);
            drA = commA.ExecuteReader();
            while (drA.Read()) 
            {
                i = i + 1;
                dataGridViewAttachmentDatabase.Rows.Add(i, drA[0].ToString(), drA[1].ToString(), drA[2].ToString(), drA[3].ToString(), drA[4].ToString(), drA[5].ToString(), drA[6].ToString(), drA[7].ToString(), drA[8].ToString());
            }
            drA.Close();
            connA.Close();

        }
        /// <summary>
        /// Load the database when one type selected
        /// </summary>
        /// <param name="number">the selected type number</param>
        public void LoadAttachmentTypeRecord(int number) 
        {
            //variable to get the selected index in the datagridview 
            int i = 0;
            dataGridViewAttachmentDatabase.Rows.Clear();

            //try open the database but the connection have problem drop a message box
            try
            {
                connA.Open();
            }
            catch (Exception e) 
            {
                MessageBox.Show("I dont found the database", "Database error", MessageBoxButtons.OK);
                return;
            }

            commA = new MySqlCommand("select * from attachments where attachments.attachmenttypenumber = '" + number + "' ", connA);
            drA = commA.ExecuteReader();
            while (drA.Read()) 
            {
                i = i + 1;
                dataGridViewAttachmentDatabase.Rows.Add(i, drA[0].ToString(), drA[1].ToString(), drA[2].ToString(), drA[3].ToString(), drA[4].ToString(), drA[5].ToString(), drA[6].ToString(), drA[7].ToString(), drA[8].ToString());
            }

            drA.Close();
            connA.Close();
        }
        #endregion

        #region Menu change -> User monitoring
        /// <summary>
        /// menubar button onclick navigate to the user monitotin form
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
