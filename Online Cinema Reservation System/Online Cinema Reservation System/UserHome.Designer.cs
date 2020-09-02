namespace Online_Cinema_Reservation_System
{
    partial class UserHome
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
            this.NewReservation = new System.Windows.Forms.Button();
            this.RecentReservations = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.EditInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewReservation
            // 
            this.NewReservation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NewReservation.FlatAppearance.BorderSize = 0;
            this.NewReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewReservation.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewReservation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NewReservation.Location = new System.Drawing.Point(107, 140);
            this.NewReservation.Name = "NewReservation";
            this.NewReservation.Size = new System.Drawing.Size(171, 94);
            this.NewReservation.TabIndex = 0;
            this.NewReservation.Text = "Add New Reservation";
            this.NewReservation.UseVisualStyleBackColor = false;
            this.NewReservation.Click += new System.EventHandler(this.NewReservation_Click);
            // 
            // RecentReservations
            // 
            this.RecentReservations.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RecentReservations.FlatAppearance.BorderSize = 0;
            this.RecentReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecentReservations.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecentReservations.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RecentReservations.Location = new System.Drawing.Point(335, 140);
            this.RecentReservations.Name = "RecentReservations";
            this.RecentReservations.Size = new System.Drawing.Size(171, 94);
            this.RecentReservations.TabIndex = 1;
            this.RecentReservations.Text = "My Recent Reservations";
            this.RecentReservations.UseVisualStyleBackColor = false;
            this.RecentReservations.Click += new System.EventHandler(this.RecentReservations_Click);
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LogOut.FlatAppearance.BorderSize = 0;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LogOut.Location = new System.Drawing.Point(494, 422);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(78, 27);
            this.LogOut.TabIndex = 3;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // EditInfoButton
            // 
            this.EditInfoButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EditInfoButton.FlatAppearance.BorderSize = 0;
            this.EditInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditInfoButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditInfoButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EditInfoButton.Location = new System.Drawing.Point(194, 53);
            this.EditInfoButton.Name = "EditInfoButton";
            this.EditInfoButton.Size = new System.Drawing.Size(209, 38);
            this.EditInfoButton.TabIndex = 4;
            this.EditInfoButton.Text = "Edit Profile Information";
            this.EditInfoButton.UseVisualStyleBackColor = false;
            this.EditInfoButton.Click += new System.EventHandler(this.EditInfoButton_Click);
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Online_Cinema_Reservation_System.Properties.Resources.Cinema;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.EditInfoButton);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.RecentReservations);
            this.Controls.Add(this.NewReservation);
            this.Name = "UserHome";
            this.Text = "UserHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewReservation;
        private System.Windows.Forms.Button RecentReservations;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button EditInfoButton;
    }
}