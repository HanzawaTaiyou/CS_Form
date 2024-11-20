using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CS_Form
{
    class TestButton : Button
    {
        Form1 _form1;
        TestTextBox _textbox;

        ///<summary>
        ///コンストラクタ
        ///クラスを生成したときに呼び出される
        ///</summary>
        public TestButton(Form1 form1,string id,int x, int y, int width, int height)
        {
            _form1 = form1;

            //ClickイベントにOnClick関数を登録
            Click += OnClick;
            //ボタン内に文字を反映させる
            Text = id;

            Location = new Point(x,y);

            Size = new Size(width,height);
        }

        public void OnClick(object sender, EventArgs s)
        {
            _form1.LabelTextUpdate(Text);
        }

        /// <summary>
        /// ラベルの文字更新関数
        /// </summary>
        /// <param name="str"></param>
        public void TextUpdate(string str)
        {
            Text = str;
        }

    }
}
