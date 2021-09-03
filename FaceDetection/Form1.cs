using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Diagnostics;
using Tesseract;
namespace FaceDetection
{
    public partial class Form1 : Form
    {
                    
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_default.xml");
        public string FolderPath;
        public int failCountG = 0;
        public int successCountG = 0;
        public Form1()
        {
            InitializeComponent();
        }
        Stopwatch watch = new Stopwatch();
        


        private void folderButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if(result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    FolderPath = fbd.SelectedPath;
                    folderBox.Text = fbd.SelectedPath;
                }
            }
        }

        private void idButton_Click(object sender, EventArgs e)
        {
            var Photos2 = GatherPhotos();

            if(string.IsNullOrWhiteSpace(FolderPath))
            {
                MessageBox.Show("You must select a folder first.");
            }
            for (var i = 0; i < Photos2.Count; i++)
            {
                ProcessId(Photos2[i]);
            }
        }

        private void faceButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FolderPath))
            {
                MessageBox.Show("You must select a folder first.");
            }
            var Photos = GatherPhotos();
            if(Photos == null)
            {
                return;
            }
            for (var i = 0; i < Photos.Count; i++)
            {
                ProcessPhoto(Photos[i]);
            }
        }

        private void ProcessPhoto(String photopath)
        {

                
                Bitmap img = new Bitmap(Image.FromFile(photopath));
                BitmapData bitmapData = img.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadOnly, img.PixelFormat);
                img.UnlockBits(bitmapData);
                
                Image<Bgr, byte> grayImage = new Image<Bgr, byte>(img);
                Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(image: grayImage, scaleFactor: 1.2, minNeighbors: 1);
                if (rectangles.Count().ToString() == "0")
                {

                    failCountG += 1;
                    UpdateLabels(failCountG.ToString(), false);
                    img = ResizeBitmap(img, 50, 50);
                    Clipboard.SetDataObject(img);
 
                    DataFormats.Format image = DataFormats.GetFormat(DataFormats.Bitmap);
                    logBox.Paste(image);
                
                }
                else
                {
                    successCountG += 1;
                    double rectanglesWidth = (rectangles[0].Width * rectangles[0].Height);

                    Console.WriteLine(rectanglesWidth.ToString());
                    double imageWidth = img.Width * img.Height;
                    Console.WriteLine(imageWidth.ToString());
                    double calc = (rectanglesWidth / imageWidth) * 100;
                    Console.WriteLine(calc.ToString());
                    UpdateLabels(successCountG.ToString(), true);
                }
                listBox1.Items.Add(img.Width+img.Height);


        }
        private void ProcessId(String photopath)
        {

            Bitmap img = new Bitmap(Image.FromFile(photopath));
            var ocr = new TesseractEngine("./tessdata","eng");
            var result = ocr.Process(img);
            richTextBox1.Text = result.GetText();
        }

        private Bitmap ResizeBitmap(Bitmap sourceBMP, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.DrawImage(sourceBMP, 0, 0, width, height);
            }
            return result;
        }

        private void UpdateLabels(String number, Boolean success)
        {
            if (success)
            {
                successCount.Text = number;

            } else
            {
                failCount.Text = number;
            }

        }
        private List<string> GatherPhotos()
        {
            try
            {
                var files = Directory.GetFiles(@"" + FolderPath, "*.*", SearchOption.TopDirectoryOnly);
                List<string> imageFiles = new List<string>();
                foreach (string filename in files)
                {
                    if (Regex.IsMatch(filename, @"\.jpg$|\.jpeg$"))
                    {
                        imageFiles.Add(filename);
                    }
                }
                return imageFiles;
            } 
            catch
            {
                return null;
            }
        }
        private void Append(String text)
        {
            logBox.Text += "\n" + text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
   

    
}

