using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SanTaQ
{
    class SanTaQMain
    {
        // 出題する問題数
        private const int QUESTIONS = 15; // 問題数はここで設定，ただし準備している問題数より大きくしないこと

        // 出題する問題リスト
        private List<int> qList = new List<int>();

        // 現在の問題番号
        private int nowQuestion = 0;

        // 正解数
        private int countOK = 0;
        
        // クイズ開始中フラグ
        private Boolean isGameStart = false;

        // クイズ開始中button押下フラグ
        private Boolean isPushBtn = false;

        // ボタン入力検出のための変数
        private String selectBtnNum = "-";
        private String selectBtnText = "-";

        // MondaiVo用の変数
        private List<MondaiVo> mondai = new List<MondaiVo>();

        // Form受け渡し用変数
        FormMain frm;


        /// <summary>
        /// クイズ開始中フラグsetter/getter
        /// </summary>
        public void setGameStart(Boolean flgState)
        {
            this.isGameStart = flgState;
        }
        public Boolean getGameStart()
        {
            return this.isGameStart;
        }


        /// <summary>
        /// クイズ開始中button押下フラグsetter/getter
        /// </summary>
        public void setPushBtn(Boolean flgState)
        {
            this.isPushBtn = flgState;
        }
        public Boolean getPushBtn()
        {
            return this.isPushBtn;
        }


        /// <summary>
        /// ボタン番号setter/getter
        /// </summary>
        public void setBtnNum(String btnNum)
        {
            this.selectBtnNum = btnNum;
        }
        public String getBtnNum()
        {
            return this.selectBtnNum;
        }


        /// <summary>
        /// ボタンテキストsetter/getter
        /// </summary>
        public void setBtnText(String btnText)
        {
            this.selectBtnText = btnText;
        }
        public String getBtnText()
        {
            return this.selectBtnText;
        }

        
        /// <summary>
        /// ボタン初期状態に設定
        /// </summary>
        public void initialize(FormMain f)
        {
            this.frm = f;

            if(isGameStart)
            {
                // 開始しているとき

                // 現在の問題番号・正解数の初期化
                this.nowQuestion = 0;
                this.countOK = 0;

                // テキストエリアに説明表示
                String startMsg = "\r\n\r\n";
                startMsg += "それではクイズをはじめます";
                frm.textQuestion.Text = startMsg;

                frm.buttonAns1.Text = "① 回答1";
                frm.buttonAns1.Enabled = false;
                frm.buttonAns2.Text = "② 回答2";
                frm.buttonAns2.Enabled = false;
                frm.buttonAns3.Text = "③ 回答3";
                frm.buttonAns3.Enabled = false;

                frm.Refresh();

                for( int i = 3; i >= 0; i-- )
                {
                    String[] countDwn = { "┏┓\r\n┃┓┏┓\r\n┗┛┗┛", "┓\r\n┃\r\n┃", "━┓\r\n┏┛\r\n┗━", "━┓\r\n━┫\r\n━┛" };
                    
                    frm.textQuestion.Text = startMsg + "\r\n\r\n" + countDwn[i] + "\r\n";

                    frm.Refresh();

                    Thread.Sleep(1000);

                }
                
                frm.buttonAns1.Enabled = true;
                frm.buttonAns2.Enabled = true;
                frm.buttonAns3.Enabled = true;

                //frm.Refresh();

                // 問題のロード
                this.loadQuiz();

                // 出題する問題の選択
                int maxQuestion = mondai.Count;
                System.Random rnd = new Random(Environment.TickCount);

                for (int i = 0; i < QUESTIONS; i++)
                {
                    Boolean isSetData = false;
                    while (!isSetData)
                    {
                        int qNum = rnd.Next(maxQuestion);
                        if (qList.IndexOf(qNum) == -1)
                        {
                            qList.Add(qNum);
                            isSetData = true;
                        }
                        else
                        {
                            isSetData = false;
                        }
                    }
                }

                this.quizMain();
            }
            else
            {
                // 開始していないとき

                // テキストエリアに説明表示
                String guide = "\r\n\r\n";
                guide += "3択クイズ SanTaQ を始めるには ① のボタンを，\r\n";
                guide += "終了するには ③ のボタンを押してください。\r\n";
                frm.textQuestion.Text = guide;

                // 各ボタンの表示設定
                frm.buttonAns1.Text = "① クイズをはじめる";
                frm.buttonAns2.Text = "";
                frm.buttonAns2.Enabled = false;
                frm.buttonAns3.Text = "③ SanTaQ を終了する";

                frm.Refresh();
            }

        }


        /// <summary>
        /// メイン処理
        /// </summary>
        public void quizMain()
        {

            if( this.nowQuestion < QUESTIONS )
            {
                // 出題
                int questionNumber = qList[this.nowQuestion];

                frm.textTitle.Text = "【第 " + ( this.nowQuestion + 1 ) + " / " + QUESTIONS + " 問】";

                frm.textQuestion.Text = mondai[questionNumber].getQuestion().Replace("{CR}", "\r\n");
                System.Random rnd = new Random(Environment.TickCount);
                int ansPattern = rnd.Next(7);

                if (!this.isPushBtn)
                {
                    switch (ansPattern)
                    {
                        case 0:
                            setAnswer(questionNumber, 0, 1, 2);
                            break;
                        case 1:
                            setAnswer(questionNumber, 0, 2, 1);
                            break;
                        case 2:
                            setAnswer(questionNumber, 1, 0, 2);
                            break;
                        case 3:
                            setAnswer(questionNumber, 1, 2, 0);
                            break;
                        case 4:
                            setAnswer(questionNumber, 2, 0, 1);
                            break;
                        default:
                            setAnswer(questionNumber, 2, 1, 0);
                            break;
                    }

                }


                // 正解判定
                if (this.isPushBtn)
                {
                    String trueAnswer = mondai[questionNumber].getTrueAnswer();

                    if (this.selectBtnText == trueAnswer)
                    {
                        // 正解のとき
                        frm.labelOK.Visible = true;
                        this.countOK++;
                    }
                    else
                    {
                        // 不正解のとき
                        frm.labelNG.Visible = true;

                    }
                    frm.Refresh();
                    Thread.Sleep(2000); // ウェイト
                    frm.labelOK.Visible = false;
                    frm.labelNG.Visible = false;
                    frm.Refresh();
                    this.setPushBtn(false);
                    this.nowQuestion++;
                    quizMain();
                }

            }
            else
            {
                // 結果表示

                // fromの表示を結果発表用に変更
                frm.textTitle.Text = "【 結 果 発 表 】";
                frm.textQuestion.Text = "";
                frm.buttonAns1.Text = "";
                frm.buttonAns1.Enabled = false;
                frm.buttonAns2.Text = "";
                frm.buttonAns2.Enabled = false;
                frm.buttonAns3.Text = "";
                frm.buttonAns3.Enabled = false;
                frm.Refresh();

                // 結果発表用の文字列準備
                decimal score = ((decimal)this.countOK / (decimal)QUESTIONS) * 100;
                string[] result = {
                    "\r\n\r\n",
                    "問題数： " + QUESTIONS + "\r\n\r\n",
                    "正解数： " + this.countOK + "\r\n\r\n",
                    "正解率： " + score + " %\r\n\r\n"
                };
                string resultStr = "";
                for ( int i = 0; i < result.Length; i++ )
                {
                    Thread.Sleep(1000); // ウェイト
                    resultStr += result[i];
                    frm.textQuestion.Text = resultStr;
                    frm.Refresh();
                }
                Thread.Sleep(2000); // ウェイト

                // テキストエリアに説明表示
                String guide = "\r\n\r\n";
                guide += "3択クイズ SanTaQ をもう一度始めるには ① のボタンを，\r\n";
                guide += "終了するには ③ のボタンを押してください。\r\n";
                resultStr += guide;
                frm.textQuestion.Text = resultStr;

                this.isGameStart = false;

                // 各ボタンの表示設定
                frm.buttonAns1.Text = "① クイズをはじめる";
                frm.buttonAns1.Enabled = true;
                frm.buttonAns2.Text = "";
                frm.buttonAns2.Enabled = false;
                frm.buttonAns3.Text = "③ SanTaQ を終了する";
                frm.buttonAns3.Enabled = true;
                frm.Refresh();

            }

        }


        /// <summary>
        /// 問題csvを読み込む
        /// </summary>
        private void loadQuiz()
        {

            String fileName1 = "..\\..\\SanTaQ_question.txt"; // 開発中のpath（ソースコードの位置）
            String fileName2 = ".\\SanTaQ_question.txt";       // リリース後のpath（exeファイルと同じ位置）
            String fileName = "";

            // 問題ファイルの存在確認
            if (System.IO.File.Exists(fileName1))
            {
                fileName = fileName1;
            }
            else if (System.IO.File.Exists(fileName2))
            {
                fileName = fileName2;
            }
            else
            {
                // ここに来てしまったときは問題ファイルが無い
                throw new System.IO.FileNotFoundException();
            }

            MondaiVo tempMondai;


            // ファイルの読み込み
            try
            {
                // csvファイルを開く
                using (var sr = new System.IO.StreamReader(@fileName))
                {
                    // ストリームの末尾まで繰り返す
                    while (!sr.EndOfStream)
                    {
                        // 仮インスタンスの実体化
                        tempMondai = new MondaiVo();
                        
                        // ファイルから一行読み込む
                        var line = sr.ReadLine();

                        // 読み込んだ一行をカンマ毎に分けて配列に格納する
                        var values = line.Split(',');

                        // 仮インスタンス変数に代入
                        tempMondai.setData(values);

                        // MondaiVo に代入
                        mondai.Add(tempMondai);
                    }
                }

            }
            catch (System.Exception e)
            {
                // ファイルを開くのに失敗したとき
                System.Console.WriteLine(e.Message);
            }

        }


        /// <summary>
        /// 回答パターンの登録
        /// </summary>
        private void setAnswer(int qNum, int ans1, int ans2, int ans3)
        {
            String answer1 = mondai[qNum].getAnswer()[ans1];
            frm.buttonAns1.Text = answer1;

            String answer2 = mondai[qNum].getAnswer()[ans2];
            frm.buttonAns2.Text = answer2;

            String answer3 = mondai[qNum].getAnswer()[ans3];
            frm.buttonAns3.Text = answer3;

            frm.Refresh();

            return;
        }

    }


}
