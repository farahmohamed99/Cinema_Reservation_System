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
    public partial class UserReservations : Form
    {
        public UserReservations()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"Select Seat.Seat_ID, Cinema.Cinema_Name,Movie.Movie_Name,Movie.Start_Time,Movie.Language,Seat.Seat_Number,Seat.Row_Number
From Movie inner join Cinema
on Cinema.Movie_ID = Movie.Movie_ID 
inner join [Seat]
on Cinema.Cinema_ID = Seat.Cinema_ID
where Seat.User_ID = @userid", con);




            cmd.Parameters.AddWithValue("@userid", LogIn.UserID);

            SqlDataReader rdr = cmd.ExecuteReader();

            int vertical = 60;
            while (rdr.Read())
            {
                int horizontal = 15;
                Label CinemaName = new Label();
                CinemaName.AutoSize = false;
                CinemaName.Size = new Size(70, 50);
                CinemaName.Location = new Point(horizontal, vertical);
                CinemaName.Text = (string)rdr["Cinema_Name"];
                CinemaName.BackColor = Color.Transparent;
                CinemaName.ForeColor = Color.White;
                CinemaName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                horizontal += 80;

                Label MovieName = new Label();
                MovieName.AutoSize = false;
                MovieName.Size = new Size(90, 50);
                MovieName.Location = new Point(horizontal, vertical);
                MovieName.Text = (string)rdr["Movie_Name"];
                MovieName.BackColor = Color.Transparent;
                MovieName.ForeColor = Color.White;
                MovieName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                horizontal += 100;

                Label StartTime = new Label();
                StartTime.AutoSize = false;
                StartTime.Size = new Size(70, 50);
                StartTime.Location = new Point(horizontal, vertical);
                TimeSpan timeSpan = (TimeSpan)rdr["Start_Time"];
                StartTime.Text = timeSpan.ToString(@"hh\:mm");
                StartTime.BackColor = Color.Transparent;
                StartTime.ForeColor = Color.White;
                StartTime.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                horizontal += 80;

                Label Language = new Label();
                Language.AutoSize = false;
                Language.Size = new Size(70, 50);
                Language.Location = new Point(horizontal, vertical);
                Language.Text = (string)rdr["Language"];
                Language.BackColor = Color.Transparent;
                Language.ForeColor = Color.White;
                Language.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                horizontal += 80;

                Label SeatNumber = new Label();
                SeatNumber.AutoSize = false;
                SeatNumber.Size = new Size(50, 50);
                SeatNumber.Location = new Point(horizontal, vertical);
                SeatNumber.Text = ((int)rdr["Seat_Number"]).ToString();
                SeatNumber.BackColor = Color.Transparent;
                SeatNumber.ForeColor = Color.White;
                SeatNumber.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                horizontal += 60;

                Label RowNumber = new Label();
                RowNumber.AutoSize = false;
                RowNumber.Size = new Size(50, 50);
                RowNumber.Location = new Point(horizontal, vertical);
                RowNumber.Text = ((int)rdr["Row_Number"]).ToString();
                RowNumber.BackColor = Color.Transparent;
                RowNumber.ForeColor = Color.White;
                RowNumber.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                horizontal += 60;



                Button Delete = new Button();
                Delete.Size = new Size(100, 50);
                Delete.Location = new Point(horizontal, vertical - 13);
                Delete.TabIndex = (int)rdr["Seat_ID"];
                Delete.Text = "Delete";
                Delete.Click += Delete_Click;
                Delete.BackColor = Color.Black;
                Delete.ForeColor = Color.White;
                Delete.FlatAppearance.BorderSize = 0;
                Delete.FlatStyle = FlatStyle.Flat;
                Delete.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                this.Controls.Add(CinemaName);
                this.Controls.Add(MovieName);
                this.Controls.Add(StartTime);
                this.Controls.Add(Language);
                this.Controls.Add(SeatNumber);
                this.Controls.Add(RowNumber);
                this.Controls.Add(Delete);



               


                vertical += 60;










            }






        }



        protected void Delete_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand cmdSeat = new SqlCommand("update [Seat] set Status=0 , User_ID=NULL where Seat_ID=@seatid", con);

            cmdSeat.Parameters.AddWithValue("@seatid",button.TabIndex);
            MessageBox.Show("Reservation has been deleted successfully.");

            cmdSeat.ExecuteNonQuery();





        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            UserHome form = new UserHome();
            this.Hide();
            form.ShowDialog();
        }


    }
}
