using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TargetContoroller : MonoBehaviour//中央ノーツの落下、判定、削除の管理
{
    GameObject player;
    GameObject director;
    GameObject goodgenerator;
    GameObject SoundEffect;
    int flagS = 0;
    int flagLong = 0;
    int flagpress = 0;
    float BPM = 158f;
    float great = 3.0f;
    float good = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");  //playerさがし
        this.director = GameObject.Find("GameDirector");

    }

    // Update is called once per frame
    void Update()
    {
        /*if(transform.position.y > 47.4)
        {
            transform.Translate(0, -0.01f, 0);
        }
        else
        {
            transform.Translate(0, -2.0f, 0);
        }*/

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float r1 = 2.5f;
        float r2 = 4.5f;
        float size = this.transform.localScale.y;
        float d = Mathf.Abs(p1.y - (-34) - ((size) / 2));
        float dl = Mathf.Abs(p1.y - (-34) + ((size) / 2));
        float longd = p1.y + ((size) / 2);
        if (transform.position.y < -40 && size == 1)
        {
            director.GetComponent<GameDirector>().ComboReset();
            director.GetComponent<GameDirector>().MaxShow1();
            Destroy(gameObject);
        }
        else if (longd < -40)
        {
            director.GetComponent<GameDirector>().ComboReset();
            director.GetComponent<GameDirector>().MaxShow2();
            Destroy(gameObject);
        }
        else
        {
            float v = 1.4f;
            transform.Translate(0, -v, 0);
        }
        //if ((Input.GetKey(KeyCode.D) || Input.GetMouseButton(0)) && size == 1)
        if ((Input.GetKey(KeyCode.S) || Input.GetMouseButton(0)) && size == 1)
        {
            if(flagS == 0 && d <= great && transform.position.x == this.player.transform.position.x)
            {
                director.GetComponent<GameDirector>().ScoreUp1();
                director.GetComponent<GameDirector>().ComboUp();
                director.GetComponent<GameDirector>().GreatShow(p1.x);
                director.GetComponent<GameDirector>().PushGreatShow(p1.x);
                director.GetComponent<GameDirector>().SEthree();
                director.GetComponent<GameDirector>().MaxShow1();
                Destroy(gameObject);
            }
            else if (flagS == 0 && d <= good && transform.position.x == this.player.transform.position.x)
            {
                director.GetComponent<GameDirector>().ScoreUp2();
                director.GetComponent<GameDirector>().ComboUp();
                director.GetComponent<GameDirector>().GoodShow(p1.x);
                director.GetComponent<GameDirector>().PushGoodShow(p1.x);
                director.GetComponent<GameDirector>().SEfour();
                director.GetComponent<GameDirector>().MaxShow1();
                Destroy(gameObject);
            }

            flagS = 1;
        }
        //else if ((Input.GetKey(KeyCode.D) || Input.GetMouseButton(0)) && size > 1 && flagLong == 0)
        else if ((Input.GetKey(KeyCode.S) || Input.GetMouseButton(0)) && size > 1 && flagLong == 0)
        {
            if (flagS == 0 && d <= great && transform.position.x == this.player.transform.position.x)
            {
                director.GetComponent<GameDirector>().ScoreUp1();
                director.GetComponent<GameDirector>().ComboUp();
                director.GetComponent<GameDirector>().GreatShow(p1.x);
                director.GetComponent<GameDirector>().PushGreatShow(p1.x);
                director.GetComponent<GameDirector>().SEthree();
                gameObject.GetComponent<Renderer>().material.color = new Color(0, 255, 255);
                flagpress = 1;
            }
            else if (flagS == 0 && d <= good && transform.position.x == this.player.transform.position.x)
            {
                director.GetComponent<GameDirector>().ScoreUp2();
                director.GetComponent<GameDirector>().ComboUp();
                director.GetComponent<GameDirector>().GoodShow(p1.x);
                director.GetComponent<GameDirector>().PushGoodShow(p1.x);
                director.GetComponent<GameDirector>().SEfour();
                gameObject.GetComponent<Renderer>().material.color = new Color(0, 255, 255);
                flagpress = 1;
            }
            else if (flagS == 0 && p1.y - ((size) / 2) < -34 && p1.y + ((size) / 2) > -29 && transform.position.x == this.player.transform.position.x)
            {
                gameObject.GetComponent<Renderer>().material.color = new Color(0, 255, 255);
            }

            flagS = 1;
            flagLong = 1;
        }
        //else if ((Input.GetKey(KeyCode.D) || Input.GetMouseButton(0)) && flagLong == 1)
        else if ((Input.GetKey(KeyCode.S) || Input.GetMouseButton(0)) && flagLong == 1)
        {
            if (dl <= great && transform.position.x == this.player.transform.position.x)
            {
                director.GetComponent<GameDirector>().ScoreUp1();
                director.GetComponent<GameDirector>().ComboUp();
                director.GetComponent<GameDirector>().GreatShow(p1.x);
                director.GetComponent<GameDirector>().PushGreatShow(p1.x);
                director.GetComponent<GameDirector>().MaxShow2();
                director.GetComponent<GameDirector>().MaxShow1();
                director.GetComponent<GameDirector>().SEthree();
                Destroy(gameObject);
            }

            flagLong = 0;
        }
        else if (flagpress == 1)
        {
            if (dl <= great && transform.position.x == this.player.transform.position.x)
            {
                director.GetComponent<GameDirector>().ScoreUp1();
                director.GetComponent<GameDirector>().ComboUp();
                director.GetComponent<GameDirector>().GreatShow(p1.x);
                director.GetComponent<GameDirector>().PushGreatShow(p1.x);
                director.GetComponent<GameDirector>().MaxShow2();
                director.GetComponent<GameDirector>().SEthree();
                Destroy(gameObject);
            }
            else if (dl <= great && transform.position.x == this.player.transform.position.x)
            {
                director.GetComponent<GameDirector>().ScoreUp2();
                director.GetComponent<GameDirector>().ComboUp();
                director.GetComponent<GameDirector>().GoodShow(p1.x);
                director.GetComponent<GameDirector>().PushGoodShow(p1.x);
                director.GetComponent<GameDirector>().SEfour();
                director.GetComponent<GameDirector>().MaxShow2();
                Destroy(gameObject);
            }
            else
            {
                director.GetComponent<GameDirector>().ComboReset();
                director.GetComponent<GameDirector>().MaxShow2();
                Destroy(gameObject);
            }
        }
        else
        {
            flagS = 0;
            flagLong = 0;
        }
        /*if (d < r1 + r2)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().ScoreUp1();
            GameObject SoundEffect = GameObject.Find("SE");
            SoundEffect.GetComponent<SE>().SE1();
            Destroy(gameObject);
        }*/
    }
}
