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
    public partial class Admin_Seats_Details : Form
    {
        public Admin_Seats_Details()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();


            SqlCommand cmd = new SqlCommand(@"Select Seat.Seat_ID, Seat.Seat_Number,Seat.Row_Number, Seat.Status,Cinema.Cinema_Name
From [Cinema] inner join [Seat]
on Cinema.Cinema_ID = Seat.Cinema_ID 
where Seat.Seat_ID = @seatid", con);



            bool reserved = false;
           cmd.Parameters.AddWithValue("@seatid", CinemaSeats.SeatID);
           SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                SeatIDLabel.Text = ((int)rdr["Seat_ID"]).ToString();
                SeatNumberLabel.Text = ((int)rdr["Seat_Number"]).ToString();
                RowNumberLabel.Text = ((int)rdr["Row_Number"]).ToString();
                CinemaNameLabel.Text = (string)rdr["Cinema_Name"];
                if ((((bool)rdr["Status"]).ToString()) == "True")
                {
                    reserved = true;
                    StatusLabel.Text = "Reserved";
                    

                }
                else
                {
                    StatusLabel.Text = "Empty";
                    ReservedLabel.Hide();
                    UserNameLabel.Hide();

                }

                



              



            }
            rdr.Close();
            if (reserved)
            {

                SqlCommand username = new SqlCommand(@"select [User].User_Name
                    from [User] inner join [Seat]
                    on [User].User_ID = Seat.User_ID
                    where Seat.Seat_ID=@seatid 
", con);
                username.Parameters.AddWithValue("@seatid", CinemaSeats.SeatID);

                SqlDataReader userrdr = username.ExecuteReader();
                while (userrdr.Read())
                {
                    UserNameLabel.Text = (string)userrdr["User_Name"];

                }
            
            
            }

            con.Close();


        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CinemaSeats form = new CinemaSeats();
            this.Hide();
            form.ShowDialog();
        }
    }
}
