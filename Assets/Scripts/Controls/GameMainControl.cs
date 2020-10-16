using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMainControl : MonoBehaviour
{
    // アドベンチャーテキスト
    [SerializeField]private Text text;
    private string Massagetext = "教室に人があふれる学校、教室に入り、僕は息をのみ挨拶をした。";

    // Start is called before the first frame update
    void Start()
    {
        // メッセージエリアを初期化
        text.text = "";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
