using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;

namespace CS_Form
{
    internal class TestLabel : Label
    {
        public TestLabel(string id, int x, int y, int width, int height)
        {

            //ボタン内に文字を反映させる
            Text = id;

            Location = new Point(x, y);

            Size = new Size(width, height);
        }

    }
}
