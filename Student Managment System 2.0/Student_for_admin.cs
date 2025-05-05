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
    public partial class Student_for_admin : Form
    {
        string connectionString = "Data Source=JANINDU-RANATUN;Initial Catalog=StudentManagementDB;Integrated Security=True;";
        public Student_for_admin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            const string query = "DELETE FROM Students WHERE StudentID = @Id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Access the Text property and convert to the appropriate type (e.g., int)
                        int studentId;
                        if (int.TryParse(txtStudentId.Text, out studentId)) // Ensure it's a valid integer
                        {
                            cmd.Parameters.AddWithValue("@Id", studentId);

                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Deletion successful, you can add a message or return
                            }
                            else
                            {
                                // No rows affected means no record with the given ID
                                throw new Exception($"No student found with ID {studentId}.");
                            }
                        }
                        else
                        {
                            throw new Exception("Invalid student ID format.");
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // Handle SQL-specific exceptions (e.g., connection issues, syntax errors)
                Console.WriteLine($"SQL error occurred: {sqlEx.Message}");
                throw new Exception("A database error occurred while trying to delete the student.");
            }
            catch (Exception ex)
            {
                // Handle all other exceptions, including invalid ID format
                string studentId = txtStudentId.Text; // This is safe now, because we already checked
                Console.WriteLine($"General error: {ex.Message}");
                // throw new Exception($"An error occurred while deleting the student with ID {studentId}: {ex.Message}");
                MessageBox.Show("Delete Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Students_for_admin add_Students_For_Admin = new Add_Students_for_admin();
            add_Students_For_Admin.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Student_for_admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManagementDBDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.studentManagementDBDataSet.Students);

        }
    }
}
