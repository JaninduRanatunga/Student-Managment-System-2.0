using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;


namespace Student_Managment_System_2._0
{
    public partial class Scan_QR_code_for_admin : Form
    {

       
        public Scan_QR_code_for_admin()
        {
            InitializeComponent();
        }

        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No video devices found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Start video capture from selected device
            videoSource = new VideoCaptureDevice(videoDevices[cboDevice.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
            videoSource.Start();
            timer1.Start();
        }

        private void cboDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                // Stop current video capture and switch to the selected video device
                if (videoSource != null && videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                }

                // Restart video capture with the new device
                videoSource = new VideoCaptureDevice(videoDevices[cboDevice.SelectedIndex].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
                videoSource.Start();
            
        }

        private void Scan_QR_code_for_admin_Load(object sender, EventArgs e)
        {
            // Get available video devices (webcams)
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in videoDevices)
            {
                cboDevice.Items.Add(device.Name);
            }

            if (cboDevice.Items.Count > 0)
                cboDevice.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Markattendancesubpart markattendancesubpart = new Markattendancesubpart();
            markattendancesubpart.Show();
        }
        private void StopCamera()
        {
            // Stop the video capture
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                try
                {
                    // Decode QR code from the image in the PictureBox
                    BarcodeReader barcodeReader = new BarcodeReader();
                    Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);

                    // If QR code is found, display it in the TextBox
                    if (result != null)
                    {
                        txtQRCode.Text = result.Text;
                    }
                    else
                    {
                        MessageBox.Show("No QR Code detected in the image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error processing the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No image to process. Please capture a frame first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtQRCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Periodically check for QR codes in the current frame
            if (pictureBox1.Image != null)
            {
                try
                {
                    BarcodeReader barcodeReader = new BarcodeReader();
                    Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                    if (result != null)
                    {
                        txtQRCode.Text = result.Text;
                        timer1.Stop(); // Stop the timer if QR code is found
                        StopCamera();  // Stop the camera
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error decoding QR Code: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Scan_QR_code_for_admin_LoadClosing(object sender, FormClosingEventArgs e)
        {
            // Stop the camera when closing the form
            StopCamera();
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Update the PictureBox with the new video frame
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
            }

            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }
    }
}
