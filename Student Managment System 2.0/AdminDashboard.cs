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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard(int userId)
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student_for_admin student_For_Admin = new Student_for_admin();
            student_For_Admin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           HallReservationforadmin hallReservationforadmin = new HallReservationforadmin();
           hallReservationforadmin.Show();

            
        }
    }
}
