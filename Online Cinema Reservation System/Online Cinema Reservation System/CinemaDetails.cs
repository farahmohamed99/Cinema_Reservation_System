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
    public partial class CinemaDetails : Form
    {
        public CinemaDetails()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"Select * from [Cinema] inner join [Movie]
            on Cinema.Movie_ID = Movie.Movie_ID
            where Cinema_ID =@cinemaid", con);
            cmd.Parameters.AddWithValue("@cinemaid", Cinemas.CinemaID);
            cmd.ExecuteNonQuery();
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                CinemaNameLabel.Text = (string)rdr["Cinema_Name"];
                SeatsLabel.Text = ((int)rdr["Number_of_Seats"]).ToString();
                City.Text = (string)rdr["City"];
                State.Text = (string)rdr["State"];
                Street.Text = ((int)rdr["Street_Number"]).ToString();
                MovieofCinema.Text = (string)rdr["Movie_Name"];





            
            
            
            
            
            
            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Cinemas form = new Cinemas();
            this.Hide();
            form.ShowDialog();
        }

       
    }
}
