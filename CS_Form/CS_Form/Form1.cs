using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        TestLabel _testLabel;

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
                        TestButton testButton = new TestButton(this,c,a, b, 100, 100);
                        Controls.Add(testButton);

                        c = c + 1;
                    }
                    // yを100ずらす
                    b = b + 100;
                    
                }
                // xを100ずらす
                a = a + 100;
                
            }

            _testLabel = new TestLabel("らべるだよ",10,300,100,500);
            Controls.Add(_testLabel);
            //Label label = new Label();
            //label.Location = new Point(30, 400);
            //label.Text = "らべるだよ";

            //Controls.Add(label);

        }

        /// <summary>
        /// ラベルの文字を更新する
        /// </summary>
        /// <param name="str"></param>
        public void LabelTextUpdate(string str)
        {
            _testLabel.TextUpdate(str);
        }

    }
}
