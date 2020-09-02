namespace Online_Cinema_Reservation_System
{
    partial class AdminMovies
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
            this.AddMovie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddMovie
            // 
            this.AddMovie.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddMovie.FlatAppearance.BorderSize = 0;
            this.AddMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMovie.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMovie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddMovie.Location = new System.Drawing.Point(170, 12);
            this.AddMovie.Name = "AddMovie";
            this.AddMovie.Size = new System.Drawing.Size(402, 42);
            this.AddMovie.TabIndex = 3;
            this.AddMovie.Text = "Add New Movie";
            this.AddMovie.UseVisualStyleBackColor = false;
            this.AddMovie.Click += new System.EventHandler(this.AddMovie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Movie Name";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(12, 407);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(39, 42);
            this.BackButton.TabIndex = 32;
            this.BackButton.Text = "↶";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AdminMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Online_Cinema_Reservation_System.Properties.Resources.Movie;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AddMovie);
            this.Controls.Add(this.label1);
            this.Name = "AdminMovies";
            this.Text = "AdminMovies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
    }
}