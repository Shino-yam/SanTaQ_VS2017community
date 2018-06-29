using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanTaQ
{
    public class MondaiVo
    {
        private String question = "";            // 問題文
        private String[] answer = new String[3]; // 回答1～3
        private String trueAnser = "";           // 正解番号


        /// <summary>
        /// 問題・回答のsetter
        /// </summary>
        public void setData(string[] values)
        {
            this.question = values[0];
            this.answer[0] = values[1];
            this.answer[1] = values[2];
            this.answer[2] = values[3];
            this.trueAnser = values[4];
        }


        /// <summary>
        /// 問題文のgetter
        /// </summary>
        public String getQuestion()
        {
            return this.question;
        }


        /// <summary>
        /// 回答1～3のgetter
        /// </summary>
        public String[] getAnswer()
        {
            String[] ret = new String[3];
            ret[0] = this.answer[0];
            ret[1] = this.answer[1];
            ret[2] = this.answer[2];
            return ret;
        }


        /// <summary>
        /// 正解文のgetter
        /// </summary>
        public String getTrueAnswer()
        {
            int ansNum = int.Parse(this.trueAnser);
            string trueAns = this.answer[ansNum];

            return trueAns;
        }

    }
}
