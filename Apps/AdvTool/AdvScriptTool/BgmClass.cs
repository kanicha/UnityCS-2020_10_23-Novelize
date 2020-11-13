using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvScriptTool
{
    class BgmClass : AdvBaseClass
    {
        public enum BgmMode
        {
            None = 0,       //  何もしない
            Start,          //  開始
            Stop,           //  停止
            FadeIn,         //  フェードイン
            FadeOut,        //  フェードアウト

            BgmModeMax      //  モードの最大数
        }
        public string name = "bgm";
        //  リクエスト BGM の名前
        public string filename = "";
        //  リクエストモード
        public BgmMode actionmode = 0;
        public BgmClass(string fname, BgmMode actMode)
        {
            name = "bgm";
            filename = fname;
            actionmode = actMode;
        }
    }
}
