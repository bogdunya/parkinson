using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parkinson
{
    public partial class Form2 : Form
    {
        int _timeOfSession;
        public Form2(int timeOfSession)
        {
            InitializeComponent();
            _timeOfSession = timeOfSession;
            timerProgressBar.Interval = 500; // 500 миллисекунд
            timerProgressBar.Enabled = true;
            timerProgressBar.Tick += timer1_Tick;
        }
        void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Maximum == progressBar1.Value)
            {
                timerHideProgressBar.Interval = 500;
                timerHideProgressBar.Enabled = true;
                timerHideProgressBar.Enabled = false;
                timerProgressBar.Enabled = false;
                progressBar1.Visible = false;
                label1.Visible = false;
                timerHideProgressBar.Enabled = false;
                label2.Visible = true;
                txtComm.Visible = true;
                saveSessionButton.Visible = true;
            }
            else
                progressBar1.PerformStep();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            txtComm.Visible = false;
            saveSessionButton.Visible = false;
        }

        private void saveSessionButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
