using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using UnityEngine;
using UnityEngine.UI;

public class GameMainControl : MonoBehaviour
{
    // アドベンチャーテキスト
    [SerializeField] private Text MassageText;
    // カウントの最大値
    [SerializeField] private float DispTimeMax = 0.1f;

    // メッセージウィンドウに出すためのstring型変数
    private string _massagetext = " ";
    // 文字の表示数
    private int dispCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        // メッセージエリアを初期化
        MassageText.text = " ";
        // ファイルからファイルリソース読み込み
        TextAsset textAsset = Resources.Load("Datas/Scenario", typeof(TextAsset)) as TextAsset;
        _massagetext = textAsset.text;
        // シナリオ読み込み
        //ScenarioDataCtl.InitScenarioData(_massagetext);
        //string scenario = ScenarioDataCtl.LoadMessgae();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
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
        while (_massagetext.Length >= dispCounter)
        {
            // 先頭からDispCounter 数分だけ取り出す。
            var massage = _massagetext.Substring(0, dispCounter);
            MassageText.text = massage;
            // 指定時間分の待ち時間も設定する。
            yield return new WaitForSeconds(DispTimeMax);
            dispCounter++;
        }
    }
}
