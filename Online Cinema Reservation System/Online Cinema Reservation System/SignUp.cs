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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            


            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();

            bool Reg,UsedUserName;
           
            if (!string.IsNullOrEmpty(UserNameTextBox.Text) && !string.IsNullOrEmpty(MailTextBox.Text)
                && !string.IsNullOrEmpty(PasswordTextBox.Text) && !string.IsNullOrEmpty(PhoneTextBox.Text)
                && !string.IsNullOrEmpty(WayTextBox.Text))
            {
                SqlCommand cmd = new SqlCommand("select User_Name, Mail from [User]", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                 Reg = false;
                 UsedUserName=false;

                while (rdr.Read())
                {

                    
                    string UserName = (string)rdr["User_Name"];
                    if (UserName == UserNameTextBox.Text)
                    {
                        UsedUserName =true;
                        MessageBox.Show("This User Name already used, Please write another one.");
                        UserNameTextBox.Clear();
                        break;
                    }
                    string Mail = (string)rdr["Mail"];
                    if (Mail != MailTextBox.Text)
                        Reg = false;
                    else
                    {
                        Reg = true;
                        MessageBox.Show("You already have an account! You can log in.");
                        Home form = new Home();
                        this.Hide();

                        form.ShowDialog();
                        break;

                    }
                    
                }

                rdr.Close();
                if (!Reg && !UsedUserName)
                {
                    string insertcmd = "INSERT INTO [User]VALUES (@UserName, @Mail, @Password, @way, @Phone)";

                    SqlCommand insert = new SqlCommand(insertcmd, con);
                    insert.Parameters.Add("@UserName", SqlDbType.NVarChar,50);
                    insert.Parameters.Add("@Mail", SqlDbType.NVarChar, 50);
                    insert.Parameters.Add("@Password", SqlDbType.NVarChar, 50);
                    insert.Parameters.Add("@way", SqlDbType.NVarChar, 50);
                    insert.Parameters.Add("@phone", SqlDbType.Int);

                    insert.Parameters["@UserName"].Value = UserNameTextBox.Text;
                    insert.Parameters["@Mail"].Value = MailTextBox.Text;
                    insert.Parameters["@Password"].Value = PasswordTextBox.Text;
                    insert.Parameters["@way"].Value = WayTextBox.Text;
                    insert.Parameters["@phone"].Value = PhoneTextBox.Text;

                    insert.ExecuteNonQuery();

                    MessageBox.Show("Registration Completed, Now you have an account and can log in.");

                    this.Hide();
                    Home form = new Home();
                    form.ShowDialog();

                    

                
                
                }




            }
            else
                MessageBox.Show("Please Fill the Empty Boxes");




            con.Close();


        }

       

        
    }
}
