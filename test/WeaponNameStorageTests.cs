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
    public class WeaponNameStorageTests
    {
        #region Good test 
        /// <summary>
        /// test if the weapon name storage is good and not empty
        /// </summary>
        [TestMethod()]
        public void isWeaponnameValidTestWeaponNameCorrect()
        {
            try
            {
                WeaponNameStorage wns = new WeaponNameStorage("AK-47");
                if (wns.isWeaponnameValid()) 
                {
                    return;
                }
            }
            catch (Exception) 
            {
                Assert.Fail("The weapon name is valid but unfortunatelly something wrong");
            }
        }

        /// <summary>
        /// test if the weapon name storage is good and not empty
        /// </summary>
        [TestMethod()]
        public void isWeaponnameValidTestWeaponNameCorrect2()
        {
            try
            {
                WeaponNameStorage wns = new WeaponNameStorage("Grau");
                if (wns.isWeaponnameValid())
                {
                    return;
                }
            }
            catch (Exception)
            {
                Assert.Fail("The weapon name is valid but unfortunatelly something wrong");
            }
        }


        /// <summary>
        /// test if the weapon name storage is good and not empty
        /// </summary>
        [TestMethod()]
        public void isWeaponnameValidTestWeaponNameCorrect3()
        {
            try
            {
                WeaponNameStorage wns = new WeaponNameStorage("toz-8");
                if (wns.isWeaponnameValid())
                {
                    return;
                }
            }
            catch (Exception)
            {
                Assert.Fail("The weapon name is valid but unfortunatelly something wrong");
            }
        }
        #endregion

        #region Bad test
        /// <summary>
        /// test if the weapon name storage is empty
        /// </summary>
        [TestMethod()]
        public void isWeaponnameValidTestWeaponNameIsEmpty() 
        {
            try
            {
                WeaponNameStorage wns = new WeaponNameStorage("");
                if (wns.isWeaponnameValid())
                {
                    Assert.Fail("Accept the empty Weapon name");
                }
            }
            catch (WeaponManager.WeaponNamseisEmptyException) 
            {
                return;
            }
        }
        #endregion

    }
}