using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace MedDRASearch
{
    class shlListView:ListView
    {
        private bool isGotFocus = false;

        protected override void OnDrawItem(DrawListViewItemEventArgs e)
        {
            //base.OnDrawItem(e);
            Graphics g = e.Graphics;
            Rectangle bounds = e.Bounds;
            Color baseColor = Color.White;
            Color borderColor = Color.White;
            Color innerBorderColor = Color.FromArgb(255, 255, 255);
            Color textColor = e.Item.ForeColor;

            if(e.Item.Selected)
            {
                textColor = Color.Black;
                if(isGotFocus)
                    RenderHelper.RenderBackgroundInternal(g, bounds, Color.SkyBlue, Color.SkyBlue, Color.SkyBlue, 1f, true, LinearGradientMode.Vertical);
                else
                    RenderHelper.RenderBackgroundInternal(g, bounds, Color.FromArgb(200,200,200), Color.FromArgb(200, 200, 200), Color.DarkGray, 1f, true, LinearGradientMode.Vertical);
            }
            else
            {
                RenderHelper.RenderBackgroundInternal(g, bounds, baseColor, borderColor, innerBorderColor, 1f, true, LinearGradientMode.Vertical);
            }
            
            TextFormatFlags flags = TextFormatFlags.VerticalCenter | TextFormatFlags.LeftAndRightPadding | TextFormatFlags.EndEllipsis;
            Rectangle textRect = new Rectangle(bounds.X + 3, bounds.Y, bounds.Width - 6, bounds.Height); ;
            if (e.Item.ImageList != null)
            {
                Image image = e.Item.ImageIndex == -1 ? null : e.Item.ImageList.Images[e.Item.ImageIndex];
                if (image != null)
                {
                    Rectangle imageRect = new Rectangle(bounds.X + 3, bounds.Y + 2, bounds.Height - 4, bounds.Height - 4);
                    g.InterpolationMode = InterpolationMode.HighQualityBilinear;
                    g.DrawImage(image, imageRect);

                    textRect.X = imageRect.Right + 3;
                    textRect.Width -= imageRect.Width;
                }
            }

            TextRenderer.DrawText(g, e.Item.Text, e.Item.Font, textRect, textColor, flags);

            base.OnDrawItem(e);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            isGotFocus = true;
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            isGotFocus = false;
            base.OnLostFocus(e);
        }

        protected override void OnDrawColumnHeader(DrawListViewColumnHeaderEventArgs e)
        {
            base.OnDrawColumnHeader(e);

            Graphics g = e.Graphics;
            Rectangle bounds = e.Bounds;
            Color baseColor = Color.FromArgb(150, 150, 150);
            Color borderColor = Color.FromArgb(150, 150, 150);
            Color innerBorderColor = Color.FromArgb(255, 255, 255);
            
            RenderHelper.RenderBackgroundInternal(g, bounds, baseColor, borderColor, innerBorderColor, 1f, true, LinearGradientMode.Vertical);
            TextFormatFlags flags = TextFormatFlags.Bottom | TextFormatFlags.LeftAndRightPadding | TextFormatFlags.EndEllipsis;
            Rectangle textRect = new Rectangle(bounds.X + 3, bounds.Y, bounds.Width - 6, bounds.Height); ;
            if (e.Header.ImageList != null)
            {
                Image image = e.Header.ImageIndex == -1 ? null : e.Header.ImageList.Images[e.Header.ImageIndex];
                if (image != null)
                {
                    Rectangle imageRect = new Rectangle(bounds.X + 3, bounds.Y + 2, bounds.Height - 4, bounds.Height - 4);
                    g.InterpolationMode = InterpolationMode.HighQualityBilinear;
                    g.DrawImage(image, imageRect);

                    textRect.X = imageRect.Right + 3;
                    textRect.Width -= imageRect.Width;
                }
            }

            TextRenderer.DrawText(g, e.Header.Text, e.Font, textRect, e.ForeColor, flags);
        }

        
    }
}
