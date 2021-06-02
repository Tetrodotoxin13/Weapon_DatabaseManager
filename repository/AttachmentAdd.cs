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
using WeaponManager.models;
using WeaponManager.validation;

namespace WeaponManager
{
    public partial class AttachmentAdd : Form
    {
        #region Connection
        MySqlConnection connA;
        MySqlCommand commA;
        MySqlDataReader drA;
        Connection connectionA = new Connection();
        AttachmentDatabase formAttachData;
        #endregion

        #region Varibles to help convert
        /// <summary>
        /// this variables help to convert the string into number
        /// </summary>
        int attachmenttypenumberInt = 0;
        int attachmentnumberInt = 0;
        int accuracychangeInt = 0;
        int damagechangeInt = 0;
        int rangechangeInt = 0;
        int fireratechangeInt = 0;
        int mobilitychangeInt = 0;
        int controlchangeInt = 0;
        #endregion

        #region Onload event
        public AttachmentAdd(AttachmentDatabase attachmentdatabase)
        {
            InitializeComponent();
            connA = new MySqlConnection(connectionA.DatabaseConnection());
            formAttachData = attachmentdatabase;
        }
        #endregion

        #region Clear method
        /// <summary>
        /// this methode clear all textbox in the add form 
        /// </summary>
        public void Clear()
        {
            textBoxAttachmentName.Text = string.Empty;
            textBoxAttachmentTypeNumber.Clear();
            textBoxAttachmentNumber.Clear();
            textBoxAccuracyChange.Clear();
            textBoxDamageChange.Clear();
            textBoxRangeChange.Clear();
            textBoxFirerateChange.Clear();
            textBoxMobilityChange.Clear();
            textBoxControlChange.Clear();
            buttonAttachmentSave.Enabled = true;
            buttonAttachmentUpdate.Enabled = false;
        }
        #endregion

