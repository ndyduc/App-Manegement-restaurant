using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_5.Component
{
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    public class RoundedButton : Button
    {
        public int BorderRadius { get; set; } = 30; // Định nghĩa bán kính bo tròn

        // Vẽ lại button với hình tròn ở các góc
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // Vẽ nền với góc bo tròn
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, BorderRadius, BorderRadius, 180, 90);
                path.AddArc(Width - BorderRadius, 0, BorderRadius, BorderRadius, 270, 90);
                path.AddArc(Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius, 0, 90);
                path.AddArc(0, Height - BorderRadius, BorderRadius, BorderRadius, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);

                // Vẽ lại background của Button
                using (Brush brush = new SolidBrush(this.BackColor))
                {
                    pevent.Graphics.FillPath(brush, path);
                }

                // Vẽ lại văn bản của Button
                using (Brush brush = new SolidBrush(this.ForeColor))
                {
                    pevent.Graphics.DrawString(this.Text, this.Font, brush, this.ClientRectangle, StringFormat.GenericDefault);
                }
            }
        }
    }

}
