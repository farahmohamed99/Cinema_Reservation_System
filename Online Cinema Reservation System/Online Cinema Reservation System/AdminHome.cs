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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void CinemasButton_Click(object sender, EventArgs e)
        {
            Cinemas form = new Cinemas();
            this.Hide();
            form.ShowDialog();
          
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            AdminUsers form = new AdminUsers();
            this.Hide();
            form.ShowDialog();
        }

        private void SeatsButton_Click(object sender, EventArgs e)
        {
            Admin_Seats form = new Admin_Seats();
            this.Hide();
            form.ShowDialog();
        }

        private void Movies_Click(object sender, EventArgs e)
        {
            AdminMovies form = new AdminMovies();
            this.Hide();
            form.ShowDialog();
        }

       

       
    }
}
