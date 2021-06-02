using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeaponManager
{
    public partial class Login : Form
    {
        #region Variables and connection
        MySqlConnection connectU = new MySqlConnection("server=localhost;user id=root;password=;database=registration");
        int i;
        #endregion

        #region Onload event
        public Login()
        {
            InitializeComponent();
            labelSomethingWrong.Visible = false;
        }
        #endregion

        #region Button click to login
        /// <summary>
        /// button click on the login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            i = 0;

            //connection open
            try
            {
                connectU.Open();
            }
            catch 
            {
                MessageBox.Show("I dont found the database", "Database error", MessageBoxButtons.OK);
                return;
            }

            //connection ok and command 
            MySqlCommand commU = connectU.CreateCommand();
            commU.CommandType = CommandType.Text;
            commU.CommandText = "select * from admins where username='" + textBoxUsername.Text + "' and password='" + textBoxPassword.Text + "'";
            commU.ExecuteNonQuery();
            DataTable dataT = new DataTable();
            MySqlDataAdapter dataA = new MySqlDataAdapter(commU);
            dataA.Fill(dataT);
            i = Convert.ToInt32(dataT.Rows.Count.ToString());
            
            // check the database 
            if (i == 0)
            {
                labelSomethingWrong.Visible = true;
                labelSomethingWrong.Text = "Entered invalid Username or Password";
            }
            else 
            {
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }

            connectU.Close();
        }
        #endregion

        #region Close button
        /// <summary>
        /// clost button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
        #endregion

        #region trick
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
        #endregion
    }
}
