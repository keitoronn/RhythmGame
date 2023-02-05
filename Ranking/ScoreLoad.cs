using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using NCMB;
public class ScoreLoad : MonoBehaviour//オンラインDBに接続し、データをロードする。その後、ロードしたデータの上位5つを取り出す
{
    public void WaitLoad()
    {
        Invoke(nameof(LoadScore), 1.0f);
    }
    public void LoadScore()
    {
        NCMBQuery<NCMBObject> query1 = new NCMBQuery<NCMBObject>("Semafo");
        query1.OrderByDescending("sema");
        query1.Limit = 1;
        query1.FindAsync((List<NCMBObject> objList, NCMBException e) =>
        {
            if (e != null)
            {
                Debug.LogWarning("error: " + e.ErrorMessage);
            }
            else
            {
                Debug.Log("sema "+objList[0]["sema"]); 


            }
        });
        int rank;
        NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject>(TuneInfo.TuneName);
        query.OrderByDescending("score");
        query.Limit = 5;
        query.FindAsync((List<NCMBObject> objList, NCMBException e) =>
        {
            if (e != null)
            {
                Debug.LogWarning("error: " + e.ErrorMessage);
            }
            else
            {
                ResultScore.ranking = -1;
                for (int i = 0; i < objList.Count; i++)
                {
                    rank = i + 1;
                    if(ResultScore.result > Convert.ToInt32(objList[i]["score"]))
                    {
                        Debug.Log(rank);
                        ResultScore.ranking = rank-1;
                        break;
                    }    

                }
                for (int i = 0; i < objList.Count; i++)
                {
                    rank = i + 1;
                    //Debug.Log("ScoreRanking " + rank + "位: " + objList[i]["score"] + objList[i]["name"]);
                    ResultScore.rankscore[i] = Convert.ToInt32(objList[i]["score"]);
                    ResultScore.rankername[i] = Convert.ToString(objList[i]["name"]);
                    //Debug.Log(ResultScore.rankername[i]);

                };

            }
        });
    }
}