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
    public partial class Admin_AddMovie : Form
    {
        public Admin_AddMovie()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(MovieNameBox.Text) && !string.IsNullOrEmpty(AgeBox.Text) &&
               !string.IsNullOrEmpty(LanguageBox.Text) && !string.IsNullOrEmpty(StartTimeBox.Text))
            {

                SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
                con.Open();
                SqlCommand cmdMovie = new SqlCommand("AddMovie", con);
                cmdMovie.CommandType = CommandType.StoredProcedure;


                cmdMovie.Parameters.AddWithValue("@moviename", MovieNameBox.Text);
                cmdMovie.Parameters.AddWithValue("@age", AgeBox.Text);
                cmdMovie.Parameters.AddWithValue("@stime", StartTimeBox.Text);
                cmdMovie.Parameters.AddWithValue("@language", LanguageBox.Text);
                SqlDataReader reader = cmdMovie.ExecuteReader();
                MessageBox.Show("Movie has been added successfully.");
                con.Close();
                AdminMovies form = new AdminMovies();
                this.Hide();

                form.ShowDialog();


            }
            else
                MessageBox.Show("Please fill the empty boxes.");

           
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminMovies form = new AdminMovies();
            this.Hide();
            form.ShowDialog();

        }
    }
}
