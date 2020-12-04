using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]

public class ScenarioModel
{
    // 現在選択中行番号変数
    public int nowSelectLine = 0;
    // シナリオを配列管理を行う
    [SerializeField]
    public string[] scenario;
    // 最大行数取得(ゲッター)
    public int MaxLineCount { get { return scenario.Length; } }
}
