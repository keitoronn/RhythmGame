using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Text;

public class EnemyNodeShow : MonoBehaviour
{
    // Start is called before the first frame update
    private float time;
    private StreamWriter sw;

    GameObject SaveCsv;
    SampleSaveCsvScript SampleSaveCsvScript;
    void Start()
    {
        //sw = new StreamWriter(@"SaveData.csv", true, Encoding.GetEncoding("Shift_JIS"));
        sw = new StreamWriter("./SaveData.csv", true, Encoding.GetEncoding("Shift_JIS"));
        for (int i = 0;i< CreateData.Enemytiming.Count; i++)
        {
            /*if (i >= 0)
            {
                CreateData.Enemytiming[i] -= 0.7f;
                float q = CreateData.Enemytiming[i] / (158.0f / 480.0f);
                CreateData.Enemytiming[i] = (158.0f / 480.0f) * (float)Math.Round(q, MidpointRounding.AwayFromZero);
                CreateData.Enemytiming[i] += 0.7f;
            }*/
            CreateData.Enemytiming[i] -= 1.0f;
            this.SaveData("0", CreateData.Enemytiming[i].ToString(), " ");
        }
        for (int i = 0; i < CreateData.Lv1timing.Count; i++)
        {
            /*if (i >= 0)
            {
                CreateData.Lv1timing[i] -= 0.7f;
                float q = CreateData.Lv1timing[i] / (158.0f / 480.0f);
                CreateData.Lv1timing[i] = (158.0f / 480.0f) * (float)Math.Round(q, MidpointRounding.AwayFromZero);
                CreateData.Lv1timing[i] += 0.7f;
            }*/
            CreateData.Lv1timing[i] -= 1.0f;
            this.SaveData("1", CreateData.Lv1timing[i].ToString(), " ");
        }
        for (int i = 0; i < CreateData.Lv2timing.Count; i++)
        {
            /*if (i >= 0)
            {
                CreateData.Lv2timing[i] -= 0.7f;
                float q = CreateData.Lv2timing[i] / (158.0f / 480.0f);
                CreateData.Lv2timing[i] = (158.0f / 480.0f) * (float)Math.Round(q, MidpointRounding.AwayFromZero);
                CreateData.Lv2timing[i] += 0.7f;
            }*/
            CreateData.Lv2timing[i] -= 1.0f;
            this.SaveData("2", CreateData.Lv2timing[i].ToString(), " ");
        }
        sw.Close();
    }

    public void SaveData(string txt1, string txt2, string txt3)
    {
        string[] s1 = { txt1, txt2, txt3 };
        string s2 = string.Join(",", s1);
        sw.WriteLine(s2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
