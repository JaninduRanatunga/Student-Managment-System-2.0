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
    public partial class Add_Students_for_admin : Form
    {
        public Add_Students_for_admin()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTxt_Click(object sender, EventArgs e)
        {

        }

        private void Add_Students_for_admin_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // Get input values from form fields
                    //int studentId = Convert.ToInt32(txtStudentId.Text); // Assuming there's a text box for ID
                    string fullName = txtFullName.Text;
                    string phoneNumber = txtPhoneNumber.Text;
                    string course = txtCourse.Text;
                    string email = txtEmail.Text;
                    string gender = rbMale.Checked ? "Male" : "Female";
                    string address = txtAddress.Text;
                    string guardianName = txtGuardianName.Text;
                    string guardianPhone = txtGuardianPhone.Text;
                    string dob = $"{txtDOBYear.Text}-{txtDOBMonth.Text}-{txtDOBDay.Text}"; // Format as YYYY-MM-DD

                    // Create a Student object
                    Student student = new Student(fullName, phoneNumber, course, email,
                                                  gender, address, guardianName, guardianPhone, dob);

                    // Call the repository method to update the student
                    StudentRepository studentRepository = new StudentRepository();
                    bool isUpdated = studentRepository.UpdateStudent(student);

                    if (isUpdated)
                    {
                        MessageBox.Show("Data updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Update failed. No records were updated.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }

            }
        }
    }
}
