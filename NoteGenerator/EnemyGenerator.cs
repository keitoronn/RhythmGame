using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class EnemyGenerator : MonoBehaviour// �����[���̃m�[�c���@�ǂݎ�����y��CSV����Ɂ@����
{
    public GameObject Enemy;
    public GameObject Enemy2;
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
    TextAsset csvFile; // CSV�t�@�C��
    List<string[]> csvDatas = new List<string[]>(); // CSV�̒��g�����郊�X�g;
    List<float> timing = new List<float>();
    List<int> place = new List<int>();
    List<int> longnotes = new List<int>();
    List<float> noteend = new List<float>();
    // Start is called before the first frame update
    void Start()
    {
        timing = TuneInfo.Enemytiming;
        place = TuneInfo.Enemyplace;
        longnotes = TuneInfo.Enemylongnotes;
        noteend = TuneInfo.Enemynoteend;
    }

    // Update is called once per frame
    void Update()
    {
        span = 60.0f / 158.0f;
        this.delta += Time.deltaTime;
        if(bluenote < timing.Count)
        {
            if (TuneInfo.ddelta > timing[bluenote] && bluenote < timing.Count)
            {
                //this.delta = 0;
                k = place[bluenote];
                Debug.Log(TuneInfo.ddelta);


                GameObject go = Instantiate(Enemy) as GameObject;
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
                    px = -65;
                }
                else if (k == 2)
                {
                    px = 35;
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
