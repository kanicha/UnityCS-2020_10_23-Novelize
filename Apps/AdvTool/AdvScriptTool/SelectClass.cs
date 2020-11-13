using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvScriptTool
{
    class SelectClass : AdvBaseClass
    {
        public string name = "select";
        public int count = 0;
        public List<string> msg = new List<string>();
        public List<string> jump = new List<string>();

        /// <summary>
        /// 選択処理の登録
        /// </summary>
        /// <param name="msgLists">選択文字列の配列</param>
        /// <param name="jumpLists">選択時のとび先配列</param>
        /// <param name="msgCount">選択数</param>
        public void SelectSet(List<TextBox> msgLists, List<TextBox> jumpLists, int msgCount)
        {
            //  各リストから登録情報を取得する
            foreach(var i in Enumerable.Range(0, msgCount))
            {
                msg.Add(msgLists[i].Text);
                jump.Add(jumpLists[i].Text);
            }
            //  最大登録数を保存
            count = msgCount;
        }

    }
}
