﻿using System;
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

        public TestTextBox(string id, int x, int y, int width, int height)
        {

            //ボタン内に文字を反映させる
            Text = id;

            Location = new Point(x, y);

            Size = new Size(width, height);
        }

        public string TextReplacement(string str)
        {
            string temp = Text;
            Text = str;
            return temp;
        }


    }
}
