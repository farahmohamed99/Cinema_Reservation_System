namespace Online_Cinema_Reservation_System
{
    partial class AdminHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CinemasButton = new System.Windows.Forms.Button();
            this.Movies = new System.Windows.Forms.Button();
            this.UsersButton = new System.Windows.Forms.Button();
            this.SeatsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CinemasButton
            // 
            this.CinemasButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CinemasButton.FlatAppearance.BorderSize = 0;
            this.CinemasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CinemasButton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CinemasButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CinemasButton.Location = new System.Drawing.Point(242, 21);
            this.CinemasButton.Name = "CinemasButton";
            this.CinemasButton.Size = new System.Drawing.Size(284, 73);
            this.CinemasButton.TabIndex = 0;
            this.CinemasButton.Text = "Cinemas";
            this.CinemasButton.UseVisualStyleBackColor = false;
            this.CinemasButton.Click += new System.EventHandler(this.CinemasButton_Click);
            // 
            // Movies
            // 
            this.Movies.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Movies.FlatAppearance.BorderSize = 0;
            this.Movies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Movies.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movies.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Movies.Location = new System.Drawing.Point(242, 112);
            this.Movies.Name = "Movies";
            this.Movies.Size = new System.Drawing.Size(284, 73);
            this.Movies.TabIndex = 1;
            this.Movies.Text = "Movies";
            this.Movies.UseVisualStyleBackColor = false;
            this.Movies.Click += new System.EventHandler(this.Movies_Click);
            // 
            // UsersButton
            // 
            this.UsersButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.UsersButton.FlatAppearance.BorderSize = 0;
            this.UsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersButton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UsersButton.Location = new System.Drawing.Point(242, 213);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(284, 73);
            this.UsersButton.TabIndex = 2;
            this.UsersButton.Text = "Users";
            this.UsersButton.UseVisualStyleBackColor = false;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // SeatsButton
            // 
            this.SeatsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SeatsButton.FlatAppearance.BorderSize = 0;
            this.SeatsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeatsButton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SeatsButton.Location = new System.Drawing.Point(242, 311);
            this.SeatsButton.Name = "SeatsButton";
            this.SeatsButton.Size = new System.Drawing.Size(284, 73);
            this.SeatsButton.TabIndex = 3;
            this.SeatsButton.Text = "Seats";
            this.SeatsButton.UseVisualStyleBackColor = false;
            this.SeatsButton.Click += new System.EventHandler(this.SeatsButton_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Online_Cinema_Reservation_System.Properties.Resources.Movie;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.SeatsButton);
            this.Controls.Add(this.UsersButton);
            this.Controls.Add(this.Movies);
            this.Controls.Add(this.CinemasButton);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CinemasButton;
        private System.Windows.Forms.Button Movies;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button SeatsButton;
    }
}