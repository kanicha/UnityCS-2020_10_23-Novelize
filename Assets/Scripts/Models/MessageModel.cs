using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Jsonのいらない部分習得
/// </summary>
[Serializable]
public class MessageModel
{ 
    // コマンド名
    public string name;
    // メッセージ行数
    public int msgCount;
    // メッセージリスト
    public List<string> msg;
    // メッセージを一つにまとめる
    public string GetMessage()
    {
        // 返り値に使用する文字列を用意
        string message = " ";
        // 一行目から順番につなげる (改行つき)
        msg.ForEach(m => message += m + Environment.NewLine);
        // 合成した文字列を関数に返す
        return message;
    }
}
