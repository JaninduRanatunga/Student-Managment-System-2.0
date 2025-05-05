namespace Student_Managment_System_2._0
{
    partial class Markattendancesubpart
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
            this.button1 = new System.Windows.Forms.Button();
            this.usernameTxt = new System.Windows.Forms.Label();
            this.textBoxReservationId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(21, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(371, 44);
            this.button1.TabIndex = 46;
            this.button1.Text = "Reserve Now";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usernameTxt
            // 
            this.usernameTxt.AutoSize = true;
            this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(21, 34);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(176, 22);
            this.usernameTxt.TabIndex = 45;
            this.usernameTxt.Text = "Enter Reservation ID";
            // 
            // textBoxReservationId
            // 
            this.textBoxReservationId.Location = new System.Drawing.Point(21, 77);
            this.textBoxReservationId.Multiline = true;
            this.textBoxReservationId.Name = "textBoxReservationId";
            this.textBoxReservationId.Size = new System.Drawing.Size(371, 36);
            this.textBoxReservationId.TabIndex = 44;
            // 
            // Markattendancesubpart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 201);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.textBoxReservationId);
            this.Name = "Markattendancesubpart";
            this.Text = "Markattendancesubpart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label usernameTxt;
        private System.Windows.Forms.TextBox textBoxReservationId;
    }
}