﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioDataCtl
{
    // シナリオデータ保存場所関数呼び出し宣言
    private ScenarioModel scenarioModel = new ScenarioModel();
    
    /// <summary>
    /// 読み込んだシナリオデータ仕分け関数
    /// </summary>
    /// <param name="scenarioText">読み込んだシナリオテキストデータ</param>
    public void InitScenarioData(string scenarioText)
    {
        // テキストを改行で区切る
        scenarioModel.scenario = scenarioText.Split('\n');
        // 行の先頭を選択するように初期化
        scenarioModel.nowSelectLine = 0;
    }

    /// <summary>
    /// メッセージ習得関数
    /// </summary>
    /// <returns>テキスト表示文字習得</returns>
    public string LoadScenarioMsg()
    {
        // 1行を読みこむ
        var msg = scenarioModel.scenario[scenarioModel.nowSelectLine++];
        // Json形式を定義したMessageModelクラスデータに変換を行う
        var messages = JsonUtility.FromJson<MessageModel>(msg);
        // 習得したメッセージをリターンで返す
        return messages.GetMessage();
    }

    /// <summary>
    /// 最後の行達成判断関数
    /// </summary>
    /// <returns>最後の行に達していればreturn</returns>
    public bool IsEndLine()
    {
        return (scenarioModel.MaxLineCount == scenarioModel.nowSelectLine) ;
    }
}
