using Hotel_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            Pbar.Value = 0;
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Pbar_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Pbar.Value += 10;
            if (Pbar.Value == 100)
            {
                timer1.Enabled = false;
                this.Hide();
                // Replace Form with your main form type
                MainForm mainForm = new MainForm();

                mainForm.ShowDialog();

            }


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}