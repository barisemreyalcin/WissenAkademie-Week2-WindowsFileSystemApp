namespace WindowsFileSystemApp
{
    public partial class Form1 : Form
    {
        // Bir diskteki datayý okumak veya diske yazý yazmak için yazacaðým içeriði önce bir belleðe çýkartmam gerekir. Bellekte iþlem yapabilmem için System.IO altýndaki FileStream:
        // FileStream sýnýfý ile diskte bulunan bir dosyaya eriþim saðlayabiliriz. StreamWriter ve StreamReader ile açýlan bir dosya üzerinde yazma ve okuma iþlemleri de yapabiliriz. Dosya üzerinde metin ya da byte tabanlý iþlemler yapýlabilir. Read() ve ReadByte() byte düzeyinde veri okumamýzý saðlayan metotlardýr. ReadByte() okuma yapamaz ise -1 döner.
        // Formumuzda ...'ya basýnca windows gezgini açýlacak


        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdFile.ShowDialog(); // windows gezgini açýlacak, bir button'a basmamýz halinde deðer gönderir.
            if (result == DialogResult.OK)
            {
                // týklanan file'ýn name'i alacaz
                txtFilePath.Text = ofdFile.FileName;
            }
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            #region With StreamWriter
            //// rich text box'ý kullanýcý dolduracak ve bu içeriði butona týklayarak yazacaðýz
            //StreamWriter strWrite = new StreamWriter(txtFilePath.Text);
            //strWrite.Write(rtxtFileContent.Text);

            //// Bellekteki bu iþlemi diske aktarabilmek için
            //strWrite.Close();
            ////strWriter.Flush();

            //rtxtFileContent.Clear();
            #endregion

            #region With FileStream StreamWriter
            // Bu kez path yerine sadece dosya adýný yazarsan otomatik uygulama dosyalarýnýn olduðu yerde oluþturacaktýr. Diðer yolda manuel olarak oluþturuyorduk 
            FileStream fs = new FileStream(txtFilePath.Text, FileMode.Create, FileAccess.Write);
            // Create yerine Append deseydik varolanýn üstüne yazardý
            StreamWriter strWrite = new StreamWriter(fs);
            strWrite.WriteLine(rtxtFileContent.Text);
            strWrite.Close();
            fs.Close();
            //fs = null;
            rtxtFileContent.Clear();
            #endregion
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            #region With StreamReader
            //StreamReader strRead = new StreamReader(txtFilePath.Text);
            //string str = strRead.ReadToEnd();
            //rtxtFileContent.Text = str;
            //strRead.Close();
            #endregion

            #region With FileStream StreamWriter
            FileStream fs = new FileStream(txtFilePath.Text, FileMode.Open, FileAccess.Read); // fs pointer
            StreamReader strRead = new StreamReader(fs);
            string strContent = strRead.ReadToEnd();
            rtxtFileContent.Text = strContent;
            strRead.Close();
            fs.Close();

            strRead = null; // garbage collecter onlarý silsin diye (Close da yeterli aslýnda)
            fs = null;
            #endregion
        }

        // ofd file filter kýsmý: Text File(*.txt)|*.txt|All Files(*.*)|*.*

        // Authorization: Yetkilendirme
        // Authentication: Doðrulama
    }
}
