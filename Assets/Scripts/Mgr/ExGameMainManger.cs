using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using DG.Tweening;

public class ExGameMainManger : MonoBehaviour
{
    // 親のオブジェクト(nessageWindow)
    [SerializeField] private Transform parent = null;
    // 一文字表示Prefab宣言
    [SerializeField] private GameObject oneTextPrefab = null;
    // 文字の表示速度タイマー用
    [SerializeField] private float fontStepTimer = 0.1f;
    // 表示開始座標
    [SerializeField] private Vector2 startPosition = default(Vector2);
    // 横の文字数
    [SerializeField] private int wideStringLengthMax = 30;
    // 文字関係
    [SerializeField] private float widePadding = 56;
    // 行間隔
    [SerializeField] private float heightPadding = 66;
    // 先頭からの文字数
    private int currentPosition = 0;

    // リスト宣言
    private List<GameObject> messageFonts = new List<GameObject>();

    // 表示目的用テキスト変数
    private string messageText = "おーい、めちゃくちゃ腹減ったから購買行こうぜ\n" +
        "そういい裕也は俺の手を引っ張り無理やり購買に行かせた...";

    // 文字表示中確認用フラグ変数
    private bool isDisplayFonts = false;
    // 文字表示終了フラグ変数
    private bool isDiplayEnd = false;

    // Update is called once per frame
    void Update()
    {
        // 文字表示中ではなく、マウスを左クリックしていた場合
        if (Input.GetMouseButtonDown(0) && !isDisplayFonts && !isDiplayEnd)
        {
            // 文字表示中モードに設定
            isDisplayFonts = true;
            // FontDisp関数をコルーチンで呼び文字表示を行う
            StartCoroutine(FontDisp());
        }
        // すべての表示が終了し、マウス右クリック入力された場合
        if (Input.GetMouseButtonDown(1) && isDisplayFonts && isDiplayEnd)
        {
            // 表示中フラグをfalseにする
            isDisplayFonts = false;
            // すべての文字オブジェクトの重量を有効化する
            messageFonts.ForEach(msg =>
                msg.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic);
            // 一定時間後にフェードアウト
            messageFonts.ForEach(msg =>
                msg.GetComponent<OnceTextView>().FadeOutText(5));
        }
    }

    /// <summary>
    /// 文字表示用コルーチン
    /// </summary>
    /// <returns></returns>
    IEnumerator FontDisp()
    {
        // メッセージ最後まで表示していなければ文字表示を行う
        while (messageText.Length > currentPosition)
        {
            // 現在のポジションから一文字取り出す
            var msg = messageText.Substring(currentPosition, 1);
            // 座標にテキストボックスを生成して文字生成
            SetFonts(msg, GetDispPosition());
            // ポジション更新
            currentPosition++;
            // 一定時間待つ
            yield return new WaitForSeconds(fontStepTimer);
        }
        // 表示終了フラグをtrueに
        isDiplayEnd = true;
    }

    /// <summary>
    /// 文字の配置用関数
    /// </summary>
    /// <param name="msg"></param>
    /// <param name="pos"></param>
    private void SetFonts(string msg, Vector2 pos)
    {
        // 一文字表示するためのオブジェクトをスクリーンに作成する
        // (ヒエラルキーとして親を messageWindow に設定を行う)
        var oneTextFont = Instantiate(oneTextPrefab, parent);
        // 生成したオブジェクトを指定された座標に配置を行う
        oneTextFont.GetComponent<RectTransform>().localPosition = pos;
        // 生成したテキストオブジェクトに1文字表示する
        oneTextFont.GetComponent<Text>().text = msg;
        // 文字フェードイン実行処理
        oneTextFont.GetComponent<OnceTextView>().FadeInOnceText();
        // 物理挙動を制御するためにリストに追加
        messageFonts.Add(oneTextFont);
    }

    /// <summary>
    /// 現在の文字から座標を習得
    /// </summary>
    /// <returns>表示座標</returns>
    private Vector2 GetDispPosition()
    {
        return new Vector2(startPosition.x + (currentPosition % wideStringLengthMax) * widePadding,
            startPosition.y - (currentPosition / wideStringLengthMax) * heightPadding);
    }
}
