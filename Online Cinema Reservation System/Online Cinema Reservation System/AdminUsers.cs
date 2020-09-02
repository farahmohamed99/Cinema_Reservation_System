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
    public partial class AdminUsers : Form
    {
        public static int UserID;
        public AdminUsers()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select User_Name,User_ID from [User]", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            int vertical = 80;
            while (rdr.Read())
            {
                int horizontal = 30;
                Label UserName = new Label();
                UserName.AutoSize = false;
                UserName.Size = new Size(100, 50);
                UserName.Location = new Point(horizontal, vertical);
                UserName.Text = (string)rdr["User_Name"];
                UserName.BackColor = Color.Transparent;
                UserName.ForeColor = Color.White;
                UserName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                horizontal += 140;


                Button Details = new Button();
                Details.Size = new Size(120, 40);
                Details.TabIndex = (int)rdr["User_ID"];
                Details.Location = new Point(horizontal, vertical - 13);
                Details.Text = "Details";
                Details.BackColor = Color.Black;
                Details.ForeColor = Color.White;
                Details.FlatAppearance.BorderSize = 0;
                Details.FlatStyle = FlatStyle.Flat;
                Details.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Details.Click += Details_Click;
                horizontal += 140;

                Button Edit = new Button();
                Edit.Size = new Size(120, 40);
                Edit.TabIndex = (int)rdr["User_ID"];
                Edit.Location = new Point(horizontal, vertical - 13);
                Edit.Text = "Edit";
                Edit.BackColor = Color.Black;
                Edit.ForeColor = Color.White;
                Edit.FlatAppearance.BorderSize = 0;
                Edit.FlatStyle = FlatStyle.Flat;
                Edit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Edit.Click += Edit_Click;
                horizontal += 140;


                Button Delete = new Button();
                Delete.Size = new Size(120, 40);
                Delete.Location = new Point(horizontal, vertical - 13);
                Delete.TabIndex = (int)rdr["User_ID"];
                Delete.Text = "Delete";
                Delete.Click += Delete_Click;
                Delete.BackColor = Color.Black;
                Delete.ForeColor = Color.White;
                Delete.FlatAppearance.BorderSize = 0;
                Delete.FlatStyle = FlatStyle.Flat;
                Delete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                horizontal += 140;


                this.Controls.Add(UserName);
                this.Controls.Add(Details);
                this.Controls.Add(Edit);
                this.Controls.Add(Delete);


                vertical += 50;










            }


        }

        

        private void Details_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            UserID= button.TabIndex;

            UserDetails form = new UserDetails();
            this.Hide();
            form.ShowDialog();


        }
        private void Delete_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            UserID = button.TabIndex;

            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();

            SqlCommand User = new SqlCommand("Delete from [User] where User_ID =@userid", con);
            User.Parameters.AddWithValue("@userid", UserID);

            SqlCommand Seats = new SqlCommand("Update [Seat] set User_ID=NULL, Status= 0 where User_ID=@userid", con);
            Seats.Parameters.AddWithValue("@userid", UserID);


            Seats.ExecuteNonQuery();

            User.ExecuteNonQuery();

            MessageBox.Show("User has been deleted successfully.");


        }
        private void Edit_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            UserID = button.TabIndex;

            Admin_EditUser form = new Admin_EditUser();
            this.Hide();
            form.ShowDialog();


        }

        private void NewUserButton_Click_1(object sender, EventArgs e)
        {
            Admin_NewUser form = new Admin_NewUser();
            this.Hide();
            form.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminHome form = new AdminHome();
            this.Hide();
            form.ShowDialog();
        }

       
    }
}
