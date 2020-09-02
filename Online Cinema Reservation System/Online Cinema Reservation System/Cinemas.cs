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
    public partial class Cinemas : Form
    {

        public static int CinemaID;
        public Cinemas()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Cinema_Name,Cinema_ID from [Cinema]", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            int vertical = 80;
            while (rdr.Read())
            {
                int horizontal = 30;
                Label CinemaName = new Label();
                CinemaName.AutoSize = false;
                CinemaName.TabIndex = (int)rdr["Cinema_ID"];
                CinemaName.Size = new Size(100, 50);
                CinemaName.Location = new Point(horizontal, vertical);
                CinemaName.Text = (string)rdr["Cinema_Name"];
                CinemaName.BackColor = Color.Transparent;
                CinemaName.ForeColor = Color.White;
                CinemaName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                horizontal += 140;


                Button Details = new Button();
                Details.Size = new Size(120, 40);
                Details.TabIndex = (int)rdr["Cinema_ID"];
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
                Edit.TabIndex = (int)rdr["Cinema_ID"];
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
                Delete.TabIndex = (int)rdr["Cinema_ID"]; 
                Delete.Text = "Delete";
                Delete.Click += Delete_Click;
                Delete.BackColor = Color.Black;
                Delete.ForeColor = Color.White;
                Delete.FlatAppearance.BorderSize = 0;
                Delete.FlatStyle = FlatStyle.Flat;
                Delete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                horizontal += 140;




                this.Controls.Add(CinemaName);
                this.Controls.Add(Details);
                this.Controls.Add(Edit);
                this.Controls.Add(Delete);


                vertical += 50;




            
            
            
            
            
            
            }

            rdr.Close();
            con.Close();



        }


        protected void Details_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            CinemaID = button.TabIndex;

            CinemaDetails form = new CinemaDetails();
            this.Hide();
            form.ShowDialog();
          

        
        
        }


        protected void Delete_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            CinemaID = button.TabIndex;
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand cmdSeat = new SqlCommand("Delete from [Seat] where Cinema_ID =@cinemaid", con);
            SqlCommand cmdCinema = new SqlCommand("Delete from [Cinema] where Cinema_ID =@cinemaid", con);

            cmdSeat.Parameters.AddWithValue("@cinemaid", Cinemas.CinemaID);
            cmdCinema.Parameters.AddWithValue("@cinemaid", Cinemas.CinemaID);

            cmdSeat.ExecuteNonQuery();
            cmdCinema.ExecuteNonQuery();

            MessageBox.Show("Cinema has been deleted successfully");
           

           



        }

        protected void Edit_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            CinemaID = button.TabIndex;

            EditCinema form = new EditCinema();
            
            this.Hide();
            form.ShowDialog();




        }

        private void AddCinema_Click(object sender, EventArgs e)
        {
            AddCinema form = new AddCinema();
            this.Hide();
            form.ShowDialog();
            
        }

        private void Cinemas_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminHome form = new AdminHome();
            this.Hide();
            form.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }







    }
}
