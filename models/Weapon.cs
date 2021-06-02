using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponManager.models
{
    partial class Weapon
    {
        #region variables
        /// <summary>
        /// class variables
        /// </summary>
        private string weaponname;
        private int weapontypenumber;
        private int weaponnumber;
        private int accuracy;
        private int damage;
        private int range;
        private int firerate;
        private int mobility;
        private int control;
        #endregion 

        #region construktor
        /// <summary>
        /// The class Construktor
        /// </summary>
        /// <param name="weaponname"></param>
        /// <param name="weapontypenumber"></param>
        /// <param name="weaponnumber"></param>
        /// <param name="accuracy"></param>
        /// <param name="damage"></param>
        /// <param name="range"></param>
        /// <param name="firerate"></param>
        /// <param name="mobility"></param>
        /// <param name="control"></param>
        public Weapon(string weaponname, int weapontypenumber, int weaponnumber, int accuracy, int damage, int range, int firerate, int mobility, int control)
        {
            this.weaponname = weaponname;
            this.weapontypenumber = weapontypenumber;
            this.weaponnumber = weaponnumber;
            this.accuracy = accuracy;
            this.damage = damage;
            this.range = range;
            this.firerate = firerate;
            this.mobility = mobility;
            this.control = control;
        }
        #endregion

        #region set methodes
        
        /// <summary>
        /// set the weapon name methode
        /// </summary>
        /// <param name="weaponname">weapon name</param>
        public void setWeaponname(string weaponname)
        {
            this.weaponname = weaponname;
        }
        /// <summary>
        /// set the wepon type number methode
        /// </summary>
        /// <param name="weapontypenumber">the weapon type number</param>
        public void setWeaponTypeNumber(int weapontypenumber)
        {
            this.weapontypenumber = weapontypenumber;
        }
        /// <summary>
        /// set the weapon number methode
        /// </summary>
        /// <param name="weaponnumber"> weapon id number</param>
        public void setWeaponnumber(int weaponnumber)
        {
            this.weaponnumber = weaponnumber;
        }
        /// <summary>
        /// set the weapon accuracy number methode 
        /// </summary>
        /// <param name="accuracy">the weapon accuracy</param>
        public void setAccuracy(int accuracy)
        {
            this.accuracy = accuracy;
        }
        /// <summary>
        /// set the weapon damage number methode
        /// </summary>
        /// <param name="damage"> the weapon damage</param>
        public void setDamage(int damage)
        {
            this.damage = damage;
        }
        /// <summary>
        /// set the weapon range number methode
        /// </summary>
        /// <param name="range">the weapon range</param>
        public void setRange(int range)
        {
            this.range = range;
        }
        /// <summary>
        /// set the weapon fire rate number methode
        /// </summary>
        /// <param name="firerate"> the weapon fire rate</param>
        public void setFirerate(int firerate)
        {
            this.firerate = firerate;
        }
        /// <summary>
        /// set the weapon mobility number methode
        /// </summary>
        /// <param name="mobility">the weapon mobility</param>
        public void setMobility(int mobility)
        {
            this.mobility = mobility;
        }
        /// <summary>
        /// set the weapon control number methode
        /// </summary>
        /// <param name="control"> the weapon control</param>
        public void setControl(int control)
        {
            this.control = control;
        }
        #endregion

        #region get methodes
        
        /// <summary>
        /// get weapon name methode
        /// </summary>
        /// <returns></returns>
        public string getWeaponname()
        {
            return weaponname;
        }
        /// <summary>
        /// get weapon type number methode 
        /// </summary>
        /// <returns></returns>
        public int getWeapontypenumber()
        {
            return weapontypenumber;
        }
        /// <summary>
        /// get the weapon number methode (AKA id) 
        /// </summary>
        /// <returns></returns>
        public int getWeaponnumber()
        {
            return weaponnumber;
        }
        /// <summary>
        /// get the weapon accuracy methode
        /// </summary>
        /// <returns></returns>
        public int getAccuracy()
        {
            return accuracy;
        }
        /// <summary>
        /// get the weapon damage methode
        /// </summary>
        /// <returns></returns>
        public int getDamage()
        {
            return damage;
        }
        /// <summary>
        /// get the weapon range methode
        /// </summary>
        /// <returns></returns>
        public int getRange()
        {
            return range;
        }
        /// <summary>
        /// get the weapon fire rate methode
        /// </summary>
        /// <returns></returns>
        public int getFirerate()
        {
            return firerate;
        }
        /// <summary>
        /// get the weapon mobility methode
        /// </summary>
        /// <returns></returns>
        public int getMobility()
        {
            return mobility;
        }
        /// <summary>
        /// get the weapon control methode
        /// </summary>
        /// <returns></returns>
        public int getControl()
        {
            return control;
        }
        #endregion

        #region toString methode
        /// <summary>
        /// to string methode
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "A(z) " + weapontypenumber + "típusú fegyver -> " + weaponnumber + ". A " + weaponname + " nevű fegyver adatai: " + "pontosság: " + accuracy + ", sebzés: " + damage + ", lőtáv: " + range + ", tűzgyorsaság: " + firerate + ", mobilitás: " + mobility + ", kontrollálhatóság: " + control;

        }
        #endregion
    }
}
