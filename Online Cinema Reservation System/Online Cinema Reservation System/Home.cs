﻿using System;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

    

        private void LogInButton_Click(object sender, EventArgs e)
        {
            LogIn form = new LogIn();
            this.Hide();
            form.ShowDialog();

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUp Form = new SignUp();
            this.Hide();
            Form.ShowDialog();

        }
    }
}
