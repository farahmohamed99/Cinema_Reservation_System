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
    public partial class UserDetails : Form
    {
        public UserDetails()
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
                UserIDLabel.Text = ((int)rdr["User_ID"]).ToString();
                UserNameLabel.Text = (string)rdr["User_Name"];
                MailLabel.Text = (string)rdr["Mail"];
                PasswordLabel.Text = (string)rdr["Password"];
                PaymentLabel.Text = (string)rdr["Way_of_Payment"];
                PhoneLabel.Text = ((int)rdr["Phone_Number"]).ToString();









            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminUsers form = new AdminUsers();
            this.Hide();
            form.ShowDialog();
        }
    }
}
