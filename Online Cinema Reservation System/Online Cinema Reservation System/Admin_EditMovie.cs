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
    public partial class Admin_EditMovie : Form
    {
        public Admin_EditMovie()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");

            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from [Movie] where Movie_ID =@movieid", con);
            cmd.Parameters.AddWithValue("@movieid", AdminMovies.Movie_ID);
            cmd.ExecuteNonQuery();
            SqlDataReader rdr = cmd.ExecuteReader();


            while (rdr.Read())
            {
                MovieNameBox.Text = (string)rdr["Movie_Name"];
                AgeBox.Text = ((int)rdr["Age"]).ToString();
                LanguageBox.Text = (string)rdr["Language"];
                TimeSpan timeSpan = (TimeSpan)rdr["Start_Time"];
                StartTimeBox.Text = timeSpan.ToString(@"hh\:mm");

            }
            con.Close();

        }


      

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminMovies form = new AdminMovies();
            this.Hide();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MovieNameBox.Text) && !string.IsNullOrEmpty(AgeBox.Text) &&
          !string.IsNullOrEmpty(LanguageBox.Text) && !string.IsNullOrEmpty(StartTimeBox.Text))
            {

                SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
                con.Open();

                SqlCommand cmdMovie = new SqlCommand("UpMovie", con);
                cmdMovie.CommandType = CommandType.StoredProcedure;


                cmdMovie.Parameters.AddWithValue("@movieid", AdminMovies.Movie_ID);
                cmdMovie.Parameters.AddWithValue("@moviename", MovieNameBox.Text);
                cmdMovie.Parameters.AddWithValue("@age", AgeBox.Text);

                cmdMovie.Parameters.AddWithValue("@stime", StartTimeBox.Text);
                cmdMovie.Parameters.AddWithValue("@language", LanguageBox.Text);
                cmdMovie.ExecuteNonQuery();

                MessageBox.Show("Movie has been updated successfully.");
                con.Close();
                AdminMovies form = new AdminMovies();
                form.ShowDialog();
                this.Hide();


            }
            else
                MessageBox.Show("Please fill the empty boxes.");

        }

        
       
    }
}
