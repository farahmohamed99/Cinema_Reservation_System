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
    public partial class Admin_NewUser : Form
    {
        public Admin_NewUser()
        {
            InitializeComponent();
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();

            bool Reg, UsedUserName;

            if (!string.IsNullOrEmpty(UserNameTextBox.Text) && !string.IsNullOrEmpty(MailTextBox.Text)
                && !string.IsNullOrEmpty(PasswordTextBox.Text) && !string.IsNullOrEmpty(PhoneTextBox.Text)
                && !string.IsNullOrEmpty(WayTextBox.Text))
            {
                SqlCommand cmd = new SqlCommand("select User_Name, Mail from [User]", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                Reg = false;
                UsedUserName = false;

                while (rdr.Read())
                {

                    // read data	
                    string UserName = (string)rdr["User_Name"];
                    if (UserName == UserNameTextBox.Text)
                    {
                        UsedUserName = true;
                        MessageBox.Show("This user name already used, Please write another one.");
                        UserNameTextBox.Clear();
                        break;
                    }
                    string Mail = (string)rdr["Mail"];
                    if (Mail != MailTextBox.Text)
                        Reg = false;
                    else
                    {
                        Reg = true;
                       
                        MessageBox.Show("This mail already exist in the database.");
                        MailTextBox.Clear();
                        break;

                    }

                }

                rdr.Close();
                if (!Reg && !UsedUserName)
                {
                    string insertcmd = "INSERT INTO [User]VALUES (@UserName, @Mail, @Password, @way, @Phone)";

                    SqlCommand insert = new SqlCommand(insertcmd, con);

                    insert.Parameters.AddWithValue("@UserName", UserNameTextBox.Text);
                    insert.Parameters.AddWithValue("@Mail", MailTextBox.Text);
                    insert.Parameters.AddWithValue("@Password", PasswordTextBox.Text);
                    insert.Parameters.AddWithValue("@way", WayTextBox.Text);
                    insert.Parameters.AddWithValue("@Phone", PhoneTextBox.Text);




                   
                 

                    insert.ExecuteNonQuery();

                    MessageBox.Show("User has been added successfully.");

                 





                }




            }
            else
                MessageBox.Show("Please fill the empty boxes.");

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminUsers form = new AdminUsers();
            this.Hide();
            form.ShowDialog();
        }
    }
}
