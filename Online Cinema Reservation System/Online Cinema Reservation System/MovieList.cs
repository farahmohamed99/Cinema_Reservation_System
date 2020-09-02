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



public struct entity
{
    public Label Cinema;
    public Label Movie;
    public Button Details;
};
namespace Online_Cinema_Reservation_System
{
    public partial class MovieList : Form
    {
        public static int MovieID;
        public static int CinemaID;
        List<entity> list = new List<entity>();

        public MovieList()
        {
            

            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Cinema.Cinema_ID, Cinema.Cinema_Name,Movie.Movie_ID, Movie.Movie_Name FROM [Cinema] INNER JOIN [Movie] ON Cinema.Movie_ID = Movie.Movie_ID", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            int i = 0;
            int vertical = 60;
            while (rdr.Read())
            {
                int horizontal = 20;


                Label CinemaName = new Label();
                CinemaName.AutoSize = false;
                CinemaName.TabIndex = (int)rdr["Cinema_ID"];
                CinemaName.Size = new Size(150, 50);
                CinemaName.Location = new Point(horizontal, vertical);
                CinemaName.Text = (string)rdr["Cinema_Name"];
                CinemaName.BackColor = Color.Transparent;
                CinemaName.ForeColor = Color.White;
                CinemaName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                horizontal += 160;
               
                

                Label Movie = new Label();
                Movie.AutoSize = false;
                Movie.TabIndex = (int)rdr["Movie_ID"];
                Movie.Size = new Size(150, 50);
                Movie.Location = new Point(horizontal, vertical);
                Movie.Text = (string)rdr["Movie_Name"];
                Movie.BackColor = Color.Transparent;
                Movie.ForeColor = Color.White;
                Movie.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                horizontal += 160;



                Button Details = new Button();
                Details.Size = new Size(200, 50);
                Details.Location = new Point(horizontal, vertical);
                Details.Text = "View Movie and Cinema Details";
                Details.Click += Button_Click;
                Details.TabIndex = i;
                Details.BackColor = Color.Black;
                Details.ForeColor = Color.White;
                Details.FlatAppearance.BorderSize = 0;
                Details.FlatStyle = FlatStyle.Flat;
                Details.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                i++;

                this.Controls.Add(Details);

                this.Controls.Add(CinemaName);
                this.Controls.Add(Movie);

                entity c = new entity();
                c.Cinema = CinemaName;
                c.Movie = Movie;
                c.Details = Details;

                list.Add(c);

                vertical += 60;

            
            
            }

        }
        protected void Button_Click(object sender, EventArgs e)
        {
                Button button = sender as Button;
                int idx = button.TabIndex;
                foreach (entity Entity in list)
                {
                    if (Entity.Details.TabIndex == button.TabIndex)
                    {
                        MovieID = Entity.Movie.TabIndex;
                        CinemaID = Entity.Cinema.TabIndex;
                    
                    }
                      


                   
                }

                Details form = new Details();
                this.Hide();
                form.ShowDialog();
            

            
            


           
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            UserHome form = new UserHome();
            this.Hide();
            form.ShowDialog();
        }
    }
}
