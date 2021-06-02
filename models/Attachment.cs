using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponManager.models
{
    partial class Attachment
    {
        #region variables
        /// <summary>
        /// variables for the attachment class
        /// </summary>
        private string attachmentname;
        private int attachmenttypenumber;
        private int attachmentnumber;
        private int accuracychange;
        private int damagechange;
        private int rangechange;
        private int fireratechange;
        private int mobilitychange;
        private int controlchange;
        #endregion

        #region construktor
        /// <summary>
        /// construktor 
        /// </summary>
        /// <param name="attachmentname"></param>
        /// <param name="attachmenttypenumber"></param>
        /// <param name="attachmentnumber"></param>
        /// <param name="accuracychange"></param>
        /// <param name="damagechange"></param>
        /// <param name="rangechange"></param>
        /// <param name="fireratechange"></param>
        /// <param name="mobilitychange"></param>
        /// <param name="controlchange"></param>
        public Attachment(string attachmentname,
            int attachmenttypenumber,
            int attachmentnumber,
            int accuracychange,
            int damagechange,
            int rangechange,
            int fireratechange,
            int mobilitychange,
            int controlchange)
        {
            this.attachmentname = attachmentname;
            this.attachmenttypenumber = attachmenttypenumber;
            this.attachmentnumber = attachmentnumber;
            this.accuracychange = accuracychange;
            this.damagechange = damagechange;
            this.rangechange = rangechange;
            this.fireratechange = fireratechange;
            this.mobilitychange = mobilitychange;
            this.controlchange = controlchange;
        }
        #endregion

        #region set methodes
        /// <summary>
        /// set attachment name method
        /// </summary>
        /// <param name="attachmentname">the attachment name</param>
        public void setAttachmentName(string attachmentname)
        {
            this.attachmentname = attachmentname;
        }
        /// <summary>
        /// set the attachment type number
        /// </summary>
        /// <param name="attachmenttypenumber">the attachment type number</param>
        public void setAttachmnetTypeNumber(int attachmenttypenumber)
        {
            this.attachmenttypenumber = attachmenttypenumber;
        }
        /// <summary>
        /// set the attachment number 
        /// </summary>
        /// <param name="attachmentnumber">the attachment number</param>
        public void setAttachmentNumber(int attachmentnumber)
        {
            this.attachmentnumber = attachmentnumber;
        }
        /// <summary>
        /// set the attachment accuracy change number
        /// </summary>
        /// <param name="accuracychange">the attachment accuracy change number</param>
        public void setAccuracyChange(int accuracychange)
        {
            this.accuracychange = accuracychange;
        }
        /// <summary>
        /// set the attachment damage change number
        /// </summary>
        /// <param name="damagechange">the attachment damage change number</param>
        public void setDamageChange(int damagechange)
        {
            this.damagechange = damagechange;
        }
        /// <summary>
        /// set the attachment range change number
        /// </summary>
        /// <param name="rangechange">the attachment range change number</param>
        public void setRangeChange(int rangechange)
        {
            this.rangechange = rangechange;
        }
        /// <summary>
        /// aset the attachment fire rate change number
        /// </summary>
        /// <param name="fireratechange">the attachment fire rate change number</param>
        public void setFirerateChange(int fireratechange)
        {
            this.fireratechange = fireratechange;
        }
        /// <summary>
        /// set the attachment mobility change number
        /// </summary>
        /// <param name="mobilitychange">the attachment mobility change number</param>
        public void setMobilityChange(int mobilitychange)
        {
            this.mobilitychange = mobilitychange;
        }
        /// <summary>
        /// set the attachment control change number
        /// </summary>
        /// <param name="controlchange">the attachment control change number</param>
        public void setControlChange(int controlchange)
        {
            this.controlchange = controlchange;
        }
        #endregion

        #region get methodes
        /// <summary>
        /// get the attachment name methode
        /// </summary>
        /// <returns></returns>
        public string getAttachmentName()
        {
            return attachmentname;
        }
        /// <summary>
        /// get the attachment type number methode
        /// </summary>
        /// <returns></returns>
        public int getAttachmentTypeNumber()
        {
            return attachmenttypenumber;
        }
        /// <summary>
        /// get the attachment number methode
        /// </summary>
        /// <returns></returns>
        public int getAttacmentNumber()
        {
            return attachmentnumber;
        }
        /// <summary>
        /// get the attachment accuracy change number
        /// </summary>
        /// <returns></returns>
        public int getAccuracyChange()
        {
            return accuracychange;
        }
        /// <summary>
        /// get the attachment damage change number
        /// </summary>
        /// <returns></returns>
        public int getDamageChange()
        {
            return damagechange;
        }
        /// <summary>
        /// get the attachment range change number
        /// </summary>
        /// <returns></returns>
        public int getRangeChange()
        {
            return rangechange;
        }
        /// <summary>
        /// get the attachment fire rate change number
        /// </summary>
        /// <returns></returns>
        public int getFirerateChange()
        {
            return fireratechange;
        }
        /// <summary>
        /// get the attachment mobility change number
        /// </summary>
        /// <returns></returns>
        public int getMobilityChange()
        {
            return mobilitychange;
        }
        /// <summary>
        /// get the attachment control change number
        /// </summary>
        /// <returns></returns>
        public int getControlChange()
        {
            return controlchange;
        }
        #endregion

        #region toString methode
        /// <summary>
        /// to sting methode
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "ide meg irni kell szoveget";
        }
        #endregion
    }
}
