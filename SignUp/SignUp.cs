using Microsoft.Data.SqlClient;
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
    public partial class SignUp : Form
    {
        DBAccess objDBAccess = new DBAccess();
        public SignUp()
        {
            InitializeComponent();
        }
        private void buttonSignUp_Click (object sender, EventArgs e)
        {
            string username = txtName.Text;
            string userEmail = txtEmail.Text;
            string userPassword = txtPass.Text;
            string userCountry = txtCountry.Text;

            if(username == "")
            {
                MessageBox.Show("Please enter your username.");

            }
           else if (userEmail == "")
            {
                MessageBox.Show("Please enter your Email.");

            }
           else if (userPassword == "")
            {
                MessageBox.Show("Please enter your Password.");

            }
           else if (userCountry == "")
            {
                MessageBox.Show("Please select a Country.");

            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("Insert into Users (Name,Email,Password,Country) values(@username, @userEmail, @userPassword, @userCountry)");
               
                insertCommand.Parameters.AddWithValue("@username", username);
                insertCommand.Parameters.AddWithValue("@userEmail", userEmail);
                insertCommand.Parameters.AddWithValue("@userPassword", userPassword);
                insertCommand.Parameters.AddWithValue("@userCountry", userCountry);

               int row = objDBAccess.executeQuery(insertCommand);
           
                if(row == 1)
                {
                    MessageBox.Show("Account Created Succesfully.");

                    this.Hide();
                    HomePage home = new HomePage();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("ERROR Occured. Try again.");

                }
            
            
            }

            
        }
    }
}
