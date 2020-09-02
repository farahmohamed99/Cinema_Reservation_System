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
    public partial class Admin_AddSeat : Form
    {
        public Admin_AddSeat()
        {
            InitializeComponent();
        }

        private void AddSeat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SeatNumberTextBox.Text) && !string.IsNullOrEmpty(RowNumberTextBox.Text))
            {
                SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
                con.Open();
                SqlCommand cmd = new SqlCommand("AddSeat", con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@cinemaid", Admin_Seats.CinemaID);
                cmd.Parameters.AddWithValue("@seatnum", SeatNumberTextBox.Text);
                cmd.Parameters.AddWithValue("@rownum", RowNumberTextBox.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Seat has been added successfully.");


            }
            else
                MessageBox.Show("Please fill the empty boxes");


        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CinemaSeats form = new CinemaSeats();
            this.Hide();
            form.ShowDialog();
        }

      
    }
}
