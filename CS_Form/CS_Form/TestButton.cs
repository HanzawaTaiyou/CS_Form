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

        ///<summary>
        ///コンストラクタ
        ///クラスを生成したときに呼び出される
        ///</summary>
        public TestButton(int id,int x, int y, int width, int height)
        {
            //ClickイベントにOnClick関数を登録
            Click += OnClick;
            //ボタン内に文字を反映させる
            Text = id.ToString();

            Location = new Point(x,y);

            Size = new Size(width,height);
        }

        public void OnClick(object sender, EventArgs s)
        {
            MessageBox.Show(Text);
        }

    }
}
