using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp7
{
    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Form form = new ColorForm(Color.Blue, "Интерактивня форма");
            Application.Run(form);
        }
        public class ColorForm : Form 
        {
            private Color _backColor;
            public ColorForm(Color backcolor, string title)
            {
                _backColor = backcolor;
                BackColor = backcolor;
                Text = title;
                Height = 600;
                Width = 800;
                FormBorderStyle = FormBorderStyle.Fixed3D;
                StartPosition = FormStartPosition.CenterScreen;

                MouseEnter += (sender, e) => ChangeFormColor(Color.Red);
                MouseLeave += (sender, e) => ChangeFormColor(_backColor);
                MouseWheel += (object sender, MouseEventArgs e) => ChangeFormSize(e.Delta);

            }

            private void SetCommonParameters(Control element, Size size, Point position, string title)
            {
                element.Size = size;
                element.Location = position;
                element.Text = title;
                Controls.Add(element);
                var newvar = new NewClass();
                newvar.Name = "";
            }
            private void ChangeFormColor(Color color) => BackColor = color;
            private void ChangeFormSize(int change)
            {
                double ratio = (double) Height / Width;
                if (ratio >1)
                {
                    Height += change;
                    Width = (int)(ratio * Height);
                }
                else
                {
                    Width += change;
                    Height = (int)(ratio * Width);
                }
            }
        }
    }
}
