using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using mRemoteNG.App;
using mRemoteNG.Connection;
using mRemoteNG.Container;
using mRemoteNG.Tree;


namespace mRemoteNG.Tools
{
    public class ConnectionsTreeToMenuItemsConverter
    {
        public MouseEventHandler MouseUpEventHandler { get; set; }


        public IEnumerable<ToolStripDropDownItem> CreateToolStripDropDownItems(ConnectionTreeModel connectionTreeModel)
        {
            var rootNodes = connectionTreeModel.RootNodes;
            return CreateToolStripDropDownItems(rootNodes);
        }

        public IEnumerable<ToolStripDropDownItem> CreateToolStripDropDownItems(IEnumerable<ConnectionInfo> nodes)
        {
            var dropDownList = new List<ToolStripDropDownItem>();
            try
            {
                dropDownList.AddRange(nodes.Select(CreateMenuItem));
            }
            catch (Exception ex)
            {
                Runtime.MessageCollector.AddExceptionMessage("frmMain.AddNodeToMenu() failed", ex);
            }

            return dropDownList;
        }

        private void AddSubMenuNodes(IEnumerable<ConnectionInfo> nodes, ToolStripDropDownItem toolStripMenuItem)
        {
            foreach (var connectionInfo in nodes)
            {
                var newItem = CreateMenuItem(connectionInfo);
                toolStripMenuItem.DropDownItems.Add(newItem);
            }
        }

        private ToolStripDropDownItem CreateMenuItem(ConnectionInfo node)
        {
            var menuItem = new ToolStripMenuItem
            {
                Text = node.Name,
                Tag = node
            };

            var nodeAsContainer = node as ContainerInfo;
            if (nodeAsContainer != null)
            {

                // Brad457 - 2021.09.30 - THIS is the loop where the folder icon is assigned to the folders.
                // menuItem.Image = Properties.Resources.FolderClosed_16x;
                // menuItem.Image = Properties.Resources.FolderClosed_16x;
                Console.WriteLine("nodeAsContainer.Icon = " + nodeAsContainer.Icon);

             //   Bitmap bitmap = Overlay(Properties.Resources.FolderClosed_16x, nodeAsContainer.Icon);
                    //Overlay
                menuItem.Tag = nodeAsContainer;
                AddSubMenuNodes(nodeAsContainer.Children, menuItem);
            }
            else if (node.GetTreeNodeType() == TreeNodeType.PuttySession)
            {
                menuItem.Image = Properties.Resources.PuttySessions;
                menuItem.Tag = node;
            }
            else if (node.GetTreeNodeType() == TreeNodeType.Connection)
            {
                menuItem.Image = node.OpenConnections.Count > 0 ? Properties.Resources.Run_16x : Properties.Resources.Stop_16x;
                menuItem.Tag = node;
            }

            menuItem.MouseUp += MouseUpEventHandler;
            return menuItem;
        }
        private static Bitmap Overlay(Icon background, Image foreground)
        {
            var result = new Bitmap(background.ToBitmap(), new Size(16, 16));
            using (var gr = Graphics.FromImage(result))
            {
                gr.DrawImage(foreground, new Rectangle(0, 0, foreground.Width, foreground.Height));
            }

            return result;
        }
    }
}