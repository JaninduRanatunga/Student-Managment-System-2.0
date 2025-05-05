using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Managment_System_2._0
{
    public class Student
    {
        // Private fields
        private int id;
        private string fullName;
        private string phoneNumber;
        private string course;
        private string email;
        private string gender;
        private string address;
        private string guardianName;
        private string guardianPhone;
        private string dateOfBirth; // Stored as string in format YYYY-MM-DD

        // Public properties (Encapsulation)
        public int Id { get => id; set => id = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Course { get => course; set => course = value; }
        public string Email { get => email; set => email = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; }
        public string GuardianName { get => guardianName; set => guardianName = value; }
        public string GuardianPhone { get => guardianPhone; set => guardianPhone = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }

        // Constructor
        public Student(string fullName, string phoneNumber, string course, string email,
                       string gender, string address, string guardianName, string guardianPhone, string dateOfBirth)
        {
            this.id = id;
            this.fullName = fullName;
            this.phoneNumber = phoneNumber;
            this.course = course;
            this.email = email;
            this.gender = gender;
            this.address = address;
            this.guardianName = guardianName;
            this.guardianPhone = guardianPhone;
            this.dateOfBirth = dateOfBirth;
        }
    }


}
