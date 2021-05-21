using System;
using System.IO;
using System.Windows.Forms;

namespace FIleManager
{
    class GetFiles
    {
        public static void GetDirectories(TreeNode treeND, string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(treeND.FullPath);

                DirectoryInfo dInfo = new DirectoryInfo(treeND.FullPath);

                string[] files = Directory.GetFiles(treeND.FullPath);

                bool accessdiny = false;


                //DirectorySecurity ds = dInfo.GetAccessControl(AccessControlSections.Owner);

                //var rules = ds.GetAccessRules(true, true, typeof(System.Security.Principal.SecurityIdentifier));

                for (int i = 0; i < dirs.Length; i++)
                {
                    if (dInfo.Exists)
                    {
                        try
                        {
                            string[] temp = dirs[i].Split('\\');

                            TreeNode newTreeND = new TreeNode(temp[temp.Length - 1]);

                            treeND.Nodes.Add(newTreeND);
                        }
                        catch (UnauthorizedAccessException)
                        {
                            continue;
                        }
                    }
                }

                if (accessdiny)
                {
                    for (int i = 0; i < dirs.Length; i++)
                    {

                        string[] temp = dirs[i].Split('\\');

                        TreeNode newTreeNode = new TreeNode(temp[temp.Length - 1]);

                        treeND.Nodes.Add(newTreeNode);
                    }
                }
            }
            catch
            {

            }
            finally
            {

            }
        }


        public static void LoadFiles(TreeView mainTree)
        {
            DriveInfo[] lDrives = DriveInfo.GetDrives();

            foreach (DriveInfo item in lDrives)
            {
                TreeNode treeNode = new TreeNode(item.Name);
                mainTree.Nodes.Add(treeNode);

                //GetDirectories(tn, tn.FullPath);
            }
        }
    }

    
}
