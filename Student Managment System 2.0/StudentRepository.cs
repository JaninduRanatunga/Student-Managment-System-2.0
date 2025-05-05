using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Managment_System_2._0
{
    public class StudentRepository
    {


        private string connectionString = "Data Source=JANINDU-RANATUN;Initial Catalog=StudentManagementDB;Integrated Security=True;";

        // Update student method
        public bool UpdateStudent(Student student)
        {
            string query = "INSERT INTO Students (FullName, PhoneNumber, Course, Email, Gender, Address, " +
                              "GuardianName, GuardianPhone, DateOfBirth) " +
                              "VALUES (@FullName, @PhoneNumber, @Course, @Email, @Gender, @Address, " +
                              "@GuardianName, @GuardianPhone, @DOB)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Add parameters
                    cmd.Parameters.AddWithValue("@FullName", student.FullName);
                    cmd.Parameters.AddWithValue("@PhoneNumber", student.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Course", student.Course);
                    cmd.Parameters.AddWithValue("@Email", student.Email);
                    cmd.Parameters.AddWithValue("@Gender", student.Gender);
                    cmd.Parameters.AddWithValue("@Address", student.Address);
                    cmd.Parameters.AddWithValue("@GuardianName", student.GuardianName);
                    cmd.Parameters.AddWithValue("@GuardianPhone", student.GuardianPhone);
                    cmd.Parameters.AddWithValue("@DOB", student.DateOfBirth);
                    cmd.Parameters.AddWithValue("@Id", student.Id);

                    // Execute the update command
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; // Returns true if update is successful
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating student: " + ex.Message);
            }
        }


        public bool DeleteStudent(int studentId)
        {
            string query = "DELETE * FROM Students WHERE Id = @Id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Add parameter
                    cmd.Parameters.AddWithValue("@Id", studentId);

                    // Execute the delete command
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; // Returns true if deletion is successful
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting student: " + ex.Message);
            }
        }
    }
}

