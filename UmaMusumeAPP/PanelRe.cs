using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UmaMusumeAPP
{
    public class PanelRe : Panel
    {
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            return;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // 双缓冲
            this.DoubleBuffered = true;

            // 背景重绘
            if (this.BackgroundImage != null)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                e.Graphics.DrawImage(this.BackgroundImage, new System.Drawing.Rectangle(0, 0, this.Width, this.Height), 0, 0, this.BackgroundImage.Width, this.BackgroundImage.Height, System.Drawing.GraphicsUnit.Pixel);
            }
            base.OnPaint(e);
        }
    }
}
