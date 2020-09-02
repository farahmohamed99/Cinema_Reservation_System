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
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand Cinema = new SqlCommand("Select Cinema_ID, Cinema_Name,City,State,Street_Number from [Cinema]", con);
            SqlDataReader Cinemardr = Cinema.ExecuteReader();
            while (Cinemardr.Read())
            {
                if ((int)Cinemardr["Cinema_ID"] == MovieList.CinemaID)
                { 
                
                    CinemaNameLabel.Text=(string)Cinemardr["Cinema_Name"];
                    CityLabel.Text = (string)Cinemardr["City"];
                    StateLabel.Text = (string)Cinemardr["State"];
                    StreetLabel.Text = ((int)Cinemardr["Street_Number"]).ToString();

                
                }
            }
            Cinemardr.Close();

            SqlCommand Movie = new SqlCommand("Select * from [Movie];", con);
            SqlDataReader Movierdr = Movie.ExecuteReader();
            
            while (Movierdr.Read())
            {
                if ((int)Movierdr["Movie_ID"] == MovieList.MovieID)
                {

                    


                    MovieNameLabel.Text = (string)Movierdr["Movie_Name"];
                    MovieAgeLabel.Text = ((int)Movierdr["Age"]).ToString();
                    TimeSpan timeSpan =(TimeSpan)Movierdr["Start_Time"];
                    StartTimeLabel.Text = timeSpan.ToString(@"hh\:mm");
                    
                    LanguageLabel.Text = (string)Movierdr["Language"];


                }
            }


















            
        }

        private void ShowSeats_Click(object sender, EventArgs e)
        {
            SeatsList form = new SeatsList();
            this.Hide();
            form.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MovieList form = new MovieList();
            this.Hide();
            form.ShowDialog();
        }

        
    }
}
