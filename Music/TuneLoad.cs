using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TuneLoad : MonoBehaviour//���ʂ̏���TuneInfo�ɕۑ�����
{

    int notesum = 0;
    TextAsset csvFile; // CSV�t�@�C��
    List<string[]> csvDatas = new List<string[]>(); // CSV�̒��g�����郊�X�g;
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
        //////CSV�t�@�C����p���ĕ��ʂ̓ǂݍ���
        csvFile = Resources.Load("testCSV") as TextAsset; // Resouces����CSV�ǂݍ���
        StringReader reader = new StringReader(csvFile.text);

        // , �ŕ�������s���ǂݍ���
        // ���X�g�ɒǉ����Ă���
        while (reader.Peek() != -1) // reader.Peaek��-1�ɂȂ�܂�
        {
            string line = reader.ReadLine(); // ��s���ǂݍ���
            csvDatas.Add(line.Split(',')); // , ��؂�Ń��X�g�ɒǉ�
        }

        // csvDatas[�s][��]���w�肵�Ēl�����R�Ɏ��o����
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
                if (csvDatas[i][3] == "1")     //�����O�m�[�c�Ȃ�
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
                if (csvDatas[i][3] == "1")     //�����O�m�[�c�Ȃ�
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
                if (csvDatas[i][3] == "1")     //�����O�m�[�c�Ȃ�
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
                if (csvDatas[i][3] == "1")     //�����O�m�[�c�Ȃ�
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
                if (csvDatas[i][3] == "1")     //�����O�m�[�c�Ȃ�
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
        //////CSV�t�@�C����p���ĕ��ʂ̓ǂݍ���
        csvFile = Resources.Load("SummerCSV") as TextAsset; // Resouces����CSV�ǂݍ���
        StringReader reader = new StringReader(csvFile.text);

        // , �ŕ�������s���ǂݍ���
        // ���X�g�ɒǉ����Ă���
        while (reader.Peek() != -1) // reader.Peaek��-1�ɂȂ�܂�
        {
            string line = reader.ReadLine(); // ��s���ǂݍ���
            csvDatas.Add(line.Split(',')); // , ��؂�Ń��X�g�ɒǉ�
        }

        // csvDatas[�s][��]���w�肵�Ēl�����R�Ɏ��o����
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
                if (csvDatas[i][3] == "1")     //�����O�m�[�c�Ȃ�
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
                if (csvDatas[i][3] == "1")     //�����O�m�[�c�Ȃ�
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
                if (csvDatas[i][3] == "1")     //�����O�m�[�c�Ȃ�
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
                if (csvDatas[i][3] == "1")     //�����O�m�[�c�Ȃ�
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
                if (csvDatas[i][3] == "1")     //�����O�m�[�c�Ȃ�
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
        //////CSV�t�@�C����p���ĕ��ʂ̓ǂݍ���
        csvFile = Resources.Load("CarmenCSV") as TextAsset; // Resouces����CSV�ǂݍ���
        StringReader reader = new StringReader(csvFile.text);

        // , �ŕ�������s���ǂݍ���
        // ���X�g�ɒǉ����Ă���
        while (reader.Peek() != -1) // reader.Peaek��-1�ɂȂ�܂�
        {
            string line = reader.ReadLine(); // ��s���ǂݍ���
            csvDatas.Add(line.Split(',')); // , ��؂�Ń��X�g�ɒǉ�
        }

        // csvDatas[�s][��]���w�肵�Ēl�����R�Ɏ��o����
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
                if (csvDatas[i][3] == "1")     //�����O�m�[�c�Ȃ�
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
                if (csvDatas[i][3] == "1")     //�����O�m�[�c�Ȃ�
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
                if (csvDatas[i][3] == "1")     //�����O�m�[�c�Ȃ�
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
                if (csvDatas[i][3] == "1")     //�����O�m�[�c�Ȃ�
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
                if (csvDatas[i][3] == "1")     //�����O�m�[�c�Ȃ�
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
        //////CSV�t�@�C����p���ĕ��ʂ̓ǂݍ���
        csvFile = Resources.Load("AlienCSV") as TextAsset; // Resouces����CSV�ǂݍ���
        StringReader reader = new StringReader(csvFile.text);

        // , �ŕ�������s���ǂݍ���
        // ���X�g�ɒǉ����Ă���
        while (reader.Peek() != -1) // reader.Peaek��-1�ɂȂ�܂�
        {
            string line = reader.ReadLine(); // ��s���ǂݍ���
            csvDatas.Add(line.Split(',')); // , ��؂�Ń��X�g�ɒǉ�
        }

        // csvDatas[�s][��]���w�肵�Ēl�����R�Ɏ��o����
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
                if (csvDatas[i][3] == "1")     //�����O�m�[�c�Ȃ�
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
                if (csvDatas[i][3] == "1")     //�����O�m�[�c�Ȃ�
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
                if (csvDatas[i][3] == "1")     //�����O�m�[�c�Ȃ�
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
                if (csvDatas[i][3] == "1")     //�����O�m�[�c�Ȃ�
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
                if (csvDatas[i][3] == "1")     //�����O�m�[�c�Ȃ�
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
        //////CSV�t�@�C����p���ĕ��ʂ̓ǂݍ���
        csvFile = Resources.Load("TutorialCSV") as TextAsset; // Resouces����CSV�ǂݍ���
        StringReader reader = new StringReader(csvFile.text);

        // , �ŕ�������s���ǂݍ���
        // ���X�g�ɒǉ����Ă���
        while (reader.Peek() != -1) // reader.Peaek��-1�ɂȂ�܂�
        {
            string line = reader.ReadLine(); // ��s���ǂݍ���
            csvDatas.Add(line.Split(',')); // , ��؂�Ń��X�g�ɒǉ�
        }

        // csvDatas[�s][��]���w�肵�Ēl�����R�Ɏ��o����
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
                if (csvDatas[i][3] == "1")     //�����O�m�[�c�Ȃ�
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
                if (csvDatas[i][3] == "1")     //�����O�m�[�c�Ȃ�
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
                if (csvDatas[i][3] == "1")     //�����O�m�[�c�Ȃ�
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
                if (csvDatas[i][3] == "1")     //�����O�m�[�c�Ȃ�
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
                if (csvDatas[i][3] == "1")     //�����O�m�[�c�Ȃ�
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
