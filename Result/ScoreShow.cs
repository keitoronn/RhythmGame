using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreShow : MonoBehaviour//ƒXƒRƒA‚É‰ž‚¶‚ÄSE‚ð–Â‚ç‚·
{
    public TextMeshProUGUI scoreText;
    int highScore;
    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("SCORE", 0);


    }
    int flag = 0;
    // Update is called once per frame
    void Update()
    {
        scoreText.text = ResultScore.result.ToString();
        if (ResultScore.result < 600000&&flag==0)
        {
            GameObject SoundEffect = GameObject.Find("SE");

            SoundEffect.GetComponent<SE>().SE1();
            flag = 1;
        }else if (ResultScore.result < 700000 && flag == 0)
        {
            GameObject SoundEffect = GameObject.Find("SE");

            SoundEffect.GetComponent<SE>().SE2();
            flag = 1;

        }
        else if (ResultScore.result < 800000 && flag == 0)
        {
            GameObject SoundEffect = GameObject.Find("SE");

            SoundEffect.GetComponent<SE>().SE3();
            flag = 1;

        }
        else if (ResultScore.result <900000 && flag == 0)
        {
            GameObject SoundEffect = GameObject.Find("SE");

            SoundEffect.GetComponent<SE>().SE4();
            flag = 1;

        }
        else if (flag == 0)
        {
            GameObject SoundEffect = GameObject.Find("SE");

            SoundEffect.GetComponent<SE>().SE5();
            flag = 1;
        }
        if (highScore <= ResultScore.result)
        {
            highScore = ResultScore.result;
            PlayerPrefs.SetInt("SCORE", highScore);
            PlayerPrefs.Save();
            scoreText.text = "HIGHSCORE!"+ResultScore.result.ToString();
        }
    }
}
