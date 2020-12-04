using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using UnityEngine;
using UnityEngine.UI;

public class GameMainControl : MonoBehaviour
{
    // アドベンチャーテキスト
    [SerializeField] private Text MessageText;
    // カウントの最大値
    [SerializeField] private float DispTimeMax = 0.1f;

    // メッセージウィンドウに出すためのstring型変数
    private string _messagetext = " ";

    // 文字の表示数
    private int dispCounter = 0;

    public ScenarioDataCtl scenarioDataCtl;

    // 暫定中に停止用フラグ宣言
    private bool isKeyWait = false;

    // 文字表示中フラグ宣言
    private bool isDisplayActive = false;

    // Start is called before the first frame update
    void Start()
    {
        // メッセージエリアを初期化
        MessageText.text = "";
        // ファイルからファイルリソース読み込み
        TextAsset textAsset = Resources.Load("Datas/Scenario", typeof(TextAsset)) as TextAsset;
        _messagetext = textAsset.text;
        // シナリオ読み込み
        scenarioDataCtl = new ScenarioDataCtl();
        scenarioDataCtl.InitScenarioData(_messagetext);
        _messagetext = scenarioDataCtl.LoadScenarioMsg();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isKeyWait)
        {
            // マウス左クリック入力したら分岐
            if (Input.GetMouseButtonDown(0) && false == scenarioDataCtl.IsEndLine())
            {
                isKeyWait = false;
                // 前に表示した文章を消す
                MessageText.text = " ";
                // 次のテキストを読み込み開始
                _messagetext = scenarioDataCtl.LoadScenarioMsg();
                // 次の文字列表示を開始
                isDisplayActive = false;
            }
        }
        // 文字中の表示ではない場合表示開始を行う

        /* bool型に対して" ! (not)"を使った時
         trueだった場合条件分岐がfalseになり
         falseだった場合trueになる。*/
        else if (!isDisplayActive)
        {
            isDisplayActive = true;
            // コルーチンを使用し呼び出し
            StartCoroutine(DispFont());
        }

    }

    /// <summary>
    /// コルーチン使用のための関数、一文字出す
    /// </summary>
    /// <returns></returns>
    IEnumerator DispFont()
    {
        // 文字を表示式っていない場合、繰り返す
        while (_messagetext.Length >= dispCounter)
        {
            // 先頭からDispCounter 数分だけ取り出す。
            MessageText.text = _messagetext.Substring(0, dispCounter);
            // 指定時間分の待ち時間も設定する。
            yield return new WaitForSeconds(DispTimeMax);
            dispCounter++;
        }
        // キー入力待ちに入るためFlagをtrueに
        isKeyWait = true;
    }
}
