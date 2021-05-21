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
using System.Security.AccessControl;

namespace FIleManager
{
    public partial class ForCopyAndOtherForm : Form
    {

        public static string pathtoconvert = " ";
        public static string newWay = " ";
        public static string fileproccess = " ";
        public ForCopyAndOtherForm()
        {
            InitializeComponent();
            newWay = newPathTextBox.Text;
            this.Show();

            process.Text = fileproccess;
        }

        private void oldPathTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileInfo fileInf = new FileInfo(pathtoconvert);
            try
            {
                if (fileInf.Exists)
                {
                    if (fileproccess == "Копирование")
                    {
                        fileInf.CopyTo(newWay, true);
                    }
                    else if (fileproccess == "Перемещение")
                    {
                        fileInf.MoveTo(newWay);
                    }
                    else
                    {

                    }
                }
            }
            catch
            {
                string exept = "Произошла ошибка!";
                MessageBox.Show(exept, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Copy(string path)
        {
            pathtoconvert = path;
            fileproccess = "Копирование";
        }

        public static void Refer(string path)
        {
            pathtoconvert = path;
            fileproccess = "Перемещение";
        }

        private void newPath_Click(object sender, EventArgs e)
        {

        }

        private void ForCopyAndOtherForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
