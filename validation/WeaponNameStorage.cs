using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponManager
{
    public class WeaponNameStorage
    {
        public readonly string weaponName;

        #region Constructor
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="weaponName"></param>
        public WeaponNameStorage(string weaponName) 
        {
            this.weaponName = weaponName;
        }
        #endregion

        #region Valid methode
        /// <summary>
        /// valid method for weapon name 
        /// </summary>
        /// <returns></returns>
        public bool isWeaponnameValid() 
        {
            if (isTheWeaponNameEmpty()) 
            {
                throw new WeaponNamseisEmptyException("The weapon name can not be empty");
            }
            return true;
        }
        #endregion

        #region Empty methode
        /// <summary>
        /// method if the weapon name is empty
        /// </summary>
        /// <returns></returns>
        private bool isTheWeaponNameEmpty() 
        {
            if (string.IsNullOrEmpty(weaponName))
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
