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
    public partial class CinemaSeats : Form
    {
        public static int SeatID;
        public CinemaSeats()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand Seats = new SqlCommand("Select Seat_ID,Seat_Number, Row_Number from [Seat] where Cinema_ID=@cinemaid;", con);
            Seats.Parameters.AddWithValue("cinemaid",Admin_Seats.CinemaID);
            SqlDataReader Seatsrdr = Seats.ExecuteReader();
            int vertical = 80;
            while (Seatsrdr.Read())
            {
                int horizontal = 30;
                Label SeatNumber = new Label();
                SeatNumber.AutoSize = false;
                SeatNumber.TabIndex = (int)Seatsrdr["Seat_ID"];
                SeatNumber.Size = new Size(60, 40);
                SeatNumber.Location = new Point(horizontal, vertical);
                SeatNumber.Text = ((int)Seatsrdr["Seat_Number"]).ToString();
                SeatNumber.BackColor = Color.Transparent;
                SeatNumber.ForeColor = Color.White;
                SeatNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                horizontal += 70;


                Label RowNumber = new Label();
                RowNumber.AutoSize = false;
                RowNumber.TabIndex = (int)Seatsrdr["Seat_ID"];
                RowNumber.Size = new Size(60, 40);
                RowNumber.Location = new Point(horizontal, vertical);
                RowNumber.Text = ((int)Seatsrdr["Row_Number"]).ToString();
                RowNumber.BackColor = Color.Transparent;
                RowNumber.ForeColor = Color.White;
                RowNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                horizontal += 90;


                Button Details = new Button();
                Details.Size = new Size(120, 40);
                Details.TabIndex = (int)Seatsrdr["Seat_ID"];
                Details.Location = new Point(horizontal, vertical - 13);
                Details.Text = "Details";
                Details.Click += Details_Click;
                Details.BackColor = Color.Black;
                Details.ForeColor = Color.White;
                Details.FlatAppearance.BorderSize = 0;
                Details.FlatStyle = FlatStyle.Flat;
                Details.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                horizontal += 130;



                Button Edit = new Button();
                Edit.Size = new Size(120, 40);
                Edit.TabIndex = (int)Seatsrdr["Seat_ID"];
                Edit.Location = new Point(horizontal, vertical - 13);
                Edit.Text = "Edit";
                Edit.Click += Edit_Click;
                Edit.BackColor = Color.Black;
                Edit.ForeColor = Color.White;
                Edit.FlatAppearance.BorderSize = 0;
                Edit.FlatStyle = FlatStyle.Flat;
                Edit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                horizontal += 130;

                Button Delete = new Button();
                Delete.Size = new Size(120, 40);
                Delete.TabIndex = (int)Seatsrdr["Seat_ID"];
                Delete.Location = new Point(horizontal, vertical - 13);
                Delete.Text = "Delete";
                Delete.Click += Delete_Click;
                Delete.BackColor = Color.Black;
                Delete.ForeColor = Color.White;
                Delete.FlatAppearance.BorderSize = 0;
                Delete.FlatStyle = FlatStyle.Flat;
                Delete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                horizontal += 130;

                this.Controls.Add(RowNumber);
                this.Controls.Add(SeatNumber);
                this.Controls.Add(Details);
                this.Controls.Add(Edit);
                this.Controls.Add(Delete);

                vertical += 60;





            }
            con.Close();

        }

        protected void Details_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            SeatID = button.TabIndex;
           

            Admin_Seats_Details form = new Admin_Seats_Details();
            this.Hide();
            form.ShowDialog();




        }

        protected void Edit_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            SeatID = button.TabIndex;


            Admin_EditSeat form = new Admin_EditSeat();
            this.Hide();
            form.ShowDialog();




        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            Button button = sender as Button; 
            SeatID = button.TabIndex;

          SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
          con.Open();
          SqlCommand DeleteSeat = new SqlCommand("delSeat",con);
          DeleteSeat.CommandType = CommandType.StoredProcedure;


          DeleteSeat.Parameters.AddWithValue("@seatid", SeatID);
          DeleteSeat.ExecuteNonQuery();
          con.Close();
          MessageBox.Show("Seat has been deleted successfuly.");




        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Admin_Seats form = new Admin_Seats();
            this.Hide();
            form.ShowDialog();
        }

        private void AddSeatButton_Click(object sender, EventArgs e)
        {
            //make sure that count is less 
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand cmdc = new SqlCommand("numOfseat", con);
            cmdc.CommandType = CommandType.StoredProcedure;
            cmdc.Parameters.AddWithValue("@cinemaid", Admin_Seats.CinemaID);
            int CurrentNumber = (int)cmdc.ExecuteScalar();

            SqlCommand cmd2 = new SqlCommand("numOfseatInCinema", con);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@cinemaid", Admin_Seats.CinemaID);
            int AllowedNumber = (int)cmd2.ExecuteScalar();

            if (CurrentNumber == AllowedNumber)
            { MessageBox.Show("Sorry, Cinema is Full You can’t add new seat. "); }

            else
            {
                Admin_AddSeat form = new Admin_AddSeat();
                this.Hide();
                form.ShowDialog();
            }

            con.Close();
        }
    }
}
