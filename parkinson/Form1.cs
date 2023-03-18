using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace parkinson
{
    public partial class Form1 : Form
    {
        string snils;
        private readonly ListBox.ObjectCollection _originalListCollection;

        public Form1()
        {
            InitializeComponent();
            _originalListCollection = patientsBrowser.Items;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rdFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSavePatient_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Файл, из которого считываем строки
            string pathToFile = @"F:\myProjects\parkinson\patients.txt";
            // Считываем строки в массив
            string[] allLines = File.ReadAllLines(pathToFile, Encoding.GetEncoding(1251));
            // Добавляем каждую строку
            foreach (string line in allLines)
                patientsBrowser.Items.Add(line);

            numericUpDown1.Value = 60;
            // Или красивее: lb.Items.AddRange(allLines);
        }

        private void BeginButton_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2((int)numericUpDown1.Value);
            newForm.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void patientBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            string[] m = patientsBrowser.Items[patientsBrowser.SelectedIndex].ToString().Split('\n');
            txtSnils.Text = m[0];

        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            string path = @"F:\myProjects\parkinson\patients.txt";
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(snils);
            }
            patientsBrowser.DataSource = null;
            patientsBrowser.Items.Clear();

            // Файл, из которого считываем строки
            string pathToFile = @"F:\myProjects\parkinson\patients.txt";
            // Считываем строки в массив
            string[] allLines = File.ReadAllLines(pathToFile, Encoding.GetEncoding(1251));
            // Добавляем каждую строку
            foreach (string line in allLines)
                patientsBrowser.Items.Add(line);


        }

        private void addPatient(string snils)
        {
          //patients.Add(new Patient { Snils=snils});
        }

        private void txtSnils_TextChanged(object sender, EventArgs e)
        {
            snils = txtSnils.Text;
        }

        private void txtSearchSnils_TextChanged(object sender, EventArgs e)
        {

            /*
            patientsBrowser.SelectionMode = SelectionMode.MultiSimple;
            for (int i = 0; i < patientsBrowser.Items.Count; i++)
            {
                if (patientsBrowser.Items[i].ToString().Contains(patientsBrowser.Text))
                {
                    patientsBrowser.SelectedIndex = i;
                }

                if (!patientsBrowser.Items[i].ToString().Contains(patientsBrowser.Text))
                {
                    patientsBrowser.Items.RemoveAt(i--);
                }

            }
            */
        }

        private void txtSearchSnils_KeyUp(object sender, KeyEventArgs e)
        {
            var matching = (from object i in _originalListCollection where i.ToString().Contains(txtSearchSnils.Text) select i).ToList();
            patientsBrowser.DataSource = matching;
        }
    }
}

class Patient
{
    public int PeopleID { get; set; }
    public string Snils { get; set; }
    public Nullable<System.DateTime> BirthDay { get; set; }
    public byte[] ProfileImage { get; set; }
    public string Sex { get; set; }

}
