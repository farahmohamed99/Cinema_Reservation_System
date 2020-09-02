namespace Online_Cinema_Reservation_System
{
    partial class Admin_AddSeat
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
            this.BackButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.RowNumberTextBox = new System.Windows.Forms.TextBox();
            this.SeatNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddSeat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(89, 122);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(51, 46);
            this.BackButton.TabIndex = 66;
            this.BackButton.Text = "↶";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(166, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 18);
            this.label10.TabIndex = 65;
            this.label10.Text = "Row Number :";
            // 
            // RowNumberTextBox
            // 
            this.RowNumberTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowNumberTextBox.Location = new System.Drawing.Point(290, 169);
            this.RowNumberTextBox.Name = "RowNumberTextBox";
            this.RowNumberTextBox.Size = new System.Drawing.Size(193, 21);
            this.RowNumberTextBox.TabIndex = 62;
            // 
            // SeatNumberTextBox
            // 
            this.SeatNumberTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatNumberTextBox.Location = new System.Drawing.Point(290, 134);
            this.SeatNumberTextBox.Name = "SeatNumberTextBox";
            this.SeatNumberTextBox.Size = new System.Drawing.Size(193, 21);
            this.SeatNumberTextBox.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 60;
            this.label1.Text = "Seat Number :";
            // 
            // AddSeat
            // 
            this.AddSeat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddSeat.FlatAppearance.BorderSize = 0;
            this.AddSeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSeat.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSeat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddSeat.Location = new System.Drawing.Point(252, 387);
            this.AddSeat.Name = "AddSeat";
            this.AddSeat.Size = new System.Drawing.Size(105, 42);
            this.AddSeat.TabIndex = 59;
            this.AddSeat.Text = "Add";
            this.AddSeat.UseVisualStyleBackColor = false;
            this.AddSeat.Click += new System.EventHandler(this.AddSeat_Click);
            // 
            // Admin_AddSeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Online_Cinema_Reservation_System.Properties.Resources.Cinema;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.RowNumberTextBox);
            this.Controls.Add(this.SeatNumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddSeat);
            this.Name = "Admin_AddSeat";
            this.Text = "Admin_AddSeat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox RowNumberTextBox;
        private System.Windows.Forms.TextBox SeatNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddSeat;

    }
}