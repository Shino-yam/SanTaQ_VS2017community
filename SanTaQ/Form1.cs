using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanTaQ
{
    public partial class FormMain : Form
    {
        // メイン処理のインスタンス用変数
        SanTaQMain stq;


        public FormMain()
        {
            InitializeComponent();

            stq = new SanTaQMain();
            stq.setGameStart(false); // クイズ開始中フラグを false にセット
            stq.initialize(this);

         }


        private void buttonAns_Click(object sender, EventArgs e)
        {
            // ボタン名のリプレース用文字列
            String BUTTON_BASE_NAME = "buttonAns";
            
            // ボタン名を取得
            String btnName = ((Button)sender).Name;

            // ボタン番号に変換
            String btnNum = btnName.Replace(BUTTON_BASE_NAME, "");

            // ボタンテキストを取得
            String btnText = ((Button)sender).Text;

            // イベント処理
            Boolean isGameStart = stq.getGameStart();
            stq.setBtnNum(btnNum);
            stq.setBtnText(btnText);


            if ( isGameStart )
            {
                // 開始しているとき
                stq.setPushBtn(true);
                stq.quizMain();

            }
            else
            {
                // 開始していないとき

                switch (stq.getBtnNum())
                {
                    case "1":
                        stq.setGameStart(true);
                        stq.initialize(this);
                        break;
                    case "3":
                        Application.Exit();
                        break;
                    default:
                        break;
                }

            }

        }

    }
}
