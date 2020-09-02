using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Cinema_Reservation_System
{
    public partial class UserHome : Form
    {
        public UserHome()
        {
            InitializeComponent();
        }

        private void RecentReservations_Click(object sender, EventArgs e)
        {
            UserReservations form = new UserReservations();
            this.Hide();
            form.ShowDialog();
        }

        private void NewReservation_Click(object sender, EventArgs e)
        {
            MovieList form = new MovieList();
            this.Hide();
            form.ShowDialog();
        }

       

        private void LogOut_Click(object sender, EventArgs e)
        {
            Home form = new Home();
            this.Hide();
            form.ShowDialog();
        }

        private void EditInfoButton_Click(object sender, EventArgs e)
        {
            EditInfo form = new EditInfo();
            this.Hide();
            form.ShowDialog();

        }
    }
}
