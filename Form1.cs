using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessingInit
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

        private void button2_Click(object sender, EventArgs e)
        {

            Bitmap copy = new Bitmap((Bitmap)this.originalImage.Image);
            Processing.ConvertToGrayScale(copy);
            this.grayImage.Image = copy;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = "Image file (*.bmp, *.jpg)|*.bmp;*.jpg";
            if (DialogResult.OK == ofile.ShowDialog())
            {
                this.originalImage.Image = new Bitmap(ofile.FileName);
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.originalImage.Image);
            if (Processing.ConvertImageToHex(copy))
            {
                Console.WriteLine("It happened"); 
            }
        
        }
    }
}
