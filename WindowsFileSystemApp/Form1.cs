namespace WindowsFileSystemApp
{
    public partial class Form1 : Form
    {
        // Bir diskteki datay� okumak veya diske yaz� yazmak i�in yazaca��m i�eri�i �nce bir belle�e ��kartmam gerekir. Bellekte i�lem yapabilmem i�in System.IO alt�ndaki FileStream:
        // FileStream s�n�f� ile diskte bulunan bir dosyaya eri�im sa�layabiliriz. StreamWriter ve StreamReader ile a��lan bir dosya �zerinde yazma ve okuma i�lemleri de yapabiliriz. Dosya �zerinde metin ya da byte tabanl� i�lemler yap�labilir. Read() ve ReadByte() byte d�zeyinde veri okumam�z� sa�layan metotlard�r. ReadByte() okuma yapamaz ise -1 d�ner.
        // Formumuzda ...'ya bas�nca windows gezgini a��lacak


        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdFile.ShowDialog(); // windows gezgini a��lacak, bir button'a basmam�z halinde de�er g�nderir.
            if (result == DialogResult.OK)
            {
                // t�klanan file'�n name'i alacaz
                txtFilePath.Text = ofdFile.FileName;
            }
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            #region With StreamWriter
            //// rich text box'� kullan�c� dolduracak ve bu i�eri�i butona t�klayarak yazaca��z
            //StreamWriter strWrite = new StreamWriter(txtFilePath.Text);
            //strWrite.Write(rtxtFileContent.Text);

            //// Bellekteki bu i�lemi diske aktarabilmek i�in
            //strWrite.Close();
            ////strWriter.Flush();

            //rtxtFileContent.Clear();
            #endregion

            #region With FileStream StreamWriter
            // Bu kez path yerine sadece dosya ad�n� yazarsan otomatik uygulama dosyalar�n�n oldu�u yerde olu�turacakt�r. Di�er yolda manuel olarak olu�turuyorduk 
            FileStream fs = new FileStream(txtFilePath.Text, FileMode.Create, FileAccess.Write);
            // Create yerine Append deseydik varolan�n �st�ne yazard�
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

            strRead = null; // garbage collecter onlar� silsin diye (Close da yeterli asl�nda)
            fs = null;
            #endregion
        }

        // ofd file filter k�sm�: Text File(*.txt)|*.txt|All Files(*.*)|*.*

        // Authorization: Yetkilendirme
        // Authentication: Do�rulama
    }
}
