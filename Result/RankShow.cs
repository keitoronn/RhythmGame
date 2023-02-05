using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RankShow : MonoBehaviour//オンラインランキングの表示のための文字列を作る
{
    public TextMeshProUGUI Ranking;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        string a = "";
        for(int i = 0; i < 5; i++)
        {
            a = a + "\n";
            if (i == 0)
            {
                a = a + "1st    ";
            }else if (i == 1)
            {
                a = a + "2nd    ";
            }
            else if (i == 2)
            {
                a = a + "3rd    ";
            }
            else if (i == 3)
            {
                a = a + "4th    ";
            }
            else if (i == 4)
            {
                a = a + "5th    ";
            }
            a = a + ResultScore.rankername[i] + " " + ResultScore.rankscore[i] ;
        }
        /*if (ResultScore.ranking >= 4)
        {
            Ranking.text = ResultScore.ranking + "th" + "\n" + "1st " + ResultScore.rankscore[0] + "\n" + "2nd  " + ResultScore.rankscore[1] + "\n" + "3rd  " + ResultScore.rankscore[2] + "\n" + "4th  " + ResultScore.rankscore[3] + "\n" + "5th  " + ResultScore.rankscore[4];
        }
        else if(ResultScore.ranking == 1)
        {
            Ranking.text = "1st" + "\n" + "1st  " + ResultScore.rankscore[0] + "\n" + "2nd    " + ResultScore.rankscore[1] + "\n" + "3rd  " + ResultScore.rankscore[2] + "\n" + "4th    " + ResultScore.rankscore[3] + "\n" + "5th  " + ResultScore.rankscore[4];
        }
        else if (ResultScore.ranking == 2)
        {
            Ranking.text = "2nd" + "\n" + "1st  " + ResultScore.rankscore[0] + "\n" + "2nd  " + ResultScore.rankscore[1] + "\n" + "3rd  " + ResultScore.rankscore[2] + "\n" + "4th  " + ResultScore.rankscore[3] + "\n" + "5th  " + ResultScore.rankscore[4];
        }
        else if (ResultScore.ranking == 3)
        {
            Ranking.text = "3rd" + "\n" + "1st  " + ResultScore.rankscore[0] + "\n" + "2nd    " + ResultScore.rankscore[1] + "\n" + "3rd  " + ResultScore.rankscore[2] + "\n" + "4th    " + ResultScore.rankscore[3] + "\n" + "5th  " + ResultScore.rankscore[4];
        }
        else if (ResultScore.ranking == -1)
        {
            Ranking.text = "Out of the rank" + "\n" + "1st  " + ResultScore.rankscore[0] + "\n" + "2nd  " + ResultScore.rankscore[1] + "\n" + "3rd  " + ResultScore.rankscore[2] + "\n" + "4th  " + ResultScore.rankscore[3] + "\n" + "5th  " + ResultScore.rankscore[4];
        }
        else
        {
            Ranking.text = "";

        }*/
        
        if (ResultScore.ranking == 1)
        {
            Ranking.text = "ONLINE RANKING\n" + "1st" + "\n" + a;
        }else if(ResultScore.ranking == 2)
        {
            Ranking.text = "ONLINE RANKING\n" + "2nd" + "\n" + a;
        }
        else if (ResultScore.ranking == 3)
        {
            Ranking.text = "ONLINE RANKING\n" + "3rd" + "\n" + a;
        }
        else if (ResultScore.ranking == 4)
        {
            Ranking.text = "ONLINE RANKING\n" + "4th" + "\n" + a;
        }
        else if (ResultScore.ranking == 5)
        {
            Ranking.text = "ONLINE RANKING\n" + "5th" + "\n" + a;
        }
        else if (ResultScore.ranking == -1)
        {
            Ranking.text = "ONLINE RANKING\n" + "Out of the rank" + "\n" + a;
        }
        else
        {
            Ranking.text = "";
        }


    }
}
