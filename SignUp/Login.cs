using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUp
{
    public partial class Login : Form
    {
        public static string id, name, email, password, country;
        DBAccess objDBAccess = new DBAccess();
        DataTable dt = new DataTable();

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Email = txtEmailLogin.Text;
            string Password = txtPassLogin.Text;
            if (Email.Length == 0)
            {
                MessageBox.Show("Please Enter Your Email.");
            }
            else if (Password.Length == 0)
            {
               
                MessageBox.Show("Please Enter Your Password.");
            }
            else
            {
                string query = "Select * from Users Where Email = '" + Email + "' AND Password = '" + Password + "'";
                objDBAccess.readDatathroughAdapter(query, dt);


                if (dt.Rows.Count > 0)
                {
                    id = dt.Rows[0]["ID"].ToString();
                    name = dt.Rows[0]["Name"].ToString();
                    email = dt.Rows[0]["Email"].ToString();
                    password = dt.Rows[0]["Password"].ToString();
                    country = dt.Rows[0]["Country"].ToString();





                    MessageBox.Show("You have logged in successfully.");

                    objDBAccess.closeConn();

                    this.Hide();
                    HomePage home = new HomePage();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("WRONG Credentials, Please Provide Correct Credentials.");

                }
            }
        }

        private void labelCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }
    }

}
