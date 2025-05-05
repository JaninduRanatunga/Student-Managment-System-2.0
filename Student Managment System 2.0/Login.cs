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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string email = txtUsername.Text;
            string password = txtPassword.Text;

            string connectionString = "Data Source=JANINDU-RANATUN;Initial Catalog=StudentManagementDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // SQL query to fetch the role and user ID based on email
                string query = "SELECT Role, UserID FROM Users WHERE Email = @Email AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                try
                {
                    // Open the connection
                    conn.Open();


                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {

                        reader.Read();
                        string role = reader["Role"].ToString();
                        int userId = Convert.ToInt32(reader["UserID"]);


                        reader.Close();


                        MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        this.Hide();


                        switch (role)
                        {
                            case "Admin":

                                AdminDashboard adminDashboard = new AdminDashboard(userId);
                                adminDashboard.Show();
                                break;

                            //case "Teacher":
                                //TeachersDashboard teachersDashboard = new TeachersDashboard(userId);
                                //teachersDashboard.Show();
                                //break;

                            case "Student":
                                StudentDashboard studentDashboard = new StudentDashboard(userId);
                                studentDashboard.Show();
                                break;

                            default:
                                MessageBox.Show("Invalid role assigned.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Email or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {

                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }
    }
    }

