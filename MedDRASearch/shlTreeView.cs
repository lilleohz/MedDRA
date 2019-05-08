using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MedDRASearch
{
    public partial class shlTreeView : TreeView
    {
        public bool isDoubleClick = false;

        public shlTreeView()
        {
            InitializeComponent();
        }

        public shlTreeView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            isDoubleClick = true;
            base.OnDoubleClick(e);
        }

        protected override void OnBeforeCollapse(TreeViewCancelEventArgs e)
        {
            if (isDoubleClick)
            {
                e.Cancel = true;
                isDoubleClick = false;
            }
            base.OnBeforeCollapse(e);
        }

        protected override void OnDrawNode(DrawTreeNodeEventArgs e)
        {
            //自定义颜色  
            if (e.State == TreeNodeStates.Selected)
            {
                //绿底白字  
                e.Graphics.FillRectangle(Brushes.SkyBlue, e.Node.Bounds);

                Font nodeFont = e.Node.NodeFont;
                if (nodeFont == null) nodeFont = this.Font;
                e.Graphics.DrawString(e.Node.Text, nodeFont, Brushes.White, e.Bounds);
            }
            else
            {
                e.DrawDefault = true;
            }

            if (e.State == TreeNodeStates.Focused)
            {
                using (Pen focusPen = new Pen(Color.Black))
                {
                    focusPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                    Rectangle focusBounds = e.Node.Bounds;
                    focusBounds.Size = new Size(focusBounds.Width, focusBounds.Height);
                    e.Graphics.DrawRectangle(focusPen, focusBounds);
                }
            }

            base.OnDrawNode(e);
        }
    }
}
