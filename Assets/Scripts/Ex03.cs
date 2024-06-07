using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex03 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // スコアリスト: 複数のスコアを情報をもつ配列
        int[] scoreList = new int[4];

        // ランキングを保存するときに使うキー
        string[] scoreKeyList = {
            "score1",   // 1位のスコアに対するキー
            "score2",   // 2位のスコアに対するキー
            "score3"    // 3位のスコアに対するキー
        };

        // 配列にランダムな整数を設定する
        for (int i = 0; i < scoreList.Length; i++)
            scoreList[i] = Random.Range(0, 100);

        // スコアリストを確認する
        PrintScoreList(scoreList);
        // PlayerPrefs.DeleteAll();

        // 配列を昇順に並び替える(ソート)
        System.Array.Sort(scoreList);

        // 改めてスコアリストを確認する
        PrintScoreList(scoreList);

        // 1位を記録する
        // ここにコードを書こう;
        PlayerPrefs.SetInt(scoreKeyList[0], scoreList[3]);

        // 2位を記録する
        // ここにコードを書こう;
        PlayerPrefs.SetInt(scoreKeyList[1], scoreList[2]);

        // 3位を記録する
        // ここにコードを書こう;
        PlayerPrefs.SetInt(scoreKeyList[2], scoreList[1]);

        // PlayerPrefsに保存した内容を確認する
        PrintSavedScore(scoreKeyList);
    }

    // スコアリストの中身を確認する関数
    void PrintScoreList(int[] scoreList)
    {
        string printMsg = "{";

        for (int i = 0; i < scoreList.Length; i++)
        {
            printMsg += scoreList[i].ToString();

            if (i < scoreList.Length - 1)
                printMsg += ",";
        }

        printMsg += "}";

        Debug.Log(printMsg);
    }

    // PlayerPrefsに保存した内容を確認する関数
    void PrintSavedScore(string[] scoreKeyList)
    {
        for (int i = 0; i < scoreKeyList.Length; i++)
            Debug.Log(scoreKeyList[i] + ": " + PlayerPrefs.GetInt(scoreKeyList[i]).ToString());
    }
}
