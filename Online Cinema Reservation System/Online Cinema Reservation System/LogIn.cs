using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Online_Cinema_Reservation_System
{
    public partial class LogIn : Form
    {
        public static int UserID;
        public static string UserMail;

        public LogIn()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            bool admin = false;
            if (MailTextBox.Text == "admin@gmail.com" && PasswordTextBox.Text == "12345")
            {
                admin = true;
                AdminHome form = new AdminHome();
                this.Hide();

                form.ShowDialog();
            }


            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();

            if (!string.IsNullOrEmpty(MailTextBox.Text) && !string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                SqlCommand cmd = new SqlCommand("select Mail, Password,User_ID from [User]", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                bool exist = false;
                while (rdr.Read())
                {
                    string Mail = (string)rdr["Mail"];
                    string Password = (string)rdr["Password"];
                    if (Mail == MailTextBox.Text && Password == PasswordTextBox.Text)
                    {
                        UserID = (int)rdr["User_ID"];
                        exist = true;
                        UserMail = MailTextBox.Text;

                        UserHome form = new UserHome();
                        this.Hide();
                        form.ShowDialog();
                        break;
                    }
                    else if (Mail == MailTextBox.Text && Password != PasswordTextBox.Text)
                    {
                        exist = true;
                        MessageBox.Show("Please Enter Correct Password.");
                        PasswordTextBox.Clear();
                    }
                }
                if(!exist&&!admin)
                    MessageBox.Show("Make Sure You Entered Correct Mail.");
                    
            
            
            
            
            
            }
            else
                MessageBox.Show("Please Fill The Empty Boxes.");






            con.Close();



        }
    }
}
