using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponManager.models
{
    class User
    {
        #region variables
        /// <summary>
        /// variables
        /// </summary>
        private string username;
        private string emailaddress;
        private string password;
        #endregion 

        #region construktor
        /// <summary>
        ///  the class construktor
        /// </summary>
        /// <param name="username"></param>
        /// <param name="emailaddress"></param>
        /// <param name="password"></param>
        public User(string username, string emailaddress, string password)
        {
            this.username = username;
            this.emailaddress = emailaddress;
            this.password = password;
        }
        #endregion

        #region set methodes
        /// <summary>
        /// set username methode
        /// </summary>
        /// <param name="username"> the username </param>
        public void setUsername(string username)
        {
            this.username = username;
        }
        /// <summary>
        /// set email address methode
        /// </summary>
        /// <param name="emailaddress"> email address </param>
        public void setEmail(string emailaddress)
        {
            this.emailaddress = emailaddress;
        }
        /// <summary>
        /// set password methode
        /// </summary>
        /// <param name="password"> password </param>
        public void setPassword(string password)
        {
            this.password = password;
        }
        #endregion

        #region get methodes
        /// <summary>
        /// get username methode
        /// </summary>
        /// <returns></returns>
        public string getUsername()
        {
            return username;
        }
        /// <summary>
        /// get email address methode
        /// </summary>
        /// <returns></returns>
        public string getEmail()
        {
            return emailaddress;
        }
        /// <summary>
        /// get password methode
        /// </summary>
        /// <returns></returns>
        public string getPassword() 
        {
            return password;
        }
        #endregion

    }
}
