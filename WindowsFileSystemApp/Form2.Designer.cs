namespace WindowsFileSystemApp
{
    partial class Form2
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
            grpDataEntry = new GroupBox();
            btnRegister = new Button();
            btnClear = new Button();
            txtAge = new TextBox();
            txtSurname = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            grpReadData = new GroupBox();
            btnReadData = new Button();
            lvPeople = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            grpDataEntry.SuspendLayout();
            grpReadData.SuspendLayout();
            SuspendLayout();
            // 
            // grpDataEntry
            // 
            grpDataEntry.Controls.Add(btnRegister);
            grpDataEntry.Controls.Add(btnClear);
            grpDataEntry.Controls.Add(txtAge);
            grpDataEntry.Controls.Add(txtSurname);
            grpDataEntry.Controls.Add(txtName);
            grpDataEntry.Controls.Add(label3);
            grpDataEntry.Controls.Add(label1);
            grpDataEntry.Controls.Add(label2);
            grpDataEntry.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpDataEntry.Location = new Point(0, 0);
            grpDataEntry.Name = "grpDataEntry";
            grpDataEntry.Size = new Size(430, 232);
            grpDataEntry.TabIndex = 0;
            grpDataEntry.TabStop = false;
            grpDataEntry.Text = "Data Entry";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 9F);
            btnRegister.Location = new Point(312, 189);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F);
            btnClear.Location = new Point(200, 189);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 9F);
            txtAge.Location = new Point(105, 144);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(301, 27);
            txtAge.TabIndex = 5;
            // 
            // txtSurname
            // 
            txtSurname.Font = new Font("Segoe UI", 9F);
            txtSurname.Location = new Point(105, 103);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(301, 27);
            txtSurname.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9F);
            txtName.Location = new Point(105, 61);
            txtName.Name = "txtName";
            txtName.Size = new Size(301, 27);
            txtName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(12, 147);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 3;
            label3.Text = "Age";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(12, 61);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 2;
            label2.Text = "Surname";
            // 
            // grpReadData
            // 
            grpReadData.Controls.Add(btnReadData);
            grpReadData.Controls.Add(lvPeople);
            grpReadData.Location = new Point(0, 238);
            grpReadData.Name = "grpReadData";
            grpReadData.Size = new Size(430, 265);
            grpReadData.TabIndex = 1;
            grpReadData.TabStop = false;
            grpReadData.Text = "Read Data From File";
            // 
            // btnReadData
            // 
            btnReadData.Location = new Point(12, 26);
            btnReadData.Name = "btnReadData";
            btnReadData.Size = new Size(94, 29);
            btnReadData.TabIndex = 1;
            btnReadData.Text = "Read Data";
            btnReadData.UseVisualStyleBackColor = true;
            // 
            // lvPeople
            // 
            lvPeople.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvPeople.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lvPeople.GridLines = true;
            lvPeople.Location = new Point(12, 61);
            lvPeople.Name = "lvPeople";
            lvPeople.Size = new Size(407, 190);
            lvPeople.TabIndex = 0;
            lvPeople.UseCompatibleStateImageBehavior = false;
            lvPeople.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Full Name";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Age";
            columnHeader2.Width = 100;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 501);
            Controls.Add(grpReadData);
            Controls.Add(grpDataEntry);
            Name = "Form2";
            Text = "Form2";
            grpDataEntry.ResumeLayout(false);
            grpDataEntry.PerformLayout();
            grpReadData.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDataEntry;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox txtAge;
        private TextBox txtSurname;
        private TextBox txtName;
        private Button btnRegister;
        private Button btnClear;
        private GroupBox grpReadData;
        private ListView lvPeople;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button btnReadData;
    }
}