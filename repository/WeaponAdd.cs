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

namespace WeaponManager
{
    public partial class WeaponAdd : Form
    {
        #region
        /// <summary>
        /// variables to connection
        /// </summary>
        MySqlConnection conn;
        MySqlCommand comm;
        MySqlDataReader dr;
        Connection connection = new Connection();
        WeaponDatabase frm1;
        #endregion

        #region Variables to help convert
        /// <summary>
        /// variables to help the convertation
        /// </summary>
        int weapontypenumberInt = 0;
        int weaponnumberInt = 0;
        int accuracyInt = 0;
        int damageInt = 0;
        int rangeInt = 0;
        int firerateInt = 0;
        int mobilityInt = 0;
        int controlInt = 0;
        #endregion

        #region Onload event
        public WeaponAdd(WeaponDatabase form1)
        {
            InitializeComponent();
            conn = new MySqlConnection(connection.DatabaseConnection());
            frm1 = form1;
        }
        #endregion

        #region Close window
        /// <summary>
        /// close this form if click the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Save button to insert
        /// <summary>
        /// on button click sabe the inserted item into the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWeaponSave_Click(object sender, EventArgs e)
        {
            try
            {
                //convert string to int
                Convert();
                //make a weapon
                Weapon weapon = new Weapon(textBoxWeaponName.Text, weapontypenumberInt, weaponnumberInt, accuracyInt, damageInt, rangeInt, firerateInt, mobilityInt, controlInt);
                //check all textbox 
                if (!Check())
                {
                    //connection open and an insert sql command 
                    conn.Open();
                    comm = new MySqlCommand("INSERT INTO weapons(`weaponname`, `weapontypenumber`, `weaponnumber`, `accuracy`, `damage`, `range`, `firerate`, `mobility`, `control`) VALUES('" + weapon.getWeaponname() + "','" + weapon.getWeapontypenumber() + "','" + weapon.getWeaponnumber() + "','" + weapon.getAccuracy() + "','" + weapon.getDamage() + "','" + weapon.getRange() + "','" + weapon.getFirerate() + "','" + weapon.getMobility() + "','" + weapon.getControl() + "');", conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sucessfully saved into the database!", "Weapon Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //clear method clear the field in the add form
                    Clear();
                    frm1.LoadAllRecords();
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Warning: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Clear button to insert
        /// <summary>
        /// clear button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWeaponCancel_Click(object sender, EventArgs e)
        {
            //call the clear methode
            Clear();
        }
        #endregion

        #region Update button to insert
        /// <summary>
        /// update button click and save the modifications
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWeaponUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //convert string to int
                Convert();
                //make an updated weapon
                Weapon UpdatedWeapon = new Weapon(textBoxWeaponName.Text, weapontypenumberInt, weaponnumberInt, accuracyInt, damageInt, rangeInt, firerateInt, mobilityInt, controlInt);
                //check all textbox 
                Check();

                conn.Open();
                comm = new MySqlCommand("UPDATE `weapons` SET `weaponname` = '" + UpdatedWeapon.getWeaponname() + "', `weapontypenumber` = '" + UpdatedWeapon.getWeapontypenumber() + "', `accuracy` = '" + UpdatedWeapon.getAccuracy() + "', `damage` = '" + UpdatedWeapon.getDamage() + "', `range` = '" + UpdatedWeapon.getRange() + "', `firerate` = '" + UpdatedWeapon.getFirerate() + "', `mobility` = '" + UpdatedWeapon.getMobility() + "', `control` = '" + UpdatedWeapon.getControl() + "' WHERE `weapons`.`weaponnumber` = '" + UpdatedWeapon.getWeaponnumber() + "'", conn);
                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Sucessfully updated the database!", "Weapon Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm1.LoadAllRecords();
            }
            catch (Exception ex) 
            {
                conn.Close();
                MessageBox.Show("Warning: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Convert method
        /// <summary>
        /// convert to int from string methode
        /// </summary>
        public void Convert()
        {
            int.TryParse(textBoxWeaponTypeNumber.Text, out weapontypenumberInt);
            int.TryParse(textBoxWeaponNumber.Text, out weaponnumberInt);
            int.TryParse(textBoxAccuracy.Text, out accuracyInt);
            int.TryParse(textBoxDamage.Text, out damageInt);
            int.TryParse(textBoxRange.Text, out rangeInt);
            int.TryParse(textBoxFirerate.Text, out firerateInt);
            int.TryParse(textBoxMobility.Text, out mobilityInt);
            int.TryParse(textBoxControl.Text, out controlInt);
        }
        #endregion

        #region Check validate method 
        /// <summary>
        /// validation that no empty field 
        /// </summary>
        /// <returns></returns>
        public bool Check() 
        {
            if ((textBoxWeaponName.Text == string.Empty) ||
                    (textBoxWeaponTypeNumber.Text == string.Empty) ||
                    (textBoxWeaponNumber.Text == string.Empty) ||
                    (textBoxAccuracy.Text == string.Empty) ||
                    (textBoxDamage.Text == string.Empty) ||
                    (textBoxRange.Text == string.Empty) ||
                    (textBoxFirerate.Text == string.Empty) ||
                    (textBoxMobility.Text == string.Empty) ||
                    (textBoxControl.Text == string.Empty))
            {
                //warning if need to fill more
                MessageBox.Show("Warning: Need to fill all field!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else 
            {
                return false;
            }

        }
        #endregion

        #region Clear method
        /// <summary>
        /// clear methode clear all textbox
        /// </summary>
        public void Clear()
        {
            textBoxWeaponName.Text = string.Empty;
            textBoxWeaponTypeNumber.Clear();
            textBoxWeaponNumber.Clear();
            textBoxAccuracy.Clear();
            textBoxDamage.Clear();
            textBoxRange.Clear();
            textBoxFirerate.Clear();
            textBoxMobility.Clear();
            textBoxControl.Clear();
            buttonWeaponSave.Enabled = true;
            buttonWeaponUpdate.Enabled = false;
        }
        #endregion

        #region Name check
        /// <summary>
        /// check that not empty the name button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWeaponNameCheck_Click(object sender, EventArgs e)
        {
            errorProviderWeaponName.Clear();
            try
            {
                string weaponName = textBoxWeaponName.Text;
                WeaponNameStorage weaponNameStorage = new WeaponNameStorage(weaponName);
                if (!weaponNameStorage.isWeaponnameValid()) 
                {
                    return;
                }
            }
            catch (WeaponNamseisEmptyException ex) 
            {
                errorProviderWeaponName.SetError(textBoxWeaponName, ex.Message);
                return;
            }
        }
        #endregion
    }

}
