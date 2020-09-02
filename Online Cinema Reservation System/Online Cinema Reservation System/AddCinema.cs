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
    public partial class AddCinema : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");

        public AddCinema()
        {
            InitializeComponent();
            con.Open();


            SqlCommand MoviesList = new SqlCommand("Select Movie_Name from [Movie]", con);
            SqlDataReader rdr = MoviesList.ExecuteReader();

            while (rdr.Read())
            {
                MoviesBox.Items.Add((string)rdr["Movie_Name"]);
            
            }




        }

        private void add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CinemaNameBox.Text) && !string.IsNullOrEmpty(SeatsBox.Text) &&
                !string.IsNullOrEmpty(CityBox.Text) && !string.IsNullOrEmpty(StateBox.Text) &&
                !string.IsNullOrEmpty(StreetBox.Text))
            {
                SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
                con.Open();



                string addcmd = "INSERT INTO [Cinema](Cinema_Name,Number_of_Seats,Movie_ID, City,State,Street_Number)VALUES (@cinema, @seats,@movieid, @city, @state, @street)";

                SqlCommand add = new SqlCommand(addcmd, con);






                add.Parameters.AddWithValue("@cinema", CinemaNameBox.Text);
                add.Parameters.AddWithValue("@seats", Convert.ToInt64(SeatsBox.Text));
                add.Parameters.AddWithValue("@city", CityBox.Text);
                add.Parameters.AddWithValue("@state", StateBox.Text);
                add.Parameters.AddWithValue("@street", Convert.ToInt64(StreetBox.Text));

                MessageBox.Show("Cinema has been added successfully.");


                 SqlCommand Movie = new SqlCommand("Select Movie_ID from [Movie] where Movie_Name=@moviename", con);

                 Movie.Parameters.AddWithValue("@moviename", MoviesBox.Text);

                 SqlDataReader rdr = Movie.ExecuteReader();

                 int ID = 0;
                 while (rdr.Read())
                 {
                      ID = (int)rdr["Movie_ID"];
                 }
                 rdr.Close();


                 add.Parameters.AddWithValue("@movieid", ID);


                 add.ExecuteNonQuery();
                 con.Close();

                 Cinemas form = new Cinemas();
                 this.Hide();
                 form.ShowDialog();
                
            
            
            
            }
        }

        private void AddCinema_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Cinemas form = new Cinemas();
            this.Hide();
            form.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void MoviesBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StreetBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StateBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CityBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SeatsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CinemaNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
