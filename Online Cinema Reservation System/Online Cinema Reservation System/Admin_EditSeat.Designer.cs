namespace Online_Cinema_Reservation_System
{
    partial class Admin_EditSeat
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
            this.label9 = new System.Windows.Forms.Label();
            this.ReservedByLabel = new System.Windows.Forms.Label();
            this.RowNumberTextBox = new System.Windows.Forms.TextBox();
            this.SeatNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateSeat = new System.Windows.Forms.Button();
            this.StatusTextBox = new System.Windows.Forms.ComboBox();
            this.ReservedByTextBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(84, 101);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(51, 46);
            this.BackButton.TabIndex = 56;
            this.BackButton.Text = "↶";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(161, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 18);
            this.label10.TabIndex = 54;
            this.label10.Text = "Row Number :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(209, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 18);
            this.label9.TabIndex = 53;
            this.label9.Text = "Status :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // ReservedByLabel
            // 
            this.ReservedByLabel.AutoSize = true;
            this.ReservedByLabel.BackColor = System.Drawing.Color.Transparent;
            this.ReservedByLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservedByLabel.Location = new System.Drawing.Point(164, 228);
            this.ReservedByLabel.Name = "ReservedByLabel";
            this.ReservedByLabel.Size = new System.Drawing.Size(110, 18);
            this.ReservedByLabel.TabIndex = 52;
            this.ReservedByLabel.Text = "Reserved by :";
            this.ReservedByLabel.Click += new System.EventHandler(this.ReservedByLabel_Click);
            // 
            // RowNumberTextBox
            // 
            this.RowNumberTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowNumberTextBox.Location = new System.Drawing.Point(285, 148);
            this.RowNumberTextBox.Name = "RowNumberTextBox";
            this.RowNumberTextBox.Size = new System.Drawing.Size(193, 21);
            this.RowNumberTextBox.TabIndex = 46;
            this.RowNumberTextBox.TextChanged += new System.EventHandler(this.RowNumberTextBox_TextChanged);
            // 
            // SeatNumberTextBox
            // 
            this.SeatNumberTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatNumberTextBox.Location = new System.Drawing.Point(285, 113);
            this.SeatNumberTextBox.Name = "SeatNumberTextBox";
            this.SeatNumberTextBox.Size = new System.Drawing.Size(193, 21);
            this.SeatNumberTextBox.TabIndex = 45;
            this.SeatNumberTextBox.TextChanged += new System.EventHandler(this.SeatNumberTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 44;
            this.label1.Text = "Seat Number :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UpdateSeat
            // 
            this.UpdateSeat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateSeat.FlatAppearance.BorderSize = 0;
            this.UpdateSeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateSeat.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateSeat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UpdateSeat.Location = new System.Drawing.Point(279, 368);
            this.UpdateSeat.Name = "UpdateSeat";
            this.UpdateSeat.Size = new System.Drawing.Size(105, 42);
            this.UpdateSeat.TabIndex = 43;
            this.UpdateSeat.Text = "Update";
            this.UpdateSeat.UseVisualStyleBackColor = false;
            this.UpdateSeat.Click += new System.EventHandler(this.UpdateSeat_Click);
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusTextBox.FormattingEnabled = true;
            this.StatusTextBox.Items.AddRange(new object[] {
            "Reserved",
            "Empty"});
            this.StatusTextBox.Location = new System.Drawing.Point(285, 188);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(193, 21);
            this.StatusTextBox.TabIndex = 57;
            this.StatusTextBox.SelectedIndexChanged += new System.EventHandler(this.StatusTextBox_SelectedIndexChanged);
            // 
            // ReservedByTextBox
            // 
            this.ReservedByTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservedByTextBox.FormattingEnabled = true;
            this.ReservedByTextBox.Location = new System.Drawing.Point(285, 229);
            this.ReservedByTextBox.Name = "ReservedByTextBox";
            this.ReservedByTextBox.Size = new System.Drawing.Size(193, 21);
            this.ReservedByTextBox.TabIndex = 58;
            this.ReservedByTextBox.SelectedIndexChanged += new System.EventHandler(this.ReservedByTextBox_SelectedIndexChanged);
            // 
            // Admin_EditSeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Online_Cinema_Reservation_System.Properties.Resources.Cinema;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.ReservedByTextBox);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ReservedByLabel);
            this.Controls.Add(this.RowNumberTextBox);
            this.Controls.Add(this.SeatNumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateSeat);
            this.Name = "Admin_EditSeat";
            this.Text = "Admin_EditSeat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label ReservedByLabel;
        private System.Windows.Forms.TextBox RowNumberTextBox;
        private System.Windows.Forms.TextBox SeatNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateSeat;
        private System.Windows.Forms.ComboBox StatusTextBox;
        private System.Windows.Forms.ComboBox ReservedByTextBox;

    }
}