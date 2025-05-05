using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Managment_System_2._0
{
    public partial class Markattendancesubpart : Form
    {

        string connectionString = "Data Source=JANINDU-RANATUN;Initial Catalog=StudentManagementDB;Integrated Security=True;";
        public Markattendancesubpart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string reservationId = textBoxReservationId.Text.Trim(); // Get the entered ReservationID

            if (!string.IsNullOrEmpty(reservationId))
            {
                bool isUpdated = UpdateReservationStatus(reservationId, "1"); // Pass "1" as string to match nvarchar

                if (isUpdated)
                {
                    MessageBox.Show("Reservation status updated to 1 successfully.");
                    // Optionally refresh the reservation table UI
                }
                else
                {
                    MessageBox.Show("Failed to update reservation status or ID not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a Reservation ID.");
            }
        }


        private bool UpdateReservationStatus(string reservationId, string status)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE dbo.HallReservations SET Status = @Status WHERE ReservationID = @ReservationID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ReservationID", reservationId);
                        cmd.Parameters.AddWithValue("@Status", status);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Returns true if at least one row was updated
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

    }
}
