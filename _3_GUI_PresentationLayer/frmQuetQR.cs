using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace _3_GUI_PresentationLayer
{
    public partial class frmQuetQR : Form
    {
        private FilterInfoCollection _filterInfoCollection;
        private VideoCaptureDevice _videoCaptureDevice;

        public delegate void SendQR(string text);

        public SendQR sendQr;
        public string getmaQR()
        {
            return txt_maQR.Text;
        }
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        public frmQuetQR()
        {
            InitializeComponent();
        }
        private void frmQuetQR_Load(object sender, EventArgs e)
        {
            _filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in _filterInfoCollection)
            {
                cbx_Camera.Items.Add(Device.Name);
                cbx_Camera.SelectedIndex = 0;
                _videoCaptureDevice = new VideoCaptureDevice();
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            _videoCaptureDevice = new VideoCaptureDevice(_filterInfoCollection[cbx_Camera.SelectedIndex].MonikerString);
            _videoCaptureDevice.NewFrame += FinalFrame_NewFrame;
            _videoCaptureDevice.Start();
        }

        private void frmQuetQR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_videoCaptureDevice.IsRunning == true)
            {
                _videoCaptureDevice = new VideoCaptureDevice();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)pictureBox1.Image);
            if (result != null)
            {
                txt_maQR.Text = result.ToString();
            }
        }
        private void btn_Decode_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_maQR_TextChanged(object sender, EventArgs e)
        {
            sendQr(txt_maQR.Text);
        }
    }
}
