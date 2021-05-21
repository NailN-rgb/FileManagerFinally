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
    public partial class Form1 : Form
    {
        private string filePath = "C/";
        private bool inListedMode = false;
        private string selectedItemName = "";
        public static bool isFile = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fileWayTextBox.Text = filePath;
            GetFiles.LoadFiles(mainTree);

            mainTree.AfterSelect += mainTreeElementSelection;
        }

        public void mainTreeElementSelection(object sender, TreeViewEventArgs e)
        {
            GetFiles.GetDirectories(e.Node, e.Node.FullPath);

            string newWay = e.Node.FullPath.Replace("\\\\", "\\");
            fileWayTextBox.Text = newWay;
            SomeFunctions.GettingListDerictories(e.Node.FullPath, listView1);
        }

        private void loadButton()
        {
            filePath = fileWayTextBox.Text;
            GetFiles.LoadFiles(mainTree);
            isFile = false;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.FocusedItem.Checked)
                {
                    Open();
                }
                else
                {
                    loadButton();
                }
            }
            catch
            {
                try
                {
                    if (mainTree.SelectedNode.Checked)
                    {
                        Open();
                    }
                    else
                    {
                        loadButton();
                    }
                }
                catch
                {

                }
            }

           
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectedItemName = e.Item.Text;

            fileNameLabel.Text = selectedItemName;

            FileAttributes fileAttr = File.GetAttributes(filePath + "/" + selectedItemName);

            if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                fileWayTextBox.Text = filePath + "/" + selectedItemName;
            }
            else
            {
                isFile = true;
            }


        }

        private void DoubleClickListViewElement(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inListedMode)
            {
                listView1.View = View.LargeIcon;
                inListedMode = false;
            }
            else
            {
                listView1.View = View.List;
                inListedMode = true;
            }
        }

        private void TextBoxKey_UP(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SomeFunctions.FileOrNodeFinding(fileWayTextBox.Text, mainTree);
            }
        }

        private void OpenSelectedElement(object sender, MouseEventArgs e)
        {
            Open();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void Open()
        {
            string temppath = mainTree.SelectedNode.FullPath + "\\" + listView1.FocusedItem.Text;

            if (File.Exists(temppath))
            {
                System.Diagnostics.Process.Start(temppath);
            }
            else if (Directory.Exists(temppath))
            {
                SomeFunctions.FileOrNodeFinding(temppath, mainTree);
                SomeFunctions.GettingListDerictories(temppath, listView1);
            }
            else
            {
                
            }
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string backway = fileWayTextBox.Text;
            backway = backway.Substring(0, backway.LastIndexOf("\\"));

            SomeFunctions.GettingListDerictories(backway, listView1);

        }

        private void CopyWorkWithFilesClick(object sender, EventArgs e)
        {
            ForCopyAndOtherForm.Copy(mainTree.SelectedNode.FullPath + "\\" + listView1.FocusedItem.Text);
            ForCopyAndOtherForm fr = new ForCopyAndOtherForm();
            fr.Show();
            
        }

        private void RemoteWorkWithFilesClick(object sender, EventArgs e)
        {
            ForCopyAndOtherForm.Refer(mainTree.SelectedNode.FullPath + "\\" + listView1.FocusedItem.Text);
            ForCopyAndOtherForm fr = new ForCopyAndOtherForm();
            fr.Show();
        }

        private void FileInfoWorkWithFilesClick(object sender, EventArgs e)
        {
            string path = mainTree.SelectedNode.FullPath + "\\" + listView1.FocusedItem.Text;

            FileInfo fileInf = new FileInfo(path);

            if (fileInf.Exists)
            {
                string name = fileInf.Name;
                string createTime = fileInf.CreationTime.ToString();
                string fullPath = fileInf.DirectoryName;
                string length = Convert.ToString(fileInf.Length);

                MessageBox.Show("Имя файла: " + name + "\n" + "Время создания: " + createTime + "\n" + "Полный путь: " + fullPath + "\n" +
                                 "Размер файла: " + length, "Свойства", MessageBoxButtons.OK);

            }
        }

        private void DeleteFile(object sender, EventArgs e)
        {
            string path = mainTree.SelectedNode.FullPath + "\\" + listView1.FocusedItem.Text;

            FileInfo fileInf = new FileInfo(path);

            if (fileInf.Exists)
            {
                fileInf.Delete();
                SomeFunctions.GettingListDerictories(fileWayTextBox.Text, listView1);
            }
        }
    }
}
