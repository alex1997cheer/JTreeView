using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JTreeView.Action
{
    public class JTreeViewAction
    {
        //Get all Nodes from TreeView
        public static List<TreeNode> GetAllTreeNode(TreeView treeView)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            List<TreeNode> CollectionTree = new List<TreeNode>();
            foreach (TreeNode node in treeView.Nodes)
            {
                q.Enqueue(node);
                while (q.Any())
                {
                    int size = q.Count;
                    for (int i = 0; i < size; i++)
                    {
                        TreeNode curNode = q.Peek();
                        CollectionTree.Add(curNode);
                        foreach (TreeNode nodechild in curNode.Nodes)
                        {
                            q.Enqueue(nodechild);
                        }
                        q.Dequeue();
                    }
                }
            }
            return CollectionTree;
        }
    }
}
