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
    public partial class EditInfo : Form
    {
        public EditInfo()
        {
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");

            InitializeComponent();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from [User] where Mail =@mail", con);
            cmd.Parameters.AddWithValue("@mail", LogIn.UserMail);
            cmd.ExecuteNonQuery();
            SqlDataReader rdr = cmd.ExecuteReader();


            while (rdr.Read())
            {
                MailTextBox.Text = (string)rdr["Mail"];
                UserNameTextBox.Text = (string)rdr["User_Name"];
                PasswordTextBox.Text = (string)rdr["Password"];
                PhoneTextBox.Text = ((int)rdr["Phone_Number"]).ToString();
                WayTextBox.Text = (string)rdr["Way_of_Payment"];
            }

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();

            if (!string.IsNullOrEmpty(MailTextBox.Text) && !string.IsNullOrEmpty(UserNameTextBox.Text) &&
                !string.IsNullOrEmpty(PasswordTextBox.Text) && !string.IsNullOrEmpty(PhoneTextBox.Text) && !string.IsNullOrEmpty(WayTextBox.Text))
            {
                SqlCommand Editcmd = new SqlCommand(@"update [User] set Mail=@mail, User_Name=@username, Password=@password, Phone_Number=@phone, Way_of_Payment=@way where Mail=@usermail", con);
                Editcmd.Parameters.AddWithValue("@usermail", LogIn.UserMail);
                Editcmd.Parameters.AddWithValue("@mail", MailTextBox.Text);

                Editcmd.Parameters.AddWithValue("@username", UserNameTextBox.Text);
                Editcmd.Parameters.AddWithValue("@password", PasswordTextBox.Text);
                Editcmd.Parameters.AddWithValue("@phone", PhoneTextBox.Text);
                Editcmd.Parameters.AddWithValue("@way", WayTextBox.Text);


                Editcmd.ExecuteNonQuery();
                MessageBox.Show("Information has been updated successfully.");

                UserHome form = new UserHome();
                this.Hide();
                form.ShowDialog();






            }
            else
                MessageBox.Show("Please fill the empty boxes.");

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            UserHome form = new UserHome();
            this.Hide();
            form.ShowDialog();
        }
    }
}
