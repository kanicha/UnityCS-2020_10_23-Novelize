using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnceTextView : MonoBehaviour
{
    [SerializeField] private CanvasGroup onceCanvas = null;
    [SerializeField] float fadeInTimer = 0.1f;
    [SerializeField] float fadeOutTimer = 0.3f;

    // コールバック関数
    private System.Action<GameObject> callback = null;

    private void Awake()
    {
        onceCanvas = GetComponent<CanvasGroup>();
    }

    /// <summary>
    /// 文字フェードイン用関数
    /// </summary>
    public void FadeInOnceText()
    {
        // 透明度を0にする
        onceCanvas.alpha = 0;
        // フェードインを開始
        StartCoroutine(FadeIn());
    }

    /// <summary>
    /// フェードイン処理関数
    /// </summary>
    /// <returns>IEnumeratorの中身</returns>
    private IEnumerator FadeIn()
    {
        // オブジェクトの透明度が1になるまでループを行う
        while (onceCanvas.alpha < 1.0f)
        {
            // 所定時間をかけ透明度を加算
            onceCanvas.alpha += (1.0f / fadeInTimer) * Time.deltaTime;
            // 透明度のMAX数値1を超えた場合1になるように修正
            if (onceCanvas.alpha >= 1.0f)
            {
                onceCanvas.alpha = 1.0f;
            }
            // 1フレーム待機しFadeIn関数に値を返す
            yield return null;
        }
    }

    /// <summary>
    /// フェードアウト呼び出し関数
    /// </summary>
    /// <retun delayTime>待機時間引数</retun>
    public void FadeOutText(float delayTime = 0.0f, System.Action<GameObject> callback = null)
    {
        // コールバック関数を登録
        this.callback = callback;
        // FadeOutText関数が呼ばれた時onceCanvas変数の透明度を1.0fに変更
        onceCanvas.alpha = 1.0f;
        // FadeOut関数をコルーチン呼び出し
        StartCoroutine(FadeOutIE(delayTime));
    }

    /// <summary>
    /// フェードアウト処理関数
    /// </summary>
    /// <retun delayTime>待機時間引数</retun>
    private IEnumerator FadeOutIE(float delayTime = 0.0f, System.Action<GameObject> callback = null)
    {
        // 引数delayTime分時間を止める
        yield return new WaitForSeconds(delayTime);
        // オブジェクトの透明度が1になるまでループを行う
        while (onceCanvas.alpha > 0.0f)
        {
            // 所定時間をかけ透明度を減算
            onceCanvas.alpha -= (1.0f / fadeOutTimer) * Time.deltaTime;
            // 透明度数値が0以下になった時透明度を0に補正
            if (onceCanvas.alpha <= 0.0f)
            {
                onceCanvas.alpha = 0.0f;
            }
            // 1フレーム待機しFadeIn関数に値を返す
            yield return null;
        }
        // コールバック関数が登録されていたら呼び出す
        if (null != this.callback)
        {
            this.callback(gameObject);
        }
    }
}
