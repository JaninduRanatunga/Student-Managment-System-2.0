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
    public partial class TeachersDashboard : Form
    {
        public TeachersDashboard(int userID)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manage_Results_for_Teachers manage_Results_For_Teachers = new Manage_Results_for_Teachers();
            manage_Results_For_Teachers.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student_for_teachers student_For_Teachers = new Student_for_teachers();
            student_For_Teachers.Show();
        }
    }
}
