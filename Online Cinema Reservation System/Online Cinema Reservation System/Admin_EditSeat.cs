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
    public partial class Admin_EditSeat : Form
    {

        public Admin_EditSeat()
        {
            InitializeComponent();
            ReservedByTextBox.Items.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");


            con.Open();

            SqlCommand cmd = new SqlCommand(@"Select [Seat].Seat_ID , [Seat].Seat_Number , [Seat].Row_Number , [Seat].Status from [Seat]
where Seat.Seat_ID = @seatid", con);
            cmd.Parameters.AddWithValue("@seatid", CinemaSeats.SeatID);
            bool reserved = false;
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                SeatNumberTextBox.Text = ((int)rdr["Seat_Number"]).ToString();
                RowNumberTextBox.Text = ((int)rdr["Row_Number"]).ToString();
                if ((((bool)rdr["Status"]).ToString()) == "True")
                {
                    StatusTextBox.Text = "Reserved";
                    reserved = true;

                }
                else
                {
                    reserved = false;
                    StatusTextBox.Text = "Empty";
                    ReservedByTextBox.Hide();
                    ReservedByLabel.Hide();
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
                    ReservedByTextBox.Text = (string)userrdr["User_Name"];

                }
                userrdr.Close();



                SqlCommand users = new SqlCommand(@"select [User].User_Name,[User].User_ID
From [User]
", con);
                SqlDataReader usersrdr = users.ExecuteReader();

                while (usersrdr.Read())
                {
                    ReservedByTextBox.Items.Add((string)usersrdr["User_Name"]);
                
                
                }
            
            
            }








            con.Close();


         
        }

        private void StatusTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusTextBox.Text == "Empty")
            {
                ReservedByTextBox.Hide();
                ReservedByLabel.Hide();

            }
            else
            {
                ReservedByTextBox.Items.Clear();

                SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");


                con.Open();
                SqlCommand users = new SqlCommand(@"select [User].User_Name,[User].User_ID
From [User]
", con);
                SqlDataReader usersrdr = users.ExecuteReader();

                while (usersrdr.Read())
                {
                    ReservedByTextBox.Items.Add((string)usersrdr["User_Name"]);


                }
                con.Close();
                ReservedByLabel.Show();
                ReservedByTextBox.Show();
            
            }
        }

        private void UpdateSeat_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");

            if (!string.IsNullOrEmpty(SeatNumberTextBox.Text) && !string.IsNullOrEmpty(RowNumberTextBox.Text) && StatusTextBox.Text == "Empty")
            {

                con.Open();
                SqlCommand Editcmd = new SqlCommand(@"update [Seat] set Seat_Number=@seatnumber, Row_Number=@rownumber, Status=0, User_ID=NULL where Seat_ID=@seatid", con);
                Editcmd.Parameters.AddWithValue("@seatnumber", SeatNumberTextBox.Text);
                Editcmd.Parameters.AddWithValue("@rownumber", RowNumberTextBox.Text);
                Editcmd.Parameters.AddWithValue("@seatid", CinemaSeats.SeatID);
                Editcmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Seat has been updated successfully.");

                CinemaSeats form = new CinemaSeats();
                this.Hide();
                form.ShowDialog();
            
            }
            else if (!string.IsNullOrEmpty(SeatNumberTextBox.Text) && !string.IsNullOrEmpty(RowNumberTextBox.Text) && !string.IsNullOrEmpty(ReservedByTextBox.Text) && StatusTextBox.Text == "Reserved")
            {
                con.Open();

                int User_ID = 0;

                SqlCommand userid = new SqlCommand(@"select [User].User_ID from [User]
                  where [User].User_Name = @username
", con);
                userid.Parameters.AddWithValue("@username", ReservedByTextBox.Text);

                SqlDataReader userrdr = userid.ExecuteReader();
                while (userrdr.Read())
                {
                   User_ID = (int)userrdr["User_ID"];

                }
                userrdr.Close();

                SqlCommand Editcmd = new SqlCommand(@"update [Seat] set Seat_Number=@seatnumber, Row_Number=@rownumber, Status=1, User_ID=@userid where Seat_ID=@seatid", con);
                Editcmd.Parameters.AddWithValue("@seatnumber", SeatNumberTextBox.Text);
                Editcmd.Parameters.AddWithValue("@rownumber", RowNumberTextBox.Text);
                Editcmd.Parameters.AddWithValue("@seatid", CinemaSeats.SeatID);
                Editcmd.Parameters.AddWithValue("@userid", User_ID);


                Editcmd.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Seat has been updated successfully.");
                CinemaSeats form = new CinemaSeats();
                this.Hide();
                form.ShowDialog();

            
            }
            else
                MessageBox.Show("Please fill the empty boxes.");


        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CinemaSeats form = new CinemaSeats();
            this.Hide();
            form.ShowDialog();
        }

        private void ReservedByTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ReservedByLabel_Click(object sender, EventArgs e)
        {

        }

        private void RowNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SeatNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      
       
    }
}
