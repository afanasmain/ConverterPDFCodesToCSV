
namespace ConverterPDFCodesToCSV
{
    partial class Converter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonSetInputFile = new System.Windows.Forms.Button();
            this.PDFLabel = new System.Windows.Forms.Label();
            this.FileInputPDFTextbox = new System.Windows.Forms.TextBox();
            this.CSVLabel = new System.Windows.Forms.Label();
            this.FileOutputCSVTextbox = new System.Windows.Forms.TextBox();
            this.ButtonSetOutputFile = new System.Windows.Forms.Button();
            this.ConvertationProgressBar = new System.Windows.Forms.ProgressBar();
            this.PagesAmountLabel = new System.Windows.Forms.Label();
            this.ButtonProcess = new System.Windows.Forms.Button();
            this.CodesAmountResultLabel = new System.Windows.Forms.Label();
            this.PagesAmountCounter = new System.Windows.Forms.Label();
            this.CodesAmountResultCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonSetInputFile
            // 
            this.ButtonSetInputFile.Location = new System.Drawing.Point(306, 25);
            this.ButtonSetInputFile.Name = "ButtonSetInputFile";
            this.ButtonSetInputFile.Size = new System.Drawing.Size(75, 21);
            this.ButtonSetInputFile.TabIndex = 0;
            this.ButtonSetInputFile.Text = "Открыть";
            this.ButtonSetInputFile.UseVisualStyleBackColor = true;
            this.ButtonSetInputFile.Click += new System.EventHandler(this.ButtonSetInputFile_Click);
            // 
            // PDFLabel
            // 
            this.PDFLabel.AutoSize = true;
            this.PDFLabel.Location = new System.Drawing.Point(12, 9);
            this.PDFLabel.Name = "PDFLabel";
            this.PDFLabel.Size = new System.Drawing.Size(148, 13);
            this.PDFLabel.TabIndex = 1;
            this.PDFLabel.Text = "Путь к PDF-файлу с кодами";
            // 
            // FileInputPDF
            // 
            this.FileInputPDFTextbox.Location = new System.Drawing.Point(15, 26);
            this.FileInputPDFTextbox.Name = "FileInputPDF";
            this.FileInputPDFTextbox.Size = new System.Drawing.Size(285, 20);
            this.FileInputPDFTextbox.TabIndex = 2;
            // 
            // CSVLabel
            // 
            this.CSVLabel.AutoSize = true;
            this.CSVLabel.Location = new System.Drawing.Point(15, 53);
            this.CSVLabel.Name = "CSVLabel";
            this.CSVLabel.Size = new System.Drawing.Size(137, 13);
            this.CSVLabel.TabIndex = 3;
            this.CSVLabel.Text = "CSV-Файл с результатом";
            // 
            // FileOutputCSV
            // 
            this.FileOutputCSVTextbox.Location = new System.Drawing.Point(15, 70);
            this.FileOutputCSVTextbox.Name = "FileOutputCSV";
            this.FileOutputCSVTextbox.Size = new System.Drawing.Size(285, 20);
            this.FileOutputCSVTextbox.TabIndex = 4;
            // 
            // ButtonSetOutputFile
            // 
            this.ButtonSetOutputFile.Location = new System.Drawing.Point(306, 69);
            this.ButtonSetOutputFile.Name = "ButtonSetOutputFile";
            this.ButtonSetOutputFile.Size = new System.Drawing.Size(75, 21);
            this.ButtonSetOutputFile.TabIndex = 5;
            this.ButtonSetOutputFile.Text = "Открыть";
            this.ButtonSetOutputFile.UseVisualStyleBackColor = true;
            this.ButtonSetOutputFile.Click += new System.EventHandler(this.ButtonSetOutputFile_Click);
            // 
            // ConvertationProgressBar
            // 
            this.ConvertationProgressBar.Location = new System.Drawing.Point(15, 113);
            this.ConvertationProgressBar.Name = "ConvertationProgressBar";
            this.ConvertationProgressBar.Size = new System.Drawing.Size(523, 23);
            this.ConvertationProgressBar.Step = 1;
            this.ConvertationProgressBar.TabIndex = 6;
            // 
            // PagesAmountLabel
            // 
            this.PagesAmountLabel.AutoSize = true;
            this.PagesAmountLabel.Location = new System.Drawing.Point(387, 29);
            this.PagesAmountLabel.Name = "PagesAmountLabel";
            this.PagesAmountLabel.Size = new System.Drawing.Size(121, 13);
            this.PagesAmountLabel.TabIndex = 7;
            this.PagesAmountLabel.Text = "Страниц в документе: ";
            this.PagesAmountLabel.Visible = false;
            // 
            // ButtonProcess
            // 
            this.ButtonProcess.Location = new System.Drawing.Point(398, 69);
            this.ButtonProcess.Name = "ButtonProcess";
            this.ButtonProcess.Size = new System.Drawing.Size(104, 20);
            this.ButtonProcess.TabIndex = 8;
            this.ButtonProcess.Text = "Распознать";
            this.ButtonProcess.UseVisualStyleBackColor = true;
            this.ButtonProcess.Click += new System.EventHandler(this.ButtonProcess_Click);
            // 
            // CodesAmountResultLabel
            // 
            this.CodesAmountResultLabel.AutoSize = true;
            this.CodesAmountResultLabel.Location = new System.Drawing.Point(12, 97);
            this.CodesAmountResultLabel.Name = "CodesAmountResultLabel";
            this.CodesAmountResultLabel.Size = new System.Drawing.Size(107, 13);
            this.CodesAmountResultLabel.TabIndex = 9;
            this.CodesAmountResultLabel.Text = "Распознано кодов: ";
            this.CodesAmountResultLabel.Visible = false;
            // 
            // PagesAmountCounter
            // 
            this.PagesAmountCounter.AutoSize = true;
            this.PagesAmountCounter.Location = new System.Drawing.Point(503, 29);
            this.PagesAmountCounter.Name = "PagesAmountCounter";
            this.PagesAmountCounter.Size = new System.Drawing.Size(31, 13);
            this.PagesAmountCounter.TabIndex = 10;
            this.PagesAmountCounter.Text = "NNN";
            this.PagesAmountCounter.Visible = false;
            // 
            // CodesAmountResultCounter
            // 
            this.CodesAmountResultCounter.AutoSize = true;
            this.CodesAmountResultCounter.Location = new System.Drawing.Point(117, 97);
            this.CodesAmountResultCounter.Name = "CodesAmountResultCounter";
            this.CodesAmountResultCounter.Size = new System.Drawing.Size(31, 13);
            this.CodesAmountResultCounter.TabIndex = 11;
            this.CodesAmountResultCounter.Text = "NNN";
            this.CodesAmountResultCounter.Visible = false;
            // 
            // Converter
            // 
            this.ClientSize = new System.Drawing.Size(550, 147);
            this.Controls.Add(this.CodesAmountResultCounter);
            this.Controls.Add(this.PagesAmountCounter);
            this.Controls.Add(this.CodesAmountResultLabel);
            this.Controls.Add(this.ButtonProcess);
            this.Controls.Add(this.PagesAmountLabel);
            this.Controls.Add(this.ConvertationProgressBar);
            this.Controls.Add(this.ButtonSetOutputFile);
            this.Controls.Add(this.FileOutputCSVTextbox);
            this.Controls.Add(this.CSVLabel);
            this.Controls.Add(this.FileInputPDFTextbox);
            this.Controls.Add(this.PDFLabel);
            this.Controls.Add(this.ButtonSetInputFile);
            this.Name = "Converter";
            this.Text = "PDFtoCSV Convert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSetInputFile;
        private System.Windows.Forms.Label PDFLabel;
        private System.Windows.Forms.TextBox FileInputPDFTextbox;
        private System.Windows.Forms.Label CSVLabel;
        private System.Windows.Forms.TextBox FileOutputCSVTextbox;
        private System.Windows.Forms.Button ButtonSetOutputFile;
        private System.Windows.Forms.ProgressBar ConvertationProgressBar;
        private System.Windows.Forms.Label PagesAmountLabel;
        private System.Windows.Forms.Button ButtonProcess;
        private System.Windows.Forms.Label CodesAmountResultLabel;
        private System.Windows.Forms.Label PagesAmountCounter;
        private System.Windows.Forms.Label CodesAmountResultCounter;
    }
}

