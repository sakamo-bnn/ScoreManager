using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex02 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // スコア
        int ScoreA = Random.Range(0, 10);
        int ScoreB = Random.Range(0, 10);

        // 保存するときのキー
        string scoreKey = "Score";

        Debug.Log("ScoreA: " + ScoreA);
        Debug.Log("ScoreB: " + ScoreB);

        // 高い方のスコアを保存する
        ここにコードを書こう;

        // 保存したスコアの読み出し
        Debug.Log(PlayerPrefs.GetInt(scoreKey) + "が保存されているよ");
    }
}
