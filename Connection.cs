using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponManager
{
    class Connection
    {
        public string DatabaseConnection()
        {
            string connection = "server=localhost;user id=root;password=;database=warzonedatabase";
            return connection;
        }
    }
}
