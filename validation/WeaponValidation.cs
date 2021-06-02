using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeaponManager
{
    partial class WeaponAdd
    {
        #region Number validation method
        /// <summary>
        /// validaton just numbers accept into the textbox
        /// </summary>
        /// <param name="e"></param>
        public void Validation(KeyPressEventArgs e) 
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Only numbers accepted in this field");
            }
        }
        #endregion

        #region Texbox number validation
        /// <summary>
        /// call the validation methode for all fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxWeaponNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation(e);
        }
        private void textBoxAccuracy_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation(e);
        }
        private void textBoxDamage_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation(e);
        }
        private void textBoxRange_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation(e);
        }
        private void textBoxFirerate_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation(e);
        }
        private void textBoxMobility_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation(e);
        }
        private void textBoxControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation(e);
        }
        private void textBoxWeaponTypeNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation(e);
        }
        #endregion

    }
}
