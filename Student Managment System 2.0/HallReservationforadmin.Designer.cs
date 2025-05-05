namespace Student_Managment_System_2._0
{
    partial class HallReservationforadmin
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reservationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hallNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hallReservationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentManagementDBDataSet = new Student_Managment_System_2._0.StudentManagementDBDataSet();
            this.hallReservationsTableAdapter = new Student_Managment_System_2._0.StudentManagementDBDataSetTableAdapters.HallReservationsTableAdapter();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallReservationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 103);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(411, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 58);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hall Reservation";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationIDDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn,
            this.reservationDateDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.attendeesDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.createdAtDataGridViewTextBoxColumn,
            this.hallNumberDataGridViewTextBoxColumn,
            this.reservationTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hallReservationsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1179, 427);
            this.dataGridView1.TabIndex = 16;
            // 
            // reservationIDDataGridViewTextBoxColumn
            // 
            this.reservationIDDataGridViewTextBoxColumn.DataPropertyName = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn.HeaderText = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reservationIDDataGridViewTextBoxColumn.Name = "reservationIDDataGridViewTextBoxColumn";
            this.reservationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.reservationIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // reservationDateDataGridViewTextBoxColumn
            // 
            this.reservationDateDataGridViewTextBoxColumn.DataPropertyName = "ReservationDate";
            this.reservationDateDataGridViewTextBoxColumn.HeaderText = "ReservationDate";
            this.reservationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reservationDateDataGridViewTextBoxColumn.Name = "reservationDateDataGridViewTextBoxColumn";
            this.reservationDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.Width = 125;
            // 
            // attendeesDataGridViewTextBoxColumn
            // 
            this.attendeesDataGridViewTextBoxColumn.DataPropertyName = "Attendees";
            this.attendeesDataGridViewTextBoxColumn.HeaderText = "Attendees";
            this.attendeesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.attendeesDataGridViewTextBoxColumn.Name = "attendeesDataGridViewTextBoxColumn";
            this.attendeesDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            this.createdAtDataGridViewTextBoxColumn.Width = 125;
            // 
            // hallNumberDataGridViewTextBoxColumn
            // 
            this.hallNumberDataGridViewTextBoxColumn.DataPropertyName = "HallNumber";
            this.hallNumberDataGridViewTextBoxColumn.HeaderText = "HallNumber";
            this.hallNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hallNumberDataGridViewTextBoxColumn.Name = "hallNumberDataGridViewTextBoxColumn";
            this.hallNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // reservationTimeDataGridViewTextBoxColumn
            // 
            this.reservationTimeDataGridViewTextBoxColumn.DataPropertyName = "ReservationTime";
            this.reservationTimeDataGridViewTextBoxColumn.HeaderText = "ReservationTime";
            this.reservationTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reservationTimeDataGridViewTextBoxColumn.Name = "reservationTimeDataGridViewTextBoxColumn";
            this.reservationTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // hallReservationsBindingSource
            // 
            this.hallReservationsBindingSource.DataMember = "HallReservations";
            this.hallReservationsBindingSource.DataSource = this.studentManagementDBDataSet;
            // 
            // studentManagementDBDataSet
            // 
            this.studentManagementDBDataSet.DataSetName = "StudentManagementDBDataSet";
            this.studentManagementDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hallReservationsTableAdapter
            // 
            this.hallReservationsTableAdapter.ClearBeforeFill = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogin.Location = new System.Drawing.Point(13, 585);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(1179, 44);
            this.buttonLogin.TabIndex = 38;
            this.buttonLogin.Text = "Scann QR Code";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // HallReservationforadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 641);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "HallReservationforadmin";
            this.Text = "HallReservationforadmin";
            this.Load += new System.EventHandler(this.HallReservationforadmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallReservationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private StudentManagementDBDataSet studentManagementDBDataSet;
        private System.Windows.Forms.BindingSource hallReservationsBindingSource;
        private StudentManagementDBDataSetTableAdapters.HallReservationsTableAdapter hallReservationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonLogin;
    }
}