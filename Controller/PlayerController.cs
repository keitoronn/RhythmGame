using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour//キャラクターをマウスカーソルの場所によって左右に動かす
{
    float screenwidth;
    // Start is called before the first frame update
    void Start()
    {
        //screenwidth = (float)Screen.currentResolution.width;
        screenwidth = (float)Screen.width;
    }

    //float delta = 0;
    float a = 0.015f;
    float b = 0.05f;
    float v = 0.0f;
    int flag1 = 0;
    int flag2 = 0;
    int flag3 = 0;
    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        //慣性アリ

        if (mousePosition.x<screenwidth/2) 
        {
            v = -50;                      
            if (flag1 == 0) 
            {
                Vector3 pos = transform.position;
                pos.x = -50.0f;
                transform.position = pos;

            }
        }
        /*else
        {
            flag1 = 0;
        }*/
        /*if(Input.GetKey(KeyCode.D)) 
        {
            v = 50;
            if (flag2 == 0)
            {
                Vector3 pos = transform.position;
                pos.x = 70.0f;
                transform.position = pos;
                flag2 = 1;

            }
        }
        else
        {
            flag2 = 0;
        }*/
        /*else if (mousePosition.x > 1350)
        {
            v = 50;
            if (flag3 == 0)
            {
                Vector3 pos = transform.position;
                pos.x = 70.0f;
                transform.position = pos;

            }
        }*/
        else
        {
            if (flag2 == 0)
            {
                Vector3 pos = transform.position;
                pos.x = 50.0f;
                transform.position = pos;

            }
        }
        /*else
        {
            flag3 = 0;
        } */

        //慣性なし
        /*if (Input.GetKey(KeyCode.A))
        {
            v = -0.6f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            v = 0.6f;
        }
        else
        {
            v = 0.0f;
        } */




        /*if (transform.position.x+v > -100&& transform.position.x+v < 100)
        {
            transform.Translate(v, 0, 0);
            flag = 0;

        }
        else if(flag == 0)
        {
            flag = 1;
            v = 0;
        }
        else
        {
            flag = 0;
        }  */

    }
}
