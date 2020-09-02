namespace Online_Cinema_Reservation_System
{
    partial class Cinemas
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddCinema = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cinema Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddCinema
            // 
            this.AddCinema.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddCinema.FlatAppearance.BorderSize = 0;
            this.AddCinema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCinema.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCinema.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddCinema.Location = new System.Drawing.Point(170, 12);
            this.AddCinema.Name = "AddCinema";
            this.AddCinema.Size = new System.Drawing.Size(402, 42);
            this.AddCinema.TabIndex = 1;
            this.AddCinema.Text = "Add New Cinema";
            this.AddCinema.UseVisualStyleBackColor = false;
            this.AddCinema.Click += new System.EventHandler(this.AddCinema_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(7, 407);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(39, 42);
            this.BackButton.TabIndex = 31;
            this.BackButton.Text = "↶";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Cinemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Online_Cinema_Reservation_System.Properties.Resources.Movie;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AddCinema);
            this.Controls.Add(this.label1);
            this.Name = "Cinemas";
            this.Text = "Cinemas";
            this.Load += new System.EventHandler(this.Cinemas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddCinema;
        private System.Windows.Forms.Button BackButton;
    }
}