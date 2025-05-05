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
    public partial class HallReservationforadmin : Form
    {
        public HallReservationforadmin()
        {
            InitializeComponent();
        }

        private void HallReservationforadmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManagementDBDataSet.HallReservations' table. You can move, or remove it, as needed.
            this.hallReservationsTableAdapter.Fill(this.studentManagementDBDataSet.HallReservations);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Scan_QR_code_for_admin scan_QR_Code_For_Admin = new Scan_QR_code_for_admin();
            scan_QR_Code_For_Admin.Show();
        }
    }
}
