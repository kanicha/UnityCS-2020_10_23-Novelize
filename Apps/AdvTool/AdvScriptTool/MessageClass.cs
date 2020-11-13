using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvScriptTool
{
    class MessageClass : AdvBaseClass
    {
        //  コマンド名
        public string name = "message";
        //  メッセージの行数
        public int msgCount = 0;
        //  実際のメッセージ配列
        public List<string> msg = new List<string>();
        public void MessageSet(string mess)
        {
            //  改行コードをどのパターンでも \n になるようにする
            mess = mess.Replace("\r\n", "\n");
            //  改行で文字列を分割して配列（リスト）にする
            msg = mess.Split('\n').ToList();
            //  行数を取得
            msgCount = msg.Count;
        }

    }
}
