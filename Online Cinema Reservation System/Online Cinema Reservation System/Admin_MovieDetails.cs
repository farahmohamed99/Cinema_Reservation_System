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
    public partial class Admin_MovieDetails : Form
    {
        public Admin_MovieDetails()
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
                MovieNameLabel.Text = (string)rdr["Movie_Name"];
                AgeLabel.Text = ((int)rdr["Age"]).ToString();
                LanguageLabel.Text = (string)rdr["Language"];
                TimeSpan timeSpan = (TimeSpan)rdr["Start_Time"];
                StartTimeLabel.Text = timeSpan.ToString(@"hh\:mm");

            }
            con.Close();


        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminMovies form = new AdminMovies();
            this.Hide();
            form.ShowDialog();
        }

      
    }
}
