namespace Online_Cinema_Reservation_System
{
    partial class EditCinema
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
            this.UpdateCinema = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MoviesBox = new System.Windows.Forms.ComboBox();
            this.StreetBox = new System.Windows.Forms.TextBox();
            this.StateBox = new System.Windows.Forms.TextBox();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.SeatsBox = new System.Windows.Forms.TextBox();
            this.CinemaNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpdateCinema
            // 
            this.UpdateCinema.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateCinema.FlatAppearance.BorderSize = 0;
            this.UpdateCinema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateCinema.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCinema.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UpdateCinema.Location = new System.Drawing.Point(239, 376);
            this.UpdateCinema.Name = "UpdateCinema";
            this.UpdateCinema.Size = new System.Drawing.Size(105, 42);
            this.UpdateCinema.TabIndex = 10;
            this.UpdateCinema.Text = "Update";
            this.UpdateCinema.UseVisualStyleBackColor = false;
            this.UpdateCinema.Click += new System.EventHandler(this.UpdateCinema_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 41;
            this.label3.Text = "Movie :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(109, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 18);
            this.label10.TabIndex = 40;
            this.label10.Text = "Number of Seats :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(203, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 18);
            this.label9.TabIndex = 39;
            this.label9.Text = "City :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(194, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 18);
            this.label8.TabIndex = 38;
            this.label8.Text = "State :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(124, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 18);
            this.label7.TabIndex = 37;
            this.label7.Text = "Street Number :";
            // 
            // MoviesBox
            // 
            this.MoviesBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoviesBox.FormattingEnabled = true;
            this.MoviesBox.Location = new System.Drawing.Point(256, 260);
            this.MoviesBox.Name = "MoviesBox";
            this.MoviesBox.Size = new System.Drawing.Size(193, 21);
            this.MoviesBox.TabIndex = 36;
            // 
            // StreetBox
            // 
            this.StreetBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreetBox.Location = new System.Drawing.Point(256, 221);
            this.StreetBox.Name = "StreetBox";
            this.StreetBox.Size = new System.Drawing.Size(193, 21);
            this.StreetBox.TabIndex = 35;
            // 
            // StateBox
            // 
            this.StateBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateBox.Location = new System.Drawing.Point(256, 182);
            this.StateBox.Name = "StateBox";
            this.StateBox.Size = new System.Drawing.Size(193, 21);
            this.StateBox.TabIndex = 34;
            // 
            // CityBox
            // 
            this.CityBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityBox.Location = new System.Drawing.Point(256, 144);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(193, 21);
            this.CityBox.TabIndex = 33;
            // 
            // SeatsBox
            // 
            this.SeatsBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatsBox.Location = new System.Drawing.Point(256, 105);
            this.SeatsBox.Name = "SeatsBox";
            this.SeatsBox.Size = new System.Drawing.Size(193, 21);
            this.SeatsBox.TabIndex = 32;
            // 
            // CinemaNameBox
            // 
            this.CinemaNameBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CinemaNameBox.Location = new System.Drawing.Point(256, 70);
            this.CinemaNameBox.Name = "CinemaNameBox";
            this.CinemaNameBox.Size = new System.Drawing.Size(193, 21);
            this.CinemaNameBox.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Cinema Name :";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(55, 58);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(51, 46);
            this.BackButton.TabIndex = 42;
            this.BackButton.Text = "↶";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EditCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Online_Cinema_Reservation_System.Properties.Resources.Cinema;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MoviesBox);
            this.Controls.Add(this.StreetBox);
            this.Controls.Add(this.StateBox);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.SeatsBox);
            this.Controls.Add(this.CinemaNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateCinema);
            this.Name = "EditCinema";
            this.Text = "EditCinema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateCinema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox MoviesBox;
        private System.Windows.Forms.TextBox StreetBox;
        private System.Windows.Forms.TextBox StateBox;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.TextBox SeatsBox;
        private System.Windows.Forms.TextBox CinemaNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
    }
}