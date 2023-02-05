using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour//ローカルハイスコアの更新
{
    // Start is called before the first frame update
    int highScore;
    void Start()
    {
        highScore = PlayerPrefs.GetInt("SCORE", 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (highScore < ResultScore.result)
        {
            highScore = ResultScore.result;
            PlayerPrefs.SetInt("SCORE", highScore);
            PlayerPrefs.Save();
        }

    }
}
