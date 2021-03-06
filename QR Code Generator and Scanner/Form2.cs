using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;


namespace QR_Code_Generator_and_Scanner
{
    public partial class FormQRCode : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        public FormQRCode()
        {
            InitializeComponent();

            FilterInfoCollection filterInfoCollection;
            VideoCaptureDevice captureDevice;
        }

        private void FormQRCode_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
                comboBoxDevice.Items.Add(Device.Name);

            comboBoxDevice.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBoxDevice.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(CaptureDevice_NewFrame);
            FinalFrame.Start();
            timer.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBoxCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (pictureBoxCamera.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)pictureBoxCamera.Image);
                if (result != null)
                {
                    textBoxIdentification.Text = result.ToString();
                    timer.Stop();
                    if (FinalFrame.IsRunning)
                        FinalFrame.Stop();
                }
            }
        }

        private void FormQRCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning)
                FinalFrame.Stop();
        }
    }
}
