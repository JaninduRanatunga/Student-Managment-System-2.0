using System;
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
    public partial class StudentDashboard : Form
    {
        public StudentDashboard(int userId)
        {
            InitializeComponent();
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hall_Reservation_For_Student hall_Reservation_For_Student = new Hall_Reservation_For_Student();
            hall_Reservation_For_Student.Show();
        }
    }
}
