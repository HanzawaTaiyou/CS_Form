﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // aはxの値指定
            // bはyの値指定
            int a = 0;
            int b = 0;
            int c = 0;

            // xを100ずつ＋の方向にずらす
            for (int i = 0; i < 3; i++)
            {
                // 列が移動したらyを初期化する
                b = 0;

                // yを＋の方向に100ずつずらす
                for (int j = 0; j < 4; j++)
                {
                    // xが100ではないかつyが300ではない又はxが100の場合
                    if (i != 1 && j < 3 || i == 1)
                    {
                        TestButton testButton = new TestButton(c,a, b, 100, 100);
                        Controls.Add(testButton);

                        c = c + 1;
                    }
                    // yを100ずらす
                    b = b + 100;
                    
                }
                // xを100ずらす
                a = a + 100;
                
            }


        }
    }
}