        #region Save button to insert
        /// <summary>
        /// clicked on the save button methode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAttachmentSave_Click(object sender, EventArgs e)
        {
            try
            {
                //convert string to int
                ConvertAttachment();
                //make an attachment from class
                Attachment attachment = new Attachment(textBoxAttachmentName.Text, attachmenttypenumberInt, attachmentnumberInt, accuracychangeInt, damagechangeInt, rangechangeInt, fireratechangeInt, mobilitychangeInt, controlchangeInt);
                //check all textbox and insert into the database
                if (!CheckAttachment()) 
                {
                    connA.Open();
                    commA = new MySqlCommand("INSERT INTO attachments(`attachmentname`, `attachmenttypenumber`, `attachmentnumber`, `accuracychange`, `damagechange`, `rangechange`, `fireratechange`, `mobilitychange`, `controlchange`) VALUES('" + attachment.getAttachmentName() + "','" + attachment.getAttachmentTypeNumber() + "','" + attachment.getAttacmentNumber() + "','" + attachment.getAccuracyChange() + "','" + attachment.getDamageChange() + "','" + attachment.getRangeChange() + "','" + attachment.getFirerateChange() + "','" + attachment.getMobilityChange() + "','" + attachment.getControlChange() + "');", connA);
                    commA.ExecuteNonQuery();
                    connA.Close();
                    MessageBox.Show("Sucessfully saved into the database!", "Weapon Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    formAttachData.LoadAllAttachmentRecords();
                }
            }
            catch (Exception ex)
            {
                connA.Close();
                MessageBox.Show("Warning: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Close window
        /// <summary>
        /// button click to close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxAttachmentAddClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Clear button to insert
        /// <summary>
        /// button click on the clear button to get empty all textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAttachmentCancel_Click(object sender, EventArgs e)
        {
            //methode call
            Clear();
        }
        #endregion

        #region Update method to insert
        /// <summary>
        /// button click to update the selected data field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAttachmentUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //convert string to int
                ConvertAttachment();
                //make an attachment
                Attachment updateAttachment = new Attachment(textBoxAttachmentName.Text, attachmenttypenumberInt, attachmentnumberInt, accuracychangeInt, damagechangeInt, rangechangeInt, fireratechangeInt, mobilitychangeInt, controlchangeInt);
                //check all textbox 
                CheckAttachment();
                if (!CheckAttachment()) 
                {
                    connA.Open();
                    commA = new MySqlCommand("UPDATE `attachments` SET `attachmentname` = '" + updateAttachment.getAttachmentName() + "', `attachmenttypenumber` = '" + updateAttachment.getAttachmentTypeNumber() + "', `accuracychange` = '" + updateAttachment.getAccuracyChange() + "', `damagechange` = '" + updateAttachment.getDamageChange() + "', `rangechange` = '" + updateAttachment.getRangeChange() + "', `fireratechange` = '" + updateAttachment.getFirerateChange() + "', `mobilitychange` = '" + updateAttachment.getMobilityChange() + "', `controlchange` = '" + updateAttachment.getControlChange() + "' WHERE `attachments`.`attachmentnumber` = '" + updateAttachment.getAttacmentNumber() + "'", connA);
                    commA.ExecuteNonQuery();
                    connA.Close();
                    MessageBox.Show("Sucessfully saved into the database!", "Weapon Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formAttachData.LoadAllAttachmentRecords();
                }
            }
            catch (Exception ex) 
            {
                connA.Close();
                MessageBox.Show("Warning!" + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion

        #region Convert method
        /// <summary>
        /// convert the int type of variables into string
        /// </summary>
        public void ConvertAttachment() 
        {
            int.TryParse(textBoxAttachmentTypeNumber.Text, out attachmenttypenumberInt);
            int.TryParse(textBoxAttachmentNumber.Text, out attachmentnumberInt);
            int.TryParse(textBoxAccuracyChange.Text, out accuracychangeInt);
            int.TryParse(textBoxDamageChange.Text, out damagechangeInt);
            int.TryParse(textBoxRangeChange.Text, out rangechangeInt);
            int.TryParse(textBoxFirerateChange.Text, out fireratechangeInt);
            int.TryParse(textBoxMobilityChange.Text, out mobilitychangeInt);
            int.TryParse(textBoxControlChange.Text, out controlchangeInt);
        }
        #endregion

        #region Check validate method
        /// <summary>
        /// validate when have empty textbox field
        /// </summary>
        /// <returns></returns>
        public bool CheckAttachment() 
        {
            if ((textBoxAttachmentName.Text == string.Empty) ||
                   (textBoxAttachmentTypeNumber.Text == string.Empty) ||
                   (textBoxAttachmentNumber.Text == string.Empty) ||
                   (textBoxAccuracyChange.Text == string.Empty) ||
                   (textBoxDamageChange.Text == string.Empty) ||
                   (textBoxRangeChange.Text == string.Empty) ||
                   (textBoxFirerateChange.Text == string.Empty) ||
                   (textBoxMobilityChange.Text == string.Empty) ||
                   (textBoxControlChange.Text == string.Empty))
            {
                MessageBox.Show("Fill all field to save the new attachment!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else 
            {
                return false;
            }
        }
        #endregion

        #region Name check
        /// <summary>
        /// name validation that the name is not empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWeaponNameCheck_Click(object sender, EventArgs e)
        {
            errorProviderAttachmentName.Clear();
            try
            {
                string attachmenName = textBoxAttachmentName.Text;
                AttachmentNameStorage attachmentnameStorage = new AttachmentNameStorage(attachmenName);
                if (!attachmentnameStorage.isAttachemntnameValid()) 
                {
                    return;
                }
            }
            catch (AttachmentNameIsEmptyException ex) 
            {
                errorProviderAttachmentName.SetError(textBoxAttachmentName, ex.Message);
                return;
            }

        }
        #endregion

    }
}
