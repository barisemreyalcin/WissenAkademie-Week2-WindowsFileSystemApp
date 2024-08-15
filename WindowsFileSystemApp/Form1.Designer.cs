namespace WindowsFileSystemApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSelectFile = new Button();
            txtFilePath = new TextBox();
            btnWriteFile = new Button();
            btnReadFile = new Button();
            rtxtFileContent = new RichTextBox();
            ofdFile = new OpenFileDialog();
            SuspendLayout();
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(505, 11);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(40, 29);
            btnSelectFile.TabIndex = 0;
            btnSelectFile.Text = "...";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(12, 12);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(487, 27);
            txtFilePath.TabIndex = 1;
            // 
            // btnWriteFile
            // 
            btnWriteFile.Location = new Point(12, 54);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(108, 29);
            btnWriteFile.TabIndex = 2;
            btnWriteFile.Text = "Write to file";
            btnWriteFile.UseVisualStyleBackColor = true;
            btnWriteFile.Click += btnWriteFile_Click;
            // 
            // btnReadFile
            // 
            btnReadFile.Location = new Point(126, 54);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(119, 29);
            btnReadFile.TabIndex = 3;
            btnReadFile.Text = "Read from file";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // rtxtFileContent
            // 
            rtxtFileContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtxtFileContent.Location = new Point(15, 103);
            rtxtFileContent.Name = "rtxtFileContent";
            rtxtFileContent.Size = new Size(524, 255);
            rtxtFileContent.TabIndex = 4;
            rtxtFileContent.Text = "";
            // 
            // ofdFile
            // 
            ofdFile.FileName = "openFileDialog1";
            ofdFile.Filter = "Text File(*.txt)|*.txt|All Files(*.*)|*.*";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 370);
            Controls.Add(rtxtFileContent);
            Controls.Add(btnReadFile);
            Controls.Add(btnWriteFile);
            Controls.Add(txtFilePath);
            Controls.Add(btnSelectFile);
            Name = "Form1";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectFile;
        private TextBox txtFilePath;
        private Button btnWriteFile;
        private Button btnReadFile;
        private RichTextBox rtxtFileContent;
        private OpenFileDialog ofdFile;
    }
}
