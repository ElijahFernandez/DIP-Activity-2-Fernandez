using System.Windows.Forms;

namespace DigitalImageProcessing
{
    public partial class Form1 : Form
    {
        DeviceManager devicemanager;
        Device device;
        Bitmap loadImage, resultImage;
        Bitmap imageB, imageA, resultGreen;
        public Form1()
        {
            InitializeComponent();
            devicemanager = new DeviceManager();
            device = new Device();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            resultSubtractImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // Load Image
        private void loadImageButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }

        // clicking OK in FileDialog1
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            loadImage = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loadImage;
        }


        private void saveImageButton_Click(object sender, EventArgs e)
        {
            resultImage.Save(saveFileDialog1.FileName);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void basicCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            Color pixel;
            for (int i = 0; i < loadImage.Width; i++)
            {
                for (int j = 0; j < loadImage.Height; j++)
                {
                    pixel = loadImage.GetPixel(i, j);
                    resultImage.SetPixel(i, j, pixel);
                }
                pictureBox2.Image = resultImage;
            }
        }

        private void grayScalingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            Color pixel;
            int gray;

            for (int i = 0; i < loadImage.Width; i++)
            {
                for (int j = 0; j < loadImage.Height; j++)
                {
                    pixel = loadImage.GetPixel(i, j);
                    resultImage.SetPixel(i, j, pixel);
                    gray = (pixel.R + pixel.G + pixel.B) / 3;
                    resultImage.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
                pictureBox2.Image = resultImage;
            }
        }

        private void rotateImageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rotateXAndYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            Color pixel;
            for (int i = 0; i < loadImage.Width; i++)
            {
                for (int j = 0; j < loadImage.Height; j++)
                {
                    pixel = loadImage.GetPixel(i, j);
                    resultImage.SetPixel(loadImage.Width - 1 - i, loadImage.Height - 1 - j, pixel);
                }
                pictureBox2.Image = resultImage;
            }
        }

        private void rotateXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            Color pixel;
            for (int i = 0; i < loadImage.Width; i++)
            {
                for (int j = 0; j < loadImage.Height; j++)
                {
                    pixel = loadImage.GetPixel(i, j);
                    resultImage.SetPixel(loadImage.Width - 1 - i, j, pixel);
                }
                pictureBox2.Image = resultImage;
            }
        }

        private void rotateYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            Color pixel;
            for (int i = 0; i < loadImage.Width; i++)
            {
                for (int j = 0; j < loadImage.Height; j++)
                {
                    pixel = loadImage.GetPixel(i, j);
                    resultImage.SetPixel(i, loadImage.Height - 1 - j, pixel);
                }
                pictureBox2.Image = resultImage;
            }
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void invertColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            Color pixel;
            int invert1, invert2, invert3;

            for (int i = 0; i < loadImage.Width; i++)
            {
                for (int j = 0; j < loadImage.Height; j++)
                {
                    pixel = loadImage.GetPixel(i, j);
                    resultImage.SetPixel(i, j, pixel);
                    invert1 = 255 - pixel.R;
                    invert2 = 255 - pixel.G;
                    invert3 = 255 - pixel.B;
                    resultImage.SetPixel(i, j, Color.FromArgb(invert1, invert2, invert3));
                }
                pictureBox2.Image = resultImage;
            }
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            Color pixel;
            int gray;

            for (int i = 0; i < loadImage.Width; i++)
            {
                for (int j = 0; j < loadImage.Height; j++)
                {
                    pixel = loadImage.GetPixel(i, j);
                    resultImage.SetPixel(i, j, pixel);
                    gray = (pixel.R + pixel.G + pixel.B) / 3;
                    resultImage.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }
            Color sample;
            int[] histdata = new int[256];
            for (int i = 0; i < loadImage.Width; i++)

                for (int j = 0; j < loadImage.Height; j++)
                {
                    sample = resultImage.GetPixel(i, j);
                    histdata[sample.R]++;
                }
            Bitmap mydata = new Bitmap(256, 800);

            for (int i = 0; i < 256; i++)
                for (int j = 0; j < 800; j++)
                {
                    mydata.SetPixel(i, j, Color.White);
                }
            //plot histdata
            for (int i = 0; i < 256; i++)
                for (int j = 0; j < Math.Min(histdata[i] / 5, 800); j++)
                {
                    mydata.SetPixel(i, 799 - j, Color.Black);
                }
            pictureBox2.Image = mydata;
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadImage.Width, loadImage.Height);
            Color pixel;
            int gray;

            for (int x = 0; x < loadImage.Width; x++)
            {
                for (int y = 0; y < loadImage.Height; y++)
                {
                    pixel = loadImage.GetPixel(x, y);

                    int a = pixel.A;
                    int r = pixel.R;
                    int g = pixel.G;
                    int b = pixel.B;

                    int tr = (int)(0.393 * r + 0.769 * g + 0.189 * b);
                    int tg = (int)(0.349 * r + 0.686 * g + 0.168 * b);
                    int tb = (int)(0.272 * r + 0.534 * g + 0.131 * b);

                    if (tr > 255)
                    {
                        r = 255;
                    }
                    else
                    {
                        r = tr;
                    }
                    if (tg > 255)
                    {
                        g = 255;
                    }
                    else
                    {
                        g = tg;
                    }
                    if (tb > 255)
                    {
                        b = 255;
                    }
                    else
                    {
                        b = tb;
                    }

                    resultImage.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
                pictureBox2.Image = resultImage;
            }
        }

        private void loadImageB_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();

        }

        private void openFileDialog2_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            imageB = new Bitmap(openFileDialog2.FileName);
            pictureBox1.Image = imageB;
        }

        private void loadBackground_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
        }

        private void openFileDialog3_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            imageA = new Bitmap(openFileDialog3.FileName);
            pictureBox2.Image = imageA;
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            Color mygreen = Color.FromArgb(0, 0, 255);
            int greygreen = (mygreen.R + mygreen.G + mygreen.B) / 3;
            int threshold = 5;

            resultGreen = new Bitmap(imageB.Width, imageB.Height);

            for (int i = 0; i < imageB.Width; i++)
            {
                for (int j = 0; j < imageB.Height; j++)
                {
                    Color pixel = imageB.GetPixel(i, j);
                    Color bgPixel = imageA.GetPixel(i, j);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int subtractValue = Math.Abs(grey - greygreen);
                    if (subtractValue < threshold)
                    {
                        resultGreen.SetPixel(i, j, bgPixel);
                    }
                    else
                    {
                        resultGreen.SetPixel(i, j, pixel);
                    }
                }
            }
            resultSubtractImage.Image = resultGreen;
        }

        private void resultSubtractImage_Click(object sender, EventArgs e)
        {

        }

        private void openCamera_Click(object sender, EventArgs e)
        {
            device.ShowWindow(pictureBox3);
        }
    }
}