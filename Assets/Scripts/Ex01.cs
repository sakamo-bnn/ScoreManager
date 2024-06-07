using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 保存したいスコア
        int score = 100;

        // 保存するときのキー
        string scoreKey = "Score";

        // スコアを保存する処理
        // ここにコードを書こう;
        PlayerPrefs.SetInt(scoreKey, score);

        Debug.Log("保存したスコア: " + score);

        // スコアを読み出す処理
        // int readScore = ここにコードを書こう;
        int readScore = PlayerPrefs.GetInt(scoreKey);

        Debug.Log("読み込んだスコア: " + readScore);
    }
}
