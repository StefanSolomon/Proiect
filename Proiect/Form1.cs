﻿using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Emgu.CV.Image<Bgr, Byte> My_Image;

        private void buttonGrayScale_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> gray_image = My_Image.Convert<Gray, byte>();
            grayPictureBox.Image = gray_image.AsBitmap();
            gray_image[0, 0] = new Gray(200);
        }

        private void choosePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                My_Image = new Image<Bgr, byte>(Openfile.FileName);
                pictureBoxChoose.Image = My_Image.ToBitmap();
            }
        }

        private void Contrast_Click(object sender, EventArgs e)
        {
            double alpha = Convert.ToDouble(textBoxContrast.Text);
            int beta = Convert.ToInt32(textBoxContrast1.Text);

            pictureBoxContrast.Image = My_Image.Mul(alpha + beta).AsBitmap();
        }

        private void buttonGamma_Click(object sender, EventArgs e)
        {
            My_Image._GammaCorrect (Convert.ToDouble(textBoxGamma.Text));
            pictureBoxGamma.Image = My_Image.AsBitmap();
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            Image<Bgr, Byte> outputImage = new Image<Bgr, byte>(My_Image.Size);
            My_Image.CopyTo(outputImage);
            var data = outputImage.Data;
            for (int i = 0; i < outputImage.Width; i++)
            {
                for (int j = 0; j < outputImage.Height; j++)
                {
                    data[j, i, 0] = 0;
                    data[j, i, 1] = 0;
                }
            }
            pictureBoxRed.Image = outputImage.AsBitmap();
        }

        private void buttonScale_Click(object sender, EventArgs e)
        {
            float timesZoom = 0.6F;
            pictureBoxScale.Image=My_Image.Resize(timesZoom,Emgu.CV.CvEnum.Inter.Cubic ).AsBitmap();
        }
    }
}