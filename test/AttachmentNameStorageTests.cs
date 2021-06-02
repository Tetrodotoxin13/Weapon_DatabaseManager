using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeaponManager.validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponManager.validation.Tests
{
    [TestClass()]
    public class AttachmentNameStorageTests
    {
        #region Good test
        /// <summary>
        /// Test if the storage is not empty
        /// </summary>
        [TestMethod()]
        public void AttachmentNameStorageTestAttachmentNameisCorrect()
        {
            try
            {
                AttachmentNameStorage ats = new AttachmentNameStorage("Stippled Griptape");
                if (ats.isAttachemntnameValid())
                {
                    return;
                }
            }
            catch (Exception)
            {
                Assert.Fail("The attachment name is valid but unfortunatelly something wrong");
            }
        }

        /// <summary>
        /// Test if the storage is not empty
        /// </summary>
        [TestMethod()]
        public void AttachmentNameStorageTestAttachmentNameisCorrect2()
        {
            try
            {
                AttachmentNameStorage ats = new AttachmentNameStorage("CombatGriptape");
                if (ats.isAttachemntnameValid())
                {
                    return;
                }
            }
            catch (Exception)
            {
                Assert.Fail("The attachment name is valid but unfortunatelly something wrong");
            }
        }

        /// <summary>
        /// Test if the storage is not empty
        /// </summary>
        [TestMethod()]
        public void AttachmentNameStorageTestAttachmentNameisCorrect3()
        {
            try
            {
                AttachmentNameStorage ats = new AttachmentNameStorage("combatgriptape");
                if (ats.isAttachemntnameValid())
                {
                    return;
                }
            }
            catch (Exception)
            {
                Assert.Fail("The attachment name is valid but unfortunatelly something wrong");
            }
        }

        /// <summary>
        /// Test if the storage is not empty
        /// </summary>
        [TestMethod()]
        public void AttachmentNameStorageTestAttachmentNameisCorrect4()
        {
            try
            {
                AttachmentNameStorage ats = new AttachmentNameStorage("combat griptape");
                if (ats.isAttachemntnameValid())
                {
                    return;
                }
            }
            catch (Exception)
            {
                Assert.Fail("The attachment name is valid but unfortunatelly something wrong");
            }
        }
        #endregion

        #region Bad test
        /// <summary>
        /// test if the storage is empty
        /// </summary>
        [TestMethod()]
        public void AttachmentNameStorageTestAttachmentNameisEmpty()
        {
            try
            {
                AttachmentNameStorage ats = new AttachmentNameStorage("");
                if (ats.isAttachemntnameValid())
                {
                    Assert.Fail("Accept the empty attachment name");
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        #endregion

    }
}