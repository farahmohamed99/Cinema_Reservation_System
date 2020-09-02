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
    public partial class Admin_Seats : Form
    {
        public static int CinemaID;
        public Admin_Seats()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=OLA\SQLSERVER;Initial Catalog=Cinema System;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
            con.Open();
             SqlCommand Cinema = new SqlCommand("Select Cinema_ID, Cinema_Name from [Cinema];", con);
            SqlDataReader Cinemardr = Cinema.ExecuteReader();
            int vertical = 80;
            while (Cinemardr.Read())
            {
                int horizontal = 50;
                Button CinemaButton = new Button();
                CinemaButton.Size = new Size(500, 50);
                CinemaButton.TabIndex = (int)Cinemardr["Cinema_ID"];
                CinemaButton.Location = new Point(horizontal, vertical - 13);
                CinemaButton.Text = (String)Cinemardr["Cinema_Name"];
                CinemaButton.Click += CinemaButton_Click;
                CinemaButton.BackColor = Color.Black;
                CinemaButton.ForeColor = Color.White;
                CinemaButton.FlatAppearance.BorderSize = 0;
                CinemaButton.FlatStyle = FlatStyle.Flat;
                CinemaButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                vertical += 60;
                this.Controls.Add(CinemaButton);



            }
            con.Close();
        }
        protected void CinemaButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            CinemaID = button.TabIndex;

            CinemaSeats form = new CinemaSeats();
            this.Hide();
            form.ShowDialog();




        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminHome form = new AdminHome();
            this.Hide();
            form.ShowDialog();
        }



    }
}
