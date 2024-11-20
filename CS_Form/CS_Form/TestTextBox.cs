using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    internal class TestTextBox : TextBox
    {
        TestButton _button;
        private TestTextBox TextBox;
        string Hako;

        public TestTextBox(string id, int x, int y, int width, int height)
        {

            //ボタン内に文字を反映させる
            Text = id;

            Location = new Point(x, y);

            Size = new Size(width, height);
        }

        /// <summary>
        /// ラベルの文字更新関数
        /// </summary>
        /// <param name="str"></param>
        public void TextUpdate(string str)
        {
            Hako = Text;
            _button.TextUpdate(Hako);
            Text = str;
        }


    }
}
