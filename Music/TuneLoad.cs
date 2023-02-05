using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TuneLoad : MonoBehaviour//譜面の情報をTuneInfoに保存する
{

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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void shining_star()
    {
        TuneInfo.TuneName = "ShiningStar";
        //////CSVファイルを用いて譜面の読み込み
        csvFile = Resources.Load("testCSV") as TextAsset; // Resouces下のCSV読み込み
        StringReader reader = new StringReader(csvFile.text);

        // , で分割しつつ一行ずつ読み込み
        // リストに追加していく
        while (reader.Peek() != -1) // reader.Peaekが-1になるまで
        {
            string line = reader.ReadLine(); // 一行ずつ読み込み
            csvDatas.Add(line.Split(',')); // , 区切りでリストに追加
        }

        // csvDatas[行][列]を指定して値を自由に取り出せる
        notesum = int.Parse(csvDatas[0][2]);
        TuneInfo.FullNote = notesum;
        TuneInfo.TuneTime = int.Parse(csvDatas[0][1]);
        TuneInfo.StartTime = float.Parse(csvDatas[1][1]) + TuneInfo.Delay;
        TuneInfo.BPM = float.Parse(csvDatas[0][0]);
        for (int i = 1; i <= notesum; i++)
        {
            if (csvDatas[i][0] == "1")
            {
                //timing.Insert(timing.Count , float.Parse(csvDatas[notesum][1]));
                //place.Insert(place.Count, int.Parse(csvDatas[notesum][2]));
                timing.Add(float.Parse(csvDatas[i][1]) + TuneInfo.Delay);
                place.Add(int.Parse(csvDatas[i][2]));
                longnotes.Add(int.Parse(csvDatas[i][3]));
                if (csvDatas[i][3] == "1")     //ロングノーツなら
                {
                    noteend.Add(float.Parse(csvDatas[i][4]) + TuneInfo.Delay);
                    TuneInfo.FullNote++;

                }
                else
                {
                    noteend.Add(0.0f);
                }
            }
        }
        TuneInfo.Lv1timing = timing;
        TuneInfo.Lv1place = place;
        TuneInfo.Lv1longnotes = longnotes;
        TuneInfo.Lv1noteend = noteend;
        timing = new List<float>();
        place = new List<int>();
        longnotes = new List<int>();
        noteend = new List<float>();
        for (int i = 1; i <= notesum; i++)
        {
            if (csvDatas[i][0] == "2")
            {
                //timing.Insert(timing.Count , float.Parse(csvDatas[notesum][1]));
                //place.Insert(place.Count, int.Parse(csvDatas[notesum][2]));
                timing.Add(float.Parse(csvDatas[i][1]) + TuneInfo.Delay);
                place.Add(int.Parse(csvDatas[i][2]));
                longnotes.Add(int.Parse(csvDatas[i][3]));
                if (csvDatas[i][3] == "1")     //ロングノーツなら
                {
                    noteend.Add(float.Parse(csvDatas[i][4]) + TuneInfo.Delay);
                    TuneInfo.FullNote++;

                }
                else
                {
                    noteend.Add(0.0f);
                }
            }
        }
        TuneInfo.Lv2timing = timing;
        TuneInfo.Lv2place = place;
        TuneInfo.Lv2longnotes = longnotes;
        TuneInfo.Lv2noteend = noteend;
        timing = new List<float>();
        place = new List<int>();
        longnotes = new List<int>();
        noteend = new List<float>();
        for (int i = 1; i <= notesum; i++)
        {
            if (csvDatas[i][0] == "0")
            {
                //timing.Insert(timing.Count , float.Parse(csvDatas[notesum][1]));
                //place.Insert(place.Count, int.Parse(csvDatas[notesum][2]));
                timing.Add(float.Parse(csvDatas[i][1]) + TuneInfo.Delay);
                place.Add(int.Parse(csvDatas[i][2]));
                longnotes.Add(int.Parse(csvDatas[i][3]));
                if (csvDatas[i][3] == "1")     //ロングノーツなら
                {
                    noteend.Add(float.Parse(csvDatas[i][4]) + TuneInfo.Delay);
                    TuneInfo.FullNote++;

                }
                else
                {
                    noteend.Add(0.0f);
                }
            }

        }
        TuneInfo.Enemytiming = timing;
        TuneInfo.Enemyplace = place;
        TuneInfo.Enemylongnotes = longnotes;
        TuneInfo.Enemynoteend = noteend;
        timing = new List<float>();
        place = new List<int>();
        longnotes = new List<int>();
        noteend = new List<float>();
        for (int i = 1; i <= notesum; i++)
        {
            if (csvDatas[i][0] == "3")
            {
                //timing.Insert(timing.Count , float.Parse(csvDatas[notesum][1]));
                //place.Insert(place.Count, int.Parse(csvDatas[notesum][2]));
                timing.Add(float.Parse(csvDatas[i][1]) + TuneInfo.Delay);
                place.Add(int.Parse(csvDatas[i][2]));
                longnotes.Add(int.Parse(csvDatas[i][3]));
                if (csvDatas[i][3] == "1")     //ロングノーツなら
                {
                    noteend.Add(float.Parse(csvDatas[i][4]) + TuneInfo.Delay);
                    TuneInfo.FullNote++;

                }
                else
                {
                    noteend.Add(0.0f);
                }
            }

        }
        TuneInfo.Lefttiming = timing;
        TuneInfo.Leftplace = place;
        TuneInfo.Leftlongnotes = longnotes;
        TuneInfo.Leftnoteend = noteend;
        timing = new List<float>();
        place = new List<int>();
        longnotes = new List<int>();
        noteend = new List<float>();
        for (int i = 1; i <= notesum; i++)
        {
            if (csvDatas[i][0] == "4")
            {
                //timing.Insert(timing.Count , float.Parse(csvDatas[notesum][1]));
                //place.Insert(place.Count, int.Parse(csvDatas[notesum][2]));
                timing.Add(float.Parse(csvDatas[i][1]) + TuneInfo.Delay);
                place.Add(int.Parse(csvDatas[i][2]));
                longnotes.Add(int.Parse(csvDatas[i][3]));
                if (csvDatas[i][3] == "1")     //ロングノーツなら
                {
                    noteend.Add(float.Parse(csvDatas[i][4]) + TuneInfo.Delay);
                    TuneInfo.FullNote++;

                }
                else
                {
                    noteend.Add(0.0f);
                }
            }

        }
        TuneInfo.Righttiming = timing;
        TuneInfo.Rightplace = place;
        TuneInfo.Rightlongnotes = longnotes;
        TuneInfo.Rightnoteend = noteend;
    }

    public void summer_triangle()
    {
        TuneInfo.TuneName = "SummerTriangle";
        //////CSVファイルを用いて譜面の読み込み
        csvFile = Resources.Load("SummerCSV") as TextAsset; // Resouces下のCSV読み込み
        StringReader reader = new StringReader(csvFile.text);

        // , で分割しつつ一行ずつ読み込み
        // リストに追加していく
        while (reader.Peek() != -1) // reader.Peaekが-1になるまで
        {
            string line = reader.ReadLine(); // 一行ずつ読み込み
            csvDatas.Add(line.Split(',')); // , 区切りでリストに追加
        }

        // csvDatas[行][列]を指定して値を自由に取り出せる
        notesum = int.Parse(csvDatas[0][2]);
        TuneInfo.FullNote = notesum;
        TuneInfo.TuneTime = int.Parse(csvDatas[0][1]);
        TuneInfo.StartTime = float.Parse(csvDatas[1][1]) + TuneInfo.Delay;
        TuneInfo.BPM = float.Parse(csvDatas[0][0]);
        for (int i = 1; i <= notesum; i++)
        {
            if (csvDatas[i][0] == "1")
            {
                //timing.Insert(timing.Count , float.Parse(csvDatas[notesum][1]));
                //place.Insert(place.Count, int.Parse(csvDatas[notesum][2]));
                timing.Add(float.Parse(csvDatas[i][1]) + TuneInfo.Delay);
                place.Add(int.Parse(csvDatas[i][2]));
                longnotes.Add(int.Parse(csvDatas[i][3]));
                if (csvDatas[i][3] == "1")     //ロングノーツなら
                {
                    noteend.Add(float.Parse(csvDatas[i][4]) + TuneInfo.Delay);
                    TuneInfo.FullNote++;

                }
                else
                {
                    noteend.Add(0.0f);
                }
            }
        }
        TuneInfo.Lv1timing = timing;
        TuneInfo.Lv1place = place;
        TuneInfo.Lv1longnotes = longnotes;
        TuneInfo.Lv1noteend = noteend;
        timing = new List<float>();
        place = new List<int>();
        longnotes = new List<int>();
        noteend = new List<float>();
        for (int i = 1; i <= notesum; i++)
        {
            if (csvDatas[i][0] == "2")
            {
                //timing.Insert(timing.Count , float.Parse(csvDatas[notesum][1]));
                //place.Insert(place.Count, int.Parse(csvDatas[notesum][2]));
                timing.Add(float.Parse(csvDatas[i][1]) + TuneInfo.Delay);
                place.Add(int.Parse(csvDatas[i][2]));
                longnotes.Add(int.Parse(csvDatas[i][3]));
                if (csvDatas[i][3] == "1")     //ロングノーツなら
                {
                    noteend.Add(float.Parse(csvDatas[i][4]) + TuneInfo.Delay);
                    TuneInfo.FullNote++;

                }
                else
                {
                    noteend.Add(0.0f);
                }
            }
        }
        TuneInfo.Lv2timing = timing;
        TuneInfo.Lv2place = place;
        TuneInfo.Lv2longnotes = longnotes;
        TuneInfo.Lv2noteend = noteend;
        timing = new List<float>();
        place = new List<int>();
        longnotes = new List<int>();
        noteend = new List<float>();
        for (int i = 1; i <= notesum; i++)
        {
            if (csvDatas[i][0] == "0")
            {
                //timing.Insert(timing.Count , float.Parse(csvDatas[notesum][1]));
                //place.Insert(place.Count, int.Parse(csvDatas[notesum][2]));
                timing.Add(float.Parse(csvDatas[i][1]) + TuneInfo.Delay);
                place.Add(int.Parse(csvDatas[i][2]));
                longnotes.Add(int.Parse(csvDatas[i][3]));
                if (csvDatas[i][3] == "1")     //ロングノーツなら
                {
                    noteend.Add(float.Parse(csvDatas[i][4]) + TuneInfo.Delay);
                    TuneInfo.FullNote++;

                }
                else
                {
                    noteend.Add(0.0f);
                }
            }

        }
        TuneInfo.Enemytiming = timing;
        TuneInfo.Enemyplace = place;
        TuneInfo.Enemylongnotes = longnotes;
        TuneInfo.Enemynoteend = noteend;
        timing = new List<float>();
        place = new List<int>();
        longnotes = new List<int>();
        noteend = new List<float>();
        for (int i = 1; i <= notesum; i++)
        {
            if (csvDatas[i][0] == "3")
            {
                //timing.Insert(timing.Count , float.Parse(csvDatas[notesum][1]));
                //place.Insert(place.Count, int.Parse(csvDatas[notesum][2]));
                timing.Add(float.Parse(csvDatas[i][1]) + TuneInfo.Delay);
                place.Add(int.Parse(csvDatas[i][2]));
                longnotes.Add(int.Parse(csvDatas[i][3]));
                if (csvDatas[i][3] == "1")     //ロングノーツなら
                {
                    noteend.Add(float.Parse(csvDatas[i][4]) + TuneInfo.Delay);
                    TuneInfo.FullNote++;

                }
                else
                {
                    noteend.Add(0.0f);
                }
            }

        }
        TuneInfo.Lefttiming = timing;
        TuneInfo.Leftplace = place;
        TuneInfo.Leftlongnotes = longnotes;
        TuneInfo.Leftnoteend = noteend;
        timing = new List<float>();
        place = new List<int>();
        longnotes = new List<int>();
        noteend = new List<float>();
        for (int i = 1; i <= notesum; i++)
        {
            if (csvDatas[i][0] == "4")
            {
                //timing.Insert(timing.Count , float.Parse(csvDatas[notesum][1]));
                //place.Insert(place.Count, int.Parse(csvDatas[notesum][2]));
                timing.Add(float.Parse(csvDatas[i][1]) + TuneInfo.Delay);
                place.Add(int.Parse(csvDatas[i][2]));
                longnotes.Add(int.Parse(csvDatas[i][3]));
                if (csvDatas[i][3] == "1")     //ロングノーツなら
                {
                    noteend.Add(float.Parse(csvDatas[i][4]) + TuneInfo.Delay);
                    TuneInfo.FullNote++;

                }
                else
                {
                    noteend.Add(0.0f);
                }
            }

        }
        TuneInfo.Righttiming = timing;
        TuneInfo.Rightplace = place;
        TuneInfo.Rightlongnotes = longnotes;
        TuneInfo.Rightnoteend = noteend;
    }

    public void Carmen()
    {
        TuneInfo.TuneName = "Carmen";
        //////CSVファイルを用いて譜面の読み込み
        csvFile = Resources.Load("CarmenCSV") as TextAsset; // Resouces下のCSV読み込み
        StringReader reader = new StringReader(csvFile.text);

        // , で分割しつつ一行ずつ読み込み
        // リストに追加していく
        while (reader.Peek() != -1) // reader.Peaekが-1になるまで
        {
            string line = reader.ReadLine(); // 一行ずつ読み込み
            csvDatas.Add(line.Split(',')); // , 区切りでリストに追加
        }

        // csvDatas[行][列]を指定して値を自由に取り出せる
        notesum = int.Parse(csvDatas[0][2]);
        TuneInfo.FullNote = notesum;
        TuneInfo.TuneTime = int.Parse(csvDatas[0][1]);
        TuneInfo.StartTime = float.Parse(csvDatas[1][1]) + TuneInfo.Delay;
        TuneInfo.BPM = float.Parse(csvDatas[0][0]);
        for (int i = 1; i <= notesum; i++)
        {
            if (csvDatas[i][0] == "1")
            {
                //timing.Insert(timing.Count , float.Parse(csvDatas[notesum][1]));
                //place.Insert(place.Count, int.Parse(csvDatas[notesum][2]));
                timing.Add(float.Parse(csvDatas[i][1]) + TuneInfo.Delay);
                place.Add(int.Parse(csvDatas[i][2]));
                longnotes.Add(int.Parse(csvDatas[i][3]));
                if (csvDatas[i][3] == "1")     //ロングノーツなら
                {
                    noteend.Add(float.Parse(csvDatas[i][4]) + TuneInfo.Delay);
                    TuneInfo.FullNote++;

                }
                else
                {
                    noteend.Add(0.0f);
                }
            }
        }
        TuneInfo.Lv1timing = timing;
        TuneInfo.Lv1place = place;
        TuneInfo.Lv1longnotes = longnotes;
        TuneInfo.Lv1noteend = noteend;
        timing = new List<float>();
        place = new List<int>();
        longnotes = new List<int>();
        noteend = new List<float>();
        for (int i = 1; i <= notesum; i++)
        {
            if (csvDatas[i][0] == "2")
            {
                //timing.Insert(timing.Count , float.Parse(csvDatas[notesum][1]));
                //place.Insert(place.Count, int.Parse(csvDatas[notesum][2]));
                timing.Add(float.Parse(csvDatas[i][1]) + TuneInfo.Delay);
                place.Add(int.Parse(csvDatas[i][2]));
                longnotes.Add(int.Parse(csvDatas[i][3]));
                if (csvDatas[i][3] == "1")     //ロングノーツなら
                {
                    noteend.Add(float.Parse(csvDatas[i][4]) + TuneInfo.Delay);
                    TuneInfo.FullNote++;

                }
                else
                {
                    noteend.Add(0.0f);
                }
            }
        }
        TuneInfo.Lv2timing = timing;
        TuneInfo.Lv2place = place;
        TuneInfo.Lv2longnotes = longnotes;
        TuneInfo.Lv2noteend = noteend;
        timing = new List<float>();
        place = new List<int>();
        longnotes = new List<int>();
        noteend = new List<float>();
        for (int i = 1; i <= notesum; i++)
        {
            if (csvDatas[i][0] == "0")
            {
                //timing.Insert(timing.Count , float.Parse(csvDatas[notesum][1]));
                //place.Insert(place.Count, int.Parse(csvDatas[notesum][2]));
                timing.Add(float.Parse(csvDatas[i][1]) + TuneInfo.Delay);
                place.Add(int.Parse(csvDatas[i][2]));
                longnotes.Add(int.Parse(csvDatas[i][3]));
                if (csvDatas[i][3] == "1")     //ロングノーツなら
                {
                    noteend.Add(float.Parse(csvDatas[i][4]) + TuneInfo.Delay);
                    TuneInfo.FullNote++;

                }
                else
                {
                    noteend.Add(0.0f);
                }
            }

        }
        TuneInfo.Enemytiming = timing;
        TuneInfo.Enemyplace = place;
        TuneInfo.Enemylongnotes = longnotes;
        TuneInfo.Enemynoteend = noteend;
        timing = new List<float>();
        place = new List<int>();
        longnotes = new List<int>();
        noteend = new List<float>();
        for (int i = 1; i <= notesum; i++)
        {
            if (csvDatas[i][0] == "3")
            {
                //timing.Insert(timing.Count , float.Parse(csvDatas[notesum][1]));
                //place.Insert(place.Count, int.Parse(csvDatas[notesum][2]));
                timing.Add(float.Parse(csvDatas[i][1]) + TuneInfo.Delay);
                place.Add(int.Parse(csvDatas[i][2]));
                longnotes.Add(int.Parse(csvDatas[i][3]));
                if (csvDatas[i][3] == "1")     //ロングノーツなら
                {
                    noteend.Add(float.Parse(csvDatas[i][4]) + TuneInfo.Delay);
                    TuneInfo.FullNote++;

                }
                else
                {
                    noteend.Add(0.0f);
                }
            }

        }
        TuneInfo.Lefttiming = timing;
        TuneInfo.Leftplace = place;
        TuneInfo.Leftlongnotes = longnotes;
        TuneInfo.Leftnoteend = noteend;
        timing = new List<float>();
        place = new List<int>();
        longnotes = new List<int>();
        noteend = new List<float>();
        for (int i = 1; i <= notesum; i++)
        {
            if (csvDatas[i][0] == "4")
            {
                //timing.Insert(timing.Count , float.Parse(csvDatas[notesum][1]));
                //place.Insert(place.Count, int.Parse(csvDatas[notesum][2]));
                timing.Add(float.Parse(csvDatas[i][1]) + TuneInfo.Delay);
                place.Add(int.Parse(csvDatas[i][2]));
                longnotes.Add(int.Parse(csvDatas[i][3]));
                if (csvDatas[i][3] == "1")     //ロングノーツなら
                {
                    noteend.Add(float.Parse(csvDatas[i][4]) + TuneInfo.Delay);
                    TuneInfo.FullNote++;

                }
                else
                {
                    noteend.Add(0.0f);
                }
            }

        }
        TuneInfo.Righttiming = timing;
        TuneInfo.Rightplace = place;
        TuneInfo.Rightlongnotes = longnotes;
        TuneInfo.Rightnoteend = noteend;
    }

    public void alien_alien()
    {
        TuneInfo.TuneName = "AlienAlien";
        //////CSVファイルを用いて譜面の読み込み
        csvFile = Resources.Load("AlienCSV") as TextAsset; // Resouces下のCSV読み込み
        StringReader reader = new StringReader(csvFile.text);

        // , で分割しつつ一行ずつ読み込み
        // リストに追加していく
        while (reader.Peek() != -1) // reader.Peaekが-1になるまで
        {
            string line = reader.ReadLine(); // 一行ずつ読み込み
            csvDatas.Add(line.Split(',')); // , 区切りでリストに追加
        }

        // csvDatas[行][列]を指定して値を自由に取り出せる
        notesum = int.Parse(csvDatas[0][2]);
        TuneInfo.FullNote = notesum;
        TuneInfo.TuneTime = int.Parse(csvDatas[0][1]);
        TuneInfo.StartTime = float.Parse(csvDatas[1][1]) + TuneInfo.Delay;
        TuneInfo.BPM = float.Parse(csvDatas[0][0]);
        for (int i = 1; i <= notesum; i++)
        {
            if (csvDatas[i][0] == "1")
            {
                //timing.Insert(timing.Count , float.Parse(csvDatas[notesum][1]));
                //place.Insert(place.Count, int.Parse(csvDatas[notesum][2]));
                timing.Add(float.Parse(csvDatas[i][1]) + TuneInfo.Delay);
                place.Add(int.Parse(csvDatas[i][2]));
                longnotes.Add(int.Parse(csvDatas[i][3]));
                if (csvDatas[i][3] == "1")     //ロングノーツなら
                {
                    noteend.Add(float.Parse(csvDatas[i][4]) + TuneInfo.Delay);
                    TuneInfo.FullNote++;

                }
                else
                {
                    noteend.Add(0.0f);
                }
            }
        }
        TuneInfo.Lv1timing = timing;
        TuneInfo.Lv1place = place;
        TuneInfo.Lv1longnotes = longnotes;
        TuneInfo.Lv1noteend = noteend;
        timing = new List<float>();
        place = new List<int>();
        longnotes = new List<int>();
        noteend = new List<float>();
        for (int i = 1; i <= notesum; i++)
        {
            if (csvDatas[i][0] == "2")
            {
                //timing.Insert(timing.Count , float.Parse(csvDatas[notesum][1]));
                //place.Insert(place.Count, int.Parse(csvDatas[notesum][2]));
                timing.Add(float.Parse(csvDatas[i][1]) + TuneInfo.Delay);
                place.Add(int.Parse(csvDatas[i][2]));
                longnotes.Add(int.Parse(csvDatas[i][3]));
                if (csvDatas[i][3] == "1")     //ロングノーツなら
                {
                    noteend.Add(float.Parse(csvDatas[i][4]) + TuneInfo.Delay);
                    TuneInfo.FullNote++;

                }
                else
                {
                    noteend.Add(0.0f);
                }
            }
        }
        TuneInfo.Lv2timing = timing;
        TuneInfo.Lv2place = place;
        TuneInfo.Lv2longnotes = longnotes;
        TuneInfo.Lv2noteend = noteend;
        timing = new List<float>();
        place = new List<int>();
        longnotes = new List<int>();
        noteend = new List<float>();
        for (int i = 1; i <= notesum; i++)
        {
            if (csvDatas[i][0] == "0")
            {
                //timing.Insert(timing.Count , float.Parse(csvDatas[notesum][1]));
                //place.Insert(place.Count, int.Parse(csvDatas[notesum][2]));
                timing.Add(float.Parse(csvDatas[i][1]) + TuneInfo.Delay);
                place.Add(int.Parse(csvDatas[i][2]));
                longnotes.Add(int.Parse(csvDatas[i][3]));
                if (csvDatas[i][3] == "1")     //ロングノーツなら
                {
                    noteend.Add(float.Parse(csvDatas[i][4]) + TuneInfo.Delay);
                    TuneInfo.FullNote++;

                }
                else
                {
                    noteend.Add(0.0f);
                }
            }

        }
        TuneInfo.Enemytiming = timing;
        TuneInfo.Enemyplace = place;
        TuneInfo.Enemylongnotes = longnotes;
        TuneInfo.Enemynoteend = noteend;
        timing = new List<float>();
        place = new List<int>();
        longnotes = new List<int>();
        noteend = new List<float>();
        for (int i = 1; i <= notesum; i++)
        {
            if (csvDatas[i][0] == "3")
            {
                //timing.Insert(timing.Count , float.Parse(csvDatas[notesum][1]));
                //place.Insert(place.Count, int.Parse(csvDatas[notesum][2]));
                timing.Add(float.Parse(csvDatas[i][1]) + TuneInfo.Delay);
                place.Add(int.Parse(csvDatas[i][2]));
                longnotes.Add(int.Parse(csvDatas[i][3]));
                if (csvDatas[i][3] == "1")     //ロングノーツなら
                {
                    noteend.Add(float.Parse(csvDatas[i][4]) + TuneInfo.Delay);
                    TuneInfo.FullNote++;

                }
                else
                {
                    noteend.Add(0.0f);
                }
            }

        }
        TuneInfo.Lefttiming = timing;
        TuneInfo.Leftplace = place;
        TuneInfo.Leftlongnotes = longnotes;
        TuneInfo.Leftnoteend = noteend;
        timing = new List<float>();
        place = new List<int>();
        longnotes = new List<int>();
        noteend = new List<float>();
        for (int i = 1; i <= notesum; i++)
        {
            if (csvDatas[i][0] == "4")
            {
                //timing.Insert(timing.Count , float.Parse(csvDatas[notesum][1]));
                //place.Insert(place.Count, int.Parse(csvDatas[notesum][2]));
                timing.Add(float.Parse(csvDatas[i][1]) + TuneInfo.Delay);
                place.Add(int.Parse(csvDatas[i][2]));
                longnotes.Add(int.Parse(csvDatas[i][3]));
                if (csvDatas[i][3] == "1")     //ロングノーツなら
                {
                    noteend.Add(float.Parse(csvDatas[i][4]) + TuneInfo.Delay);
                    TuneInfo.FullNote++;

                }
                else
                {
                    noteend.Add(0.0f);
                }
            }

        }
        TuneInfo.Righttiming = timing;
        TuneInfo.Rightplace = place;
        TuneInfo.Rightlongnotes = longnotes;
        TuneInfo.Rightnoteend = noteend;
    }

    public void Tutorial()
    {
        TuneInfo.TuneName = "Tutorial";
        //////CSVファイルを用いて譜面の読み込み
        csvFile = Resources.Load("TutorialCSV") as TextAsset; // Resouces下のCSV読み込み
        StringReader reader = new StringReader(csvFile.text);

        // , で分割しつつ一行ずつ読み込み
        // リストに追加していく
        while (reader.Peek() != -1) // reader.Peaekが-1になるまで
        {
            string line = reader.ReadLine(); // 一行ずつ読み込み
            csvDatas.Add(line.Split(',')); // , 区切りでリストに追加
        }

        // csvDatas[行][列]を指定して値を自由に取り出せる
        notesum = int.Parse(csvDatas[0][2]);
        TuneInfo.FullNote = notesum;
        TuneInfo.TuneTime = int.Parse(csvDatas[0][1]);
        TuneInfo.StartTime = float.Parse(csvDatas[1][1]) + TuneInfo.Delay;
        TuneInfo.BPM = float.Parse(csvDatas[0][0]);
        for (int i = 1; i <= notesum; i++)
        {
            if (csvDatas[i][0] == "1")
            {
                //timing.Insert(timing.Count , float.Parse(csvDatas[notesum][1]));
                //place.Insert(place.Count, int.Parse(csvDatas[notesum][2]));
                timing.Add(float.Parse(csvDatas[i][1]) + TuneInfo.Delay);
                place.Add(int.Parse(csvDatas[i][2]));
                longnotes.Add(int.Parse(csvDatas[i][3]));
                if (csvDatas[i][3] == "1")     //ロングノーツなら
                {
                    noteend.Add(float.Parse(csvDatas[i][4]) + TuneInfo.Delay);
                    TuneInfo.FullNote++;

                }
                else
                {
                    noteend.Add(0.0f);
                }
            }
        }
        TuneInfo.Lv1timing = timing;
        TuneInfo.Lv1place = place;
        TuneInfo.Lv1longnotes = longnotes;
        TuneInfo.Lv1noteend = noteend;
        timing = new List<float>();
        place = new List<int>();
        longnotes = new List<int>();
        noteend = new List<float>();
        for (int i = 1; i <= notesum; i++)
        {
            if (csvDatas[i][0] == "2")
            {
                //timing.Insert(timing.Count , float.Parse(csvDatas[notesum][1]));
                //place.Insert(place.Count, int.Parse(csvDatas[notesum][2]));
                timing.Add(float.Parse(csvDatas[i][1]) + TuneInfo.Delay);
                place.Add(int.Parse(csvDatas[i][2]));
                longnotes.Add(int.Parse(csvDatas[i][3]));
                if (csvDatas[i][3] == "1")     //ロングノーツなら
                {
                    noteend.Add(float.Parse(csvDatas[i][4]) + TuneInfo.Delay);
                    TuneInfo.FullNote++;

                }
                else
                {
                    noteend.Add(0.0f);
                }
            }
        }
        TuneInfo.Lv2timing = timing;
        TuneInfo.Lv2place = place;
        TuneInfo.Lv2longnotes = longnotes;
        TuneInfo.Lv2noteend = noteend;
        timing = new List<float>();
        place = new List<int>();
        longnotes = new List<int>();
        noteend = new List<float>();
        for (int i = 1; i <= notesum; i++)
        {
            if (csvDatas[i][0] == "0")
            {
                //timing.Insert(timing.Count , float.Parse(csvDatas[notesum][1]));
                //place.Insert(place.Count, int.Parse(csvDatas[notesum][2]));
                timing.Add(float.Parse(csvDatas[i][1]) + TuneInfo.Delay);
                place.Add(int.Parse(csvDatas[i][2]));
                longnotes.Add(int.Parse(csvDatas[i][3]));
                if (csvDatas[i][3] == "1")     //ロングノーツなら
                {
                    noteend.Add(float.Parse(csvDatas[i][4]) + TuneInfo.Delay);
                    TuneInfo.FullNote++;

                }
                else
                {
                    noteend.Add(0.0f);
                }
            }

        }
        TuneInfo.Enemytiming = timing;
        TuneInfo.Enemyplace = place;
        TuneInfo.Enemylongnotes = longnotes;
        TuneInfo.Enemynoteend = noteend;
        timing = new List<float>();
        place = new List<int>();
        longnotes = new List<int>();
        noteend = new List<float>();
        for (int i = 1; i <= notesum; i++)
        {
            if (csvDatas[i][0] == "3")
            {
                //timing.Insert(timing.Count , float.Parse(csvDatas[notesum][1]));
                //place.Insert(place.Count, int.Parse(csvDatas[notesum][2]));
                timing.Add(float.Parse(csvDatas[i][1]) + TuneInfo.Delay);
                place.Add(int.Parse(csvDatas[i][2]));
                longnotes.Add(int.Parse(csvDatas[i][3]));
                if (csvDatas[i][3] == "1")     //ロングノーツなら
                {
                    noteend.Add(float.Parse(csvDatas[i][4]) + TuneInfo.Delay);
                    TuneInfo.FullNote++;

                }
                else
                {
                    noteend.Add(0.0f);
                }
            }

        }
        TuneInfo.Lefttiming = timing;
        TuneInfo.Leftplace = place;
        TuneInfo.Leftlongnotes = longnotes;
        TuneInfo.Leftnoteend = noteend;
        timing = new List<float>();
        place = new List<int>();
        longnotes = new List<int>();
        noteend = new List<float>();
        for (int i = 1; i <= notesum; i++)
        {
            if (csvDatas[i][0] == "4")
            {
                //timing.Insert(timing.Count , float.Parse(csvDatas[notesum][1]));
                //place.Insert(place.Count, int.Parse(csvDatas[notesum][2]));
                timing.Add(float.Parse(csvDatas[i][1]) + TuneInfo.Delay);
                place.Add(int.Parse(csvDatas[i][2]));
                longnotes.Add(int.Parse(csvDatas[i][3]));
                if (csvDatas[i][3] == "1")     //ロングノーツなら
                {
                    noteend.Add(float.Parse(csvDatas[i][4]) + TuneInfo.Delay);
                    TuneInfo.FullNote++;

                }
                else
                {
                    noteend.Add(0.0f);
                }
            }

        }
        TuneInfo.Righttiming = timing;
        TuneInfo.Rightplace = place;
        TuneInfo.Rightlongnotes = longnotes;
        TuneInfo.Rightnoteend = noteend;
    }
}
