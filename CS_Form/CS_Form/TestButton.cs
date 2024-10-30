using System;
using System.Collections.Generic;
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
        public TestButton()
        {
            //ClickイベントにOnClick関数を登録
            Click += OnClick;
        }

        public void OnClick(object sender, EventArgs s)
        {
            MessageBox.Show("・ω・");
        }

    }
}
