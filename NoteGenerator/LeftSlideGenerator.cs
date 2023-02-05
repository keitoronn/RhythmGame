using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LeftSlideGenerator : MonoBehaviour// 左スライドノーツを　読み取った楽譜CSVを基に　生成
{
    public GameObject LeftSlide;
    GameObject player;
    GameObject CountText;
    float span = 0.4f;
    float span2 = 0.6f;
    float delta = 0.0f;
    float delta2 = 0;
    public int gameflag = 0;
    int k = 0;
    int bluenote = 0;
    int notesum = 0;
    TextAsset csvFile; // CSVファイル
    List<string[]> csvDatas = new List<string[]>(); // CSVの中身を入れるリスト;
    List<float> timing = new List<float>();
    List<int> place = new List<int>();
    List<int> longnotes = new List<int>();
    List<float> noteend = new List<float>();
    // Start is called before the first frame update
    void Start()
    {
        timing = TuneInfo.Lefttiming;
        place = TuneInfo.Leftplace;
        longnotes = TuneInfo.Leftlongnotes;
        noteend = TuneInfo.Leftnoteend;

    }

    // Update is called once per frame
    void Update()
    {
        span = 60.0f / 158.0f;
        this.delta += Time.deltaTime;
        if (bluenote < timing.Count)
        {
            if (TuneInfo.ddelta > timing[bluenote] && bluenote < timing.Count)
            {
                //this.delta = 0;
                k = place[bluenote];


                GameObject go = Instantiate(LeftSlide) as GameObject;
                int size = 0;
                Vector3 hoge = new Vector3(10.0f, 1.0f, 1.0f);
                if (longnotes[bluenote] == 1)
                {
                    hoge = go.transform.localScale;
                    float v = 1.4f;
                    hoge.y = (noteend[bluenote] - timing[bluenote]) * 60f * v + 1;
                    go.transform.localScale = hoge;
                }

                int px = Random.Range(0, 8);
                if (k == 0)
                {
                    px = -50;
                }
                else if (k == 2)
                {
                    px = 50;
                }
                else
                {
                    px = -15;
                }
                k++;
                go.transform.position = new Vector3(px, 50.0f + (hoge.y - 1) / 2, 0);
                bluenote++;
            }
        }
    }
}
