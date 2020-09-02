namespace Online_Cinema_Reservation_System
{
    partial class AddCinema
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
            this.add = new System.Windows.Forms.Button();
            this.StreetBox = new System.Windows.Forms.TextBox();
            this.StateBox = new System.Windows.Forms.TextBox();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.SeatsBox = new System.Windows.Forms.TextBox();
            this.CinemaNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MoviesBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.add.Location = new System.Drawing.Point(236, 381);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(97, 45);
            this.add.TabIndex = 21;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // StreetBox
            // 
            this.StreetBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreetBox.Location = new System.Drawing.Point(236, 213);
            this.StreetBox.Name = "StreetBox";
            this.StreetBox.Size = new System.Drawing.Size(193, 21);
            this.StreetBox.TabIndex = 20;
            this.StreetBox.TextChanged += new System.EventHandler(this.StreetBox_TextChanged);
            // 
            // StateBox
            // 
            this.StateBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateBox.Location = new System.Drawing.Point(236, 174);
            this.StateBox.Name = "StateBox";
            this.StateBox.Size = new System.Drawing.Size(193, 21);
            this.StateBox.TabIndex = 19;
            this.StateBox.TextChanged += new System.EventHandler(this.StateBox_TextChanged);
            // 
            // CityBox
            // 
            this.CityBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityBox.Location = new System.Drawing.Point(236, 136);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(193, 21);
            this.CityBox.TabIndex = 18;
            this.CityBox.TextChanged += new System.EventHandler(this.CityBox_TextChanged);
            // 
            // SeatsBox
            // 
            this.SeatsBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatsBox.Location = new System.Drawing.Point(236, 97);
            this.SeatsBox.Name = "SeatsBox";
            this.SeatsBox.Size = new System.Drawing.Size(193, 21);
            this.SeatsBox.TabIndex = 17;
            this.SeatsBox.TextChanged += new System.EventHandler(this.SeatsBox_TextChanged);
            // 
            // CinemaNameBox
            // 
            this.CinemaNameBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CinemaNameBox.Location = new System.Drawing.Point(236, 62);
            this.CinemaNameBox.Name = "CinemaNameBox";
            this.CinemaNameBox.Size = new System.Drawing.Size(193, 21);
            this.CinemaNameBox.TabIndex = 16;
            this.CinemaNameBox.TextChanged += new System.EventHandler(this.CinemaNameBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cinema Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MoviesBox
            // 
            this.MoviesBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoviesBox.FormattingEnabled = true;
            this.MoviesBox.Location = new System.Drawing.Point(236, 252);
            this.MoviesBox.Name = "MoviesBox";
            this.MoviesBox.Size = new System.Drawing.Size(193, 21);
            this.MoviesBox.TabIndex = 23;
            this.MoviesBox.SelectedIndexChanged += new System.EventHandler(this.MoviesBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(104, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Street Number :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(174, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "State :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(183, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "City :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(89, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 18);
            this.label10.TabIndex = 27;
            this.label10.Text = "Number of Seats :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(933, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Street :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Movie :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(54, 41);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(51, 46);
            this.BackButton.TabIndex = 30;
            this.BackButton.Text = "↶";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Online_Cinema_Reservation_System.Properties.Resources.Cinema;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MoviesBox);
            this.Controls.Add(this.add);
            this.Controls.Add(this.StreetBox);
            this.Controls.Add(this.StateBox);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.SeatsBox);
            this.Controls.Add(this.CinemaNameBox);
            this.Controls.Add(this.label1);
            this.Name = "AddCinema";
            this.Text = "AddCinema";
            this.Load += new System.EventHandler(this.AddCinema_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox StreetBox;
        private System.Windows.Forms.TextBox StateBox;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.TextBox SeatsBox;
        private System.Windows.Forms.TextBox CinemaNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MoviesBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BackButton;
    }
}