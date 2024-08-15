using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFileSystemApp
{
    public partial class Form2 : Form
    {
        const string path = @"C:\AppContent\"; // Bunu oluştur
        const string filePeople = "People.txt"; // Bunu kendi oluşturur


        public Form2()
        {
            InitializeComponent();

            // Buradda yazdığım constructorda yani runtime sırasında direkt çalışır.
            // Bu eventleri designer'a bırakmadım bu kez kendim oluşturdum.
            btnRegister.Click += Register;
            btnClear.Click += Clear; // Bu nesnenin bu eventinde bu method çalışsın
            btnReadData.Click += ReadData;
        }

        private void ReadData(object? sender, EventArgs e)
        {
            string fullPath = string.Concat(path, filePeople);

            using (StreamReader strRead = new StreamReader(fullPath))
            {
                PrintList(strRead);
            }
        }

        private void PrintList(StreamReader strRead)
        {
            if (strRead != null)
            {
                lvPeople.Items.Clear(); // Önce sileyim ki üst üste data binmesin (sıfırdan yükleyeceğim için)
                string line = strRead.ReadLine();

                while (line != null)
                {
                    AddLine(line);
                    line = strRead.ReadLine(); // satır null olmadığı sürece method'a line'ı göndeririz
                }
            }
        }

        private void AddLine(string line)
        {
            string[] lineValues = line.Split(':');

            int index = lvPeople.Items.Count; // Kaç adet line var ve kaçıncı satıra ekleyeyim diye

            lvPeople.Items.Add(lineValues[0]); // Hem satıra hem ilk kolonun değerine ekliyordu. 
            lvPeople.Items[index].SubItems.Add(lineValues[1].ToString()); // Geri kalanlar subitem diye geçer
        }

        private void Clear(object? sender, EventArgs e)
        {
            ClearForm();
        }

        private void Register(object? sender, EventArgs e)
        {
            string name = string.Empty;
            string surname = string.Empty;
            int age;

            string line = string.Empty;
            string fullPath = string.Concat(path, filePeople); // C:\AppContent\People.txt olacak

            name = txtName.Text;
            surname = txtSurname.Text;
            age = int.Parse(txtAge.Text);

            line = $"{name} {surname}: {age}";

            // using => değişkenleri bellekten temizlemek için bir scope tanımlıyor ve null ataması yapmama gerek kalmıyor. Buradaki true yeni satırın append olması için.
            using (StreamWriter strWrite = new StreamWriter(fullPath, true))
            {
                strWrite.WriteLine(line);
                strWrite.Close();
            }
            ClearForm();
        }

        private void ClearForm()
        {
            foreach (Control cntrl in grpDataEntry.Controls)
            {
                if (cntrl.GetType() == typeof(TextBox))
                {
                    TextBox tb = (TextBox)cntrl;
                    tb.Clear();
                }
            }
            txtName.Focus();
        }
    }
}
