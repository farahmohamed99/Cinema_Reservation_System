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
    public partial class EditCinema : Form
    {

        public EditCinema()
        {
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");

            InitializeComponent();
            con.Open();
            SqlCommand cmd = new SqlCommand(@"Select * from [Cinema] inner join [Movie]
            on Cinema.Movie_ID =Movie.Movie_ID where Cinema_ID =@cinemaid", con);
            cmd.Parameters.AddWithValue("@cinemaid", Cinemas.CinemaID);
            cmd.ExecuteNonQuery();
            SqlDataReader rdr = cmd.ExecuteReader();


            while (rdr.Read())
            {
                 CinemaNameBox.Text = (string)rdr["Cinema_Name"]; 
                 SeatsBox.Text = ((int)rdr["Number_of_Seats"]).ToString();
                 CityBox.Text = (string)rdr["City"];
                 StateBox.Text = (string)rdr["State"];
                 StreetBox.Text = ((int)rdr["Street_Number"]).ToString();
                 MoviesBox.Text = (string)rdr["Movie_Name"];

            }
            rdr.Close();

            SqlCommand MoviesList = new SqlCommand("Select Movie_Name from [Movie]", con);
            SqlDataReader Movierdr = MoviesList.ExecuteReader();

            while (Movierdr.Read())
            {
                MoviesBox.Items.Add((string)Movierdr["Movie_Name"]);

            }

            


            

        }

        private void UpdateCinema_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();

            if (!string.IsNullOrEmpty(CinemaNameBox.Text) && !string.IsNullOrEmpty(SeatsBox.Text) &&
                !string.IsNullOrEmpty(CityBox.Text) && !string.IsNullOrEmpty(StateBox.Text) && !string.IsNullOrEmpty(StreetBox.Text))
            {
                SqlCommand Editcmd = new SqlCommand(@"update [Cinema] set Cinema_Name=@cinemaname, Number_of_Seats=@seats, City=@city, State=@state, Street_Number=@street,Movie_ID=@movieid where Cinema_ID=@cinemaid", con);
                //get movie id from name
                SqlCommand MovieID = new SqlCommand("Select Movie_ID from [Movie] where Movie_Name =@moviename", con);
                MovieID.Parameters.AddWithValue("@moviename", MoviesBox.Text);

                SqlDataReader idrdr = MovieID.ExecuteReader();
                int id = 0;
                while (idrdr.Read())
                {
                    id = (int)idrdr["Movie_ID"];

                }

                idrdr.Close();

                Editcmd.Parameters.AddWithValue("@cinemaid", Cinemas.CinemaID);
                Editcmd.Parameters.AddWithValue("@cinemaname", CinemaNameBox.Text);
                Editcmd.Parameters.AddWithValue("@seats", SeatsBox.Text);
                Editcmd.Parameters.AddWithValue("@city", CityBox.Text);
                Editcmd.Parameters.AddWithValue("@state", StateBox.Text);
                Editcmd.Parameters.AddWithValue("@street", StreetBox.Text);
                Editcmd.Parameters.AddWithValue("@movieid", id);



                Editcmd.ExecuteNonQuery();

                MessageBox.Show("Cinema has been updated successfully.");

                Cinemas form = new Cinemas();
                this.Hide();
                form.ShowDialog();





            }
            else
                MessageBox.Show("Please fill the empty boxes.");

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Cinemas form = new Cinemas();
            this.Hide();
            form.ShowDialog();
        }

       
    }
}
