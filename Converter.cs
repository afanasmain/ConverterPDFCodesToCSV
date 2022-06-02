using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ImageMagick;
using DataMatrix.net;
using System.IO;

namespace ConverterPDFCodesToCSV
{
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
        }

        //Set path to PDF with GS1 codes
        private void ButtonSetInputFile_Click(object sender, EventArgs e)
        {            
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "PDF (*.pdf)|*.pdf";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get and show the path of specified file
                    FileInputPDFTextbox.Text = openFileDialog.FileName;
                }
            }

            //Count pages amount of PDF (should be one GS1 code per page)
            //TO DO: Throw exception if pages count != code count  
            using (var pages = new MagickImageCollection()) {
                var settings = new MagickReadSettings
                {
                    Width = 10,
                    Height = 10,
                    Density = new Density(50),
                    ColorSpace = ColorSpace.CMYK
                };
                pages.Read(FileInputPDFTextbox.Text, settings);
                
                PagesAmountLabel.Visible = true;
                PagesAmountCounter.Text = pages.Count.ToString();
                PagesAmountCounter.Visible = true;
            }

            //Set default path to output file
            FileOutputCSVTextbox.Text = FileInputPDFTextbox.Text.Substring(0, FileInputPDFTextbox.Text.Length - 4) + ".csv";
        }

        static void SaveToCSV(string sFileName, string[] TextCodes)
        {            
            using (var stream = File.Open(sFileName, FileMode.Create))
            using (var writer = new StreamWriter(stream))
            {
                foreach (string str in TextCodes)
                {
                    writer.WriteLine(str);
                }
            }
        }

        private void ButtonProcess_Click(object sender, EventArgs e)
        {            
            //Read pages from PDF
            //TO DO: Break the recognition if there is no GS1 codes
            var settings = new MagickReadSettings
            {
                Width = 300,
                Height = 300,
                Density = new Density(200),
                ColorSpace = ColorSpace.CMYK
            };
            var images = new MagickImageCollection();
            images.Read(FileInputPDFTextbox.Text, settings);

            ConvertationProgressBar.Minimum = 0;
            ConvertationProgressBar.Value = 0;
            ConvertationProgressBar.Maximum = images.Count;

            CodesAmountResultLabel.Visible = true;
            CodesAmountResultCounter.Text = "0";
            CodesAmountResultCounter.Visible = true;

            //Recognize and decode GS1 codes
            Bitmap oBitmap = images.ToBitmap();
            DmtxImageDecoder decoder = new DmtxImageDecoder();
            string[] lines = new string[images.Count];
            
            for (int i = 0; i < images.Count; i++)
            {                
                oBitmap = images[i].ToBitmap();
                List<string> oList = decoder.DecodeImage(oBitmap);

                StringBuilder sb = new StringBuilder();
                sb.Length = 0;

                foreach (string s in oList)
                {
                    sb.Append(s);
                }

                if (sb.ToString() != "")
                { 
                    lines[i] = sb.ToString();
                    CodesAmountResultCounter.Text = (i + 1).ToString();
                }
                ConvertationProgressBar.PerformStep();
                this.Refresh();
            }

            SaveToCSV(FileOutputCSVTextbox.Text, lines);
            images.Dispose();
        }

        //Set path to CSV with decoded codes
        private void ButtonSetOutputFile_Click(object sender, EventArgs e)
        {            
            SaveFileDialog saveSCVFileDialog = new SaveFileDialog();

            saveSCVFileDialog.Filter = "CSV (*.csv)|*.csv";
            saveSCVFileDialog.FilterIndex = 2;
            saveSCVFileDialog.RestoreDirectory = true;

            if (saveSCVFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileOutputCSVTextbox.Text = saveSCVFileDialog.FileName;
            }
        }
    }
}
