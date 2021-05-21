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

namespace FIleManager
{
    class SomeFunctions
    {


        public static void GettingListDerictories(string filePath, ListView listView1)
        {
            listView1.Clear();

            DirectoryInfo dInfoFoxTextu;

            try
            {
                dInfoFoxTextu = new DirectoryInfo(filePath);
                FileInfo[] file = dInfoFoxTextu.GetFiles();
                DirectoryInfo[] dirs = dInfoFoxTextu.GetDirectories();

                for (int i = 0; i < dirs.Length; i++)
                {
                    listView1.Items.Add(dirs[i].Name, 4);
                }

                for (int i = 0; i < file.Length; i++)
                {
                    string fileExten = file[i].Extension.ToUpper();

                    switch (fileExten)
                    {
                        case ".MP3":
                        case ".MP2":
                            listView1.Items.Add(file[i].Name, 1);
                            break;

                        case ".EXE":
                        case ".COM":
                            listView1.Items.Add(file[i].Name, 0);
                            break;

                        case ".MP4":
                        case ".AVI":
                        case ".MKV":
                            listView1.Items.Add(file[i].Name, 6);
                            break;

                        case ".PDF":
                        case ".DOC":
                        case ".DOCX":
                        case ".TXT":
                            listView1.Items.Add(file[i].Name, 3);
                            break;

                        case ".PNG":
                        case ".JPG":
                        case ".JPEG":
                            listView1.Items.Add(file[i].Name, 8);
                            break;

                        default:
                            listView1.Items.Add(file[i].Name, 7);
                            break;
                    }
                }

                
                
            }
            catch (Exception e)
            {
                string tmptext = "Произошла ошибка, возможно имя папки задано неверно, либо доступ к папке запрещен!";
                MessageBox.Show(tmptext, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void AddingElementsToList(string[] str, ListView listView1)
        {
            for (int i = 0; i < str.Length; i++)
            {
                string[] divitedstring = str[i].Split(('\\'));
                listView1.Items.Add(divitedstring[divitedstring.Length - 1]);
            }
        }

        public static void FileOrNodeFinding(string filePath, TreeView treeNode1)
        {
            TreeNode tempTreeViev = null;

            bool complete = false;

            foreach (TreeNode node in treeNode1.Nodes)
            {
                Searching(node.Nodes, filePath, ref tempTreeViev);

                if (!(tempTreeViev == null))
                {
                    complete = treeNode1.Focus();
                    treeNode1.SelectedNode = tempTreeViev;
                }
            }           
        }


        private static void Searching(TreeNodeCollection tnc, string path, ref TreeNode res)
        {
            foreach (TreeNode tn in tnc)
            {
                if (tn.FullPath == path)
                {
                    res = tn;
                }

                Searching(tn.Nodes, path, ref res);

            }
        }

        private void FileOrDirectorySearching(string path, TreeView treeView)
        {
            TreeNode tempTreeViev = null;

            bool complete = false;

            foreach (TreeNode node in treeView.Nodes)
            {
                Searching(node.Nodes, path, ref tempTreeViev);

                if (!(tempTreeViev == null))
                {
                    complete = treeView.Focus();
                    treeView.SelectedNode = tempTreeViev;
                }
            }

            if (complete)
            {
                string finded = "Файл найден!";
                MessageBox.Show(finded, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string motFinded = "Файл не найден, или располагается в недоступном каталоге!";
                DialogResult dr = MessageBox.Show(motFinded, " ", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }

        }

        

        
    }
}
