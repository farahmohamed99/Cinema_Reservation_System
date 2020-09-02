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
    public partial class Admin_EditUser : Form
    {
        public Admin_EditUser()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from [User] where User_ID =@userid", con);
            cmd.Parameters.AddWithValue("@userid", AdminUsers.UserID);
            cmd.ExecuteNonQuery();
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                UserNameTextBox.Text = (string)rdr["User_Name"];
                MailTextBox.Text = (string)rdr["Mail"];
                PasswordTextBox.Text = (string)rdr["Password"];
                WayTextBox.Text = (string)rdr["Way_of_Payment"];
                PhoneTextBox.Text = ((int)rdr["Phone_Number"]).ToString();









            }


            

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();

            if (!string.IsNullOrEmpty(UserNameTextBox.Text) && !string.IsNullOrEmpty(MailTextBox.Text) &&
                !string.IsNullOrEmpty(PasswordTextBox.Text) && !string.IsNullOrEmpty(WayTextBox.Text) && !string.IsNullOrEmpty(PhoneTextBox.Text))
            {
                SqlCommand Editcmd = new SqlCommand(@"update [User] set User_Name=@username, Mail=@mail, Password=@password, Way_of_Payment=@payment, Phone_Number=@phone where User_ID=@userid", con);
                Editcmd.Parameters.AddWithValue("@userid", AdminUsers.UserID);
                Editcmd.Parameters.AddWithValue("@username", UserNameTextBox.Text);
                Editcmd.Parameters.AddWithValue("@mail", MailTextBox.Text);
                Editcmd.Parameters.AddWithValue("@password", PasswordTextBox.Text);
                Editcmd.Parameters.AddWithValue("@payment", WayTextBox.Text);
                Editcmd.Parameters.AddWithValue("@phone", PhoneTextBox.Text);
                


                Editcmd.ExecuteNonQuery();
                MessageBox.Show("User has been updated successfully.");
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
