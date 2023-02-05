using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Lv1Generator : MonoBehaviour// 中央レーンのノーツを　読み取った楽譜CSVを基に　生成
{
    public GameObject Lv1;
    GameObject CountText;
    float span = 0.5f;
    float delta = 0;
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
        timing = TuneInfo.Lv1timing;
        place = TuneInfo.Lv1place;
        longnotes = TuneInfo.Lv1longnotes;
        noteend = TuneInfo.Lv1noteend;
    }

    // Update is called once per frame
    void Update()
    {
        span = 60.0f / 158.0f;
        this.delta += Time.deltaTime;
        if(bluenote < timing.Count)
        {
            if (TuneInfo.ddelta > timing[bluenote])
            {
                //this.delta = 0;
                k = place[bluenote];


                GameObject go = Instantiate(Lv1) as GameObject;
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
                    px = 0;
                }
                k++;
                go.transform.position = new Vector3(px, 50.0f + (hoge.y - 1) / 2, 0);
                bluenote++;
            }
        }
        

    }
}
