using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChrisPainter_BirthdayGiftPlanner
{
    public partial class frmPrint : Form
    {
        public frmPrint(StringBuilder a)
        {
            InitializeComponent();
            textBox1.Text = a.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string dir = @"c:\C# 2016\Files\";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            string path = dir + "CreatureJournalReport.txt";

            if (File.Exists(path))
            {
                File.AppendText("\r\n ------------------------------ \r\n");
            }
            else
            {
                File.WriteAllText(path, textBox1.Text);
            }


            MessageBox.Show("Your Creature Journal Report has been saved succesfully!");

            if (DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
