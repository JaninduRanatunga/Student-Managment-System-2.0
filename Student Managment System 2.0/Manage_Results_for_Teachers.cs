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
    public partial class Manage_Results_for_Teachers : Form
     {
        string connectionString = "Data Source=JANINDU-RANATUN;Initial Catalog=StudentManagementDB;Integrated Security=True;";
        public Manage_Results_for_Teachers()
        {
            InitializeComponent();
        }

        private void Manage_Results_for_Teachers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManagementDBDataSet.ExamRecords' table. You can move, or remove it, as needed.
            this.examRecordsTableAdapter.Fill(this.studentManagementDBDataSet.ExamRecords);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    string query = @"INSERT INTO ExamRecords 
                                    (StudentID, TeacherID, Subject, Marks, ExamDate, CreatedAt) 
                                     VALUES 
                                    (@StudentID, @TeacherID, @Subject, @Marks, @ExamDate, @CreatedAt)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StudentID", string.IsNullOrEmpty(txtIndexNumber.Text) ? (object)DBNull.Value : int.Parse(txtIndexNumber.Text));
                    cmd.Parameters.AddWithValue("@TeacherID", 1); // Replace 1 with dynamic teacher ID if needed
                    cmd.Parameters.AddWithValue("@Subject", cmbSubject.Text);
                    cmd.Parameters.AddWithValue("@Marks", string.IsNullOrEmpty(txtMarks.Text) ? (object)DBNull.Value : Convert.ToDecimal(txtMarks.Text));
                    cmd.Parameters.AddWithValue("@ExamDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Exam result added successfully!");
                    Manage_Results_for_Teachers manage_Results_For_Teachers = new Manage_Results_for_Teachers();
                    manage_Results_For_Teachers.Hide();

                    // Refresh the grid
                    examRecordsTableAdapter.Fill(studentManagementDBDataSet.ExamRecords);
                    dataGridView1.DataSource = studentManagementDBDataSet.ExamRecords;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter valid inputs.\n" + ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("A database error occurred.\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int recordID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["RecordID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        string query = "UPDATE ExamRecords SET Marks = @Marks WHERE RecordID = @RecordID";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Marks", Convert.ToDecimal(txtMarks.Text));
                        cmd.Parameters.AddWithValue("@RecordID", recordID);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Marks updated successfully!");

                        // Refresh the grid
                        examRecordsTableAdapter.Fill(studentManagementDBDataSet.ExamRecords);
                        dataGridView1.DataSource = studentManagementDBDataSet.ExamRecords;
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Please enter a valid number for marks.\n" + ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Database error occurred.\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An unexpected error occurred.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a record to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxReservationId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
