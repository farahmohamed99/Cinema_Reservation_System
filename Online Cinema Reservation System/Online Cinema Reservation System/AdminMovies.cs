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
    public partial class AdminMovies : Form
    {
        public static int Movie_ID;
        public AdminMovies()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select [Movie_Name],[Movie_ID] from [Cinema System].[dbo].[Movie]", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            int vertical = 80;
            while (rdr.Read())
            {
                int horizontal = 30;
                Label CinemaName = new Label();
                CinemaName.AutoSize = false;
                CinemaName.TabIndex = (int)rdr["Movie_ID"];
                CinemaName.Size = new Size(100, 50);
                CinemaName.Location = new Point(horizontal, vertical);
                CinemaName.Text = (string)rdr["Movie_Name"];
                CinemaName.BackColor = Color.Transparent;
                CinemaName.ForeColor = Color.White;
                CinemaName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                horizontal += 140;


                Button Details = new Button();
                Details.Size = new Size(120, 40);
                Details.TabIndex = (int)rdr["Movie_ID"];
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
                Edit.TabIndex = (int)rdr["Movie_ID"];
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
                Delete.TabIndex = (int)rdr["Movie_ID"];
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

        private void AddMovie_Click(object sender, EventArgs e)
        {
            Admin_AddMovie form = new Admin_AddMovie();
            this.Hide();
            form.ShowDialog();
        }

        private void Details_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Movie_ID = button.TabIndex;

            Admin_MovieDetails form = new Admin_MovieDetails();
            this.Hide();
            form.ShowDialog();



        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Movie_ID = button.TabIndex;

            Admin_EditMovie form = new Admin_EditMovie();
            this.Hide();
            form.ShowDialog();



        }
        private void Delete_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Movie_ID = button.TabIndex;
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();

            SqlCommand cmdCinema = new SqlCommand("select Cinema_Name from [Cinema] where Movie_ID=@movieid", con);
            cmdCinema.Parameters.AddWithValue("@movieid", AdminMovies.Movie_ID);

            String s="";
            SqlDataReader cinemardr = cmdCinema.ExecuteReader();
            while (cinemardr.Read())
            {
                s+=(string)cinemardr["Cinema_Name"]+ ", ";
            
            }
            cinemardr.Close();
            if (s!="")
            {
                MessageBox.Show("You can’t delete this movie, it’s shown in " + s);
            
            }
            else
            {
                 SqlCommand cmdMovie = new SqlCommand("Delete from [Cinema System].[dbo].[Movie] where [Movie_ID] = @movieid", con);
                 cmdMovie.Parameters.AddWithValue("@movieid", AdminMovies.Movie_ID);
                 cmdMovie.ExecuteNonQuery();
                 MessageBox.Show("Movie has been deleted successfully.");


            
            
            
            }
            con.Close();



        }


        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminHome form = new AdminHome();
            this.Hide();
            form.ShowDialog();
        }
    }
}
