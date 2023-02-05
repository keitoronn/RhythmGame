using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeftSlideController : MonoBehaviour//左スライドノーツの落下、判定、削除の管理
{
    GameObject director;
    GameObject goodgenerator;
    GameObject SoundEffect;
    int flagS = 0;
    int flagLong = 0;
    float BPM = 158f;
    float great = 9.0f;
    float good = 5.0f;
    float mousepositionbefore = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.director = GameObject.Find("GameDirector");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 p1 = transform.position;
        Vector3 mousePosition = Input.mousePosition;
        float r1 = 2.5f;
        float r2 = 4.5f;
        float size = 1;
        float d = Mathf.Abs(p1.y - (-34) - ((size) / 2));
        float dl = Mathf.Abs(p1.y - (-34) + ((size) / 2));
        float longd = p1.y + ((size) / 2);
        float mouseslide = mousePosition.x - mousepositionbefore;
        mousepositionbefore = mousePosition.x;
        if (transform.position.y < -40 && size == 1)
        {
            director.GetComponent<GameDirector>().ComboReset();
            director.GetComponent<GameDirector>().MaxShow1();
            Destroy(gameObject);
        }
        else if (longd < -40)
        {
            director.GetComponent<GameDirector>().ComboReset();
            Destroy(gameObject);
        }
        else
        {
            float v = 1.4f;
            transform.Translate(0, -v, 0);
        }
        if (mouseslide < 0 && size == 1)
        {
            if (flagS == 0 && d <= great)
            {
                director.GetComponent<GameDirector>().ScoreUp1();
                director.GetComponent<GameDirector>().ComboUp();
                director.GetComponent<GameDirector>().MaxShow1();
                director.GetComponent<GameDirector>().GreatShow(p1.x);
                director.GetComponent<GameDirector>().SEfive();
                Destroy(gameObject);
            }

            flagS = 1;
        }
        else if (mouseslide < 0 && size > 1 && flagLong == 0)
        {
            if (flagS == 0 && d <= great)
            {
                director.GetComponent<GameDirector>().ScoreUp1();
                director.GetComponent<GameDirector>().ComboUp();
                goodgenerator.GetComponent<GoodGenerator>().GreatCanvasGenarate(p1.x);
                SoundEffect.GetComponent<SE>().SE1();
            }
            else if (flagS == 0 && d <= good)
            {
                director.GetComponent<GameDirector>().ScoreUp1();
                director.GetComponent<GameDirector>().ComboUp();
                goodgenerator.GetComponent<GoodGenerator>().GoodCanvasGenarate(p1.x);
                SoundEffect.GetComponent<SE>().SE4();
            }

            flagS = 1;
            flagLong = 1;
        }
        else if (mouseslide < 0 && flagLong == 1)
        {
            if (dl <= great)
            {
                director.GetComponent<GameDirector>().ScoreUp1();
                director.GetComponent<GameDirector>().ComboUp();
                goodgenerator.GetComponent<GoodGenerator>().GreatCanvasGenarate(p1.x);
                SoundEffect.GetComponent<SE>().SE1();
                Destroy(gameObject);
            }

            flagLong = 0;
        }
        else
        {
            flagS = 0;
            flagLong = 0;
        }
    }
}
