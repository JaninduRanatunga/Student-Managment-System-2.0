using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using QRCoder;


namespace Student_Managment_System_2._0
{
    public partial class Hall_Reservation_For_Student : Form
    {
        String connectionString = "Data Source=JANINDU-RANATUN;Initial Catalog=StudentManagementDB;Integrated Security=True;";

        private readonly ReservationService reservationService;
        public Hall_Reservation_For_Student()
        {
            InitializeComponent();
            reservationService = new ReservationService();
        }

        private void usernameTxt_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Hall_Reservation_For_Student_Load(object sender, EventArgs e)
        {

        }
        public class ReservationService
        {
            private readonly string connectionString = "Data Source=JANINDU-RANATUN;Initial Catalog=StudentManagementDB;Integrated Security=True;";
            private const string FromEmail = "janinduac@gmail.com";
            private const string FromPassword = "akxd csyo cgqe uvqm";
            private const string SmtpServer = "smtp.gmail.com";
            private const int SmtpPort = 587;

            // ✅ Main method to reserve hall
            public void ReserveHall(string studentId, string HallNumber, DateTime reservationDate)
            {
                byte[] qrCodeImage = QRCodeHelper.GenerateQRCode(studentId);
                SaveReservation(studentId, HallNumber, reservationDate, qrCodeImage);
                SendEmailWithQRCode(studentId, qrCodeImage);
            }

            // ✅ Save data to SQL
            private void SaveReservation(string studentId, string HallNumber, DateTime reservationDate, byte[] qrCode)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO HallReservations(StudentID, HallNumber, ReservationDate, QRCode) VALUES (@StudentID, @HallNumber, @ReservationDate, @QRCode)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", studentId);
                        cmd.Parameters.AddWithValue("@HallNumber", HallNumber);
                        cmd.Parameters.AddWithValue("@ReservationDate", reservationDate);
                        cmd.Parameters.AddWithValue("@QRCode", qrCode);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            // ✅ Send email with QR code
            private void SendEmailWithQRCode(string studentId, byte[] qrCode)
            {
                string studentEmail = GetStudentEmail(studentId);

                if (string.IsNullOrEmpty(studentEmail))
                    throw new Exception("Student Email not found!");

                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(FromEmail),
                    Subject = "Hall Reservation Confirmation",
                    Body = $"Dear Student,\n\nYour reservation is successful.\nPlease find your QR Code attached.\n\nThank you."
                };
                mail.To.Add(studentEmail);

                using (MemoryStream ms = new MemoryStream(qrCode))
                {
                    Attachment attachment = new Attachment(ms, "QRCode.png", "image/png");
                    mail.Attachments.Add(attachment);

                    SmtpClient smtp = new SmtpClient(SmtpServer, SmtpPort)
                    {
                        Credentials = new NetworkCredential(FromEmail, FromPassword),
                        EnableSsl = true
                    };

                    smtp.Send(mail);
                }
            }

            // ✅ Retrieve student email from DB
            private string GetStudentEmail(string studentId)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Email FROM Students WHERE StudentID = @StudentID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", studentId);
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        return result?.ToString();
                    }
                }
            }
        }

        // ✅ QR Code generation helper
        public static class QRCodeHelper
        {
            public static byte[] GenerateQRCode(string data)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    QRCodeGenerator qrGenerator = new QRCodeGenerator();
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
                    QRCode qrCode = new QRCode(qrCodeData);
                    Bitmap qrBitmap = qrCode.GetGraphic(20);
                    qrBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string HallNumber = comboBoxHall.Text.ToString();
            DateTime reservationDate = dateTimePickerReservation.Value;
            string studentId = textBoxStudentID.Text.Trim();

            if (string.IsNullOrEmpty(HallNumber) || string.IsNullOrEmpty(studentId))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            try
            {
                reservationService.ReserveHall(studentId, HallNumber, reservationDate);
                MessageBox.Show("Reservation Successful! Email sent with QR Code.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred: {ex.Message}");
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string HallNumber = comboBoxHall.Text.Trim();
            DateTime reservationDate = dateTimePickerReservation.Value;
            string studentId = textBoxStudentID.Text.Trim();

            // ✅ Validation
            if (string.IsNullOrEmpty(HallNumber) || string.IsNullOrEmpty(studentId))
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // ✅ Call reservation logic
                reservationService.ReserveHall(studentId, HallNumber, reservationDate);
                MessageBox.Show("Reservation Successful! An email with QR Code has been sent.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
        
