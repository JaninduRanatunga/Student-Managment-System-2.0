﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Managment_System_2._0
{
    public partial class Attendance_for_Students : Form
    {
        public Attendance_for_Students()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Attendance_for_Students_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManagementDBDataSet.Attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.studentManagementDBDataSet.Attendance);

        }
    }
}
