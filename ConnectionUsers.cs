using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponManager
{
    class ConnectionUsers
    {
        public string dbconnectionUser() 
        {
            string connU = "server=localhost;user id=root;password=;database=registration";
            return connU;
        } 
    }
}
