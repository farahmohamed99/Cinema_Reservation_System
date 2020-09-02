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


public struct Seat
{
    public Label SeatNo;
    public Label RowNo;
    public Button Reserve;
};
namespace Online_Cinema_Reservation_System
{
    public partial class SeatsList : Form
    {

        public SeatsList()
        {
            InitializeComponent();
            List<Seat> list = new List<Seat>();
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from [Seat]", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            int vertical = 60;

            while (rdr.Read())
            {
                int horizontal = 100;

                if ((int)rdr["Cinema_ID"] == MovieList.CinemaID && (bool)rdr["Status"] == false)
                {
                    Label SeatNumber = new Label();
                    SeatNumber.AutoSize = false;
                    SeatNumber.Size = new Size(140, 50);
                    SeatNumber.Location = new Point(horizontal, vertical);
                    SeatNumber.Text = ((int)rdr["Seat_Number"]).ToString();
                    SeatNumber.BackColor = Color.Transparent;
                    SeatNumber.ForeColor = Color.White;
                    SeatNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    horizontal += 160;

                    Label RowNumber = new Label();
                    RowNumber.AutoSize = false;
                    RowNumber.Size = new Size(140, 50);
                    RowNumber.Location = new Point(horizontal, vertical );
                    RowNumber.Text = ((int)rdr["Row_Number"]).ToString();
                    RowNumber.BackColor = Color.Transparent;
                    RowNumber.ForeColor = Color.White;
                    RowNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    horizontal += 150;



                    Button ReserveSeat = new Button();
                    ReserveSeat.Size = new Size(150, 50);
                    ReserveSeat.Location = new Point(horizontal, vertical - 13);
                    ReserveSeat.Text = "Reserve this Seat";
                    ReserveSeat.Click += Button_Click;
                    ReserveSeat.TabIndex = (int)rdr["Seat_ID"];
                    ReserveSeat.BackColor = Color.Black;
                    ReserveSeat.ForeColor = Color.White;
                    ReserveSeat.FlatAppearance.BorderSize = 0;
                    ReserveSeat.FlatStyle = FlatStyle.Flat;
                    ReserveSeat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));



                    this.Controls.Add(SeatNumber);

                    this.Controls.Add(RowNumber);
                    this.Controls.Add(ReserveSeat);
                   

                    vertical += 60;





                }
            }
        }
        protected void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int index = button.TabIndex;
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();

           
            string updateString = @"update [Seat] set Status = 1, User_ID=@userid where Seat_ID=@index";

            SqlCommand update = new SqlCommand(updateString, con);
            update.Parameters.AddWithValue("@index", button.TabIndex);
            update.Parameters.AddWithValue("@userid", LogIn.UserID);

            update.ExecuteNonQuery();

            MessageBox.Show("Your reservation completed successfully");



           






        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Details form = new Details();
            this.Hide();
            form.Show();
        }

    }
}
