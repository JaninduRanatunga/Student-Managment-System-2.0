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
    public partial class Student_for_teachers : Form
    {
        public Student_for_teachers()
        {
            InitializeComponent();
        }

        private void Student_for_teachers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManagementDBDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.studentManagementDBDataSet.Students);

        }
    }
}
