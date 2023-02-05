using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountText : MonoBehaviour//ƒXƒRƒA‚ð‰ÁŽZ‚·‚é
{
    public int score = 0;
    public int MaxScore = 1000000;
    public int great = 1000000 / TuneInfo.FullNote;
    public int good = 500000 / TuneInfo.FullNote;
    public int rest = TuneInfo.FullNote;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scorMaxText;
    public int gameflag = 0;
    // Start is called before the first frame update
    void Start()
    {
        rest = TuneInfo.FullNote;

    }

    public void AddScore1()
    {
        great = 1000000 / TuneInfo.FullNote;
        score += great;
        ResultScore.result = score;
    }

    public void AddScore2()
    {
        good = 500000 / TuneInfo.FullNote;
        score += good;
        ResultScore.result = score;


    }

    public void ScoreMax1()
    {
        great = 1000000 / TuneInfo.FullNote;
        rest--;
        MaxScore = rest * great + score;
    }
    public void ScoreMax2()
    {
        great = 1000000 / TuneInfo.FullNote;
        rest -= 2;
        MaxScore = rest * great + score;
    }

    // Update is called once per frame
    void Update()
    {
        if (ResultScore.gamemode == 1)
        {
            scoreText.text = score.ToString();

        }
        else
        {
            score = 0;
        }
    }
}
