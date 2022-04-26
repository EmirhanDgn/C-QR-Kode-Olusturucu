using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronBarCode;

namespace QR_Kod_Olusturucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnQRKodOlustur_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator QR=new QRCoder.QRCodeGenerator();
            var myQr = QR.CreateQrCode(txtQrKodMetini.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(myQr);
            pictureBox1.Image = code.GetGraphic(50);
            btnQrKaydet.Visible= true;
        }

        private void btnQrKaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydetresim = new SaveFileDialog();
            kaydetresim.Filter = "";
            kaydetresim.FileName = "";
            kaydetresim.Title = "Başlık";
            DialogResult kayit = kaydetresim.ShowDialog();

            if (kayit == DialogResult.OK)
            {

                pictureBox1.Image.Save(kaydetresim.FileName);
            }
        }
    }
}
