using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeaponManager
{
   partial class AttachmentAdd
    {
        #region Number validation in attachments method
        /// <summary>
        /// validating the attachemnt fields that just digits can write
        /// </summary>
        /// <param name="e"></param>
        public void ValidationAttachment(KeyPressEventArgs e) 
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 45 && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Only numbers accepted in this field");
            }
        }
        #endregion

        #region Texbox number validtion
        /// <summary>
        /// validate methode call for all fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAttachmentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationAttachment(e);
        }
        private void textBoxAccuracyChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationAttachment(e);
        }
        private void textBoxDamageChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationAttachment(e);
        }
        private void textBoxRangeChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationAttachment(e);
        }
        private void textBoxFirerateChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationAttachment(e);
        }
        private void textBoxMobilityChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationAttachment(e);
        }
        private void textBoxControlChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationAttachment(e);
        }
        private void textBoxAttachmentTypeNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationAttachment(e);
        }
        #endregion
   }
}
