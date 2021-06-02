using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponManager.validation
{
    public class AttachmentNameStorage
    {
        public readonly string attachmentName;

        #region Constructor
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="attachmentName"></param>
        public AttachmentNameStorage(string attachmentName) 
        {
            this.attachmentName = attachmentName;
        }
        #endregion

        #region Valid methode
        /// <summary>
        /// valid method for attachment name 
        /// </summary>
        /// <returns></returns>
        public bool isAttachemntnameValid() 
        {
            if (isAttachmentnameIsEmpty()) 
            {
                throw new AttachmentNameIsEmptyException("The attachment name can not be empty");
            }
            return true;
        }
        #endregion

        #region Empty methode
        /// <summary>
        /// method if the attachment name is empty
        /// </summary>
        /// <returns></returns>
        private bool isAttachmentnameIsEmpty()
        {
            if (string.IsNullOrEmpty(attachmentName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
