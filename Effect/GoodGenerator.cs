using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodGenerator : MonoBehaviour//Good,Greatの文字を出す
{
    public GameObject canvas;
    public GameObject text;//キャンバス
    public GameObject text2;//キャンバス
    float screenwidth;
    float screenheight;
    // Start is called before the first frame update
    void Start()
    {
        //screenwidth = (float)Screen.currentResolution.width;
        //screenheight = (float)Screen.currentResolution.height;
        screenwidth = (float)Screen.width;
        screenheight = (float)Screen.height;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoodCanvasGenarate(float x)
    {
        GameObject go = Instantiate(text) as GameObject;
        go.transform.SetParent(canvas.transform, false);
        go.transform.localPosition = new Vector3(x, -30 , 0);
    }
    public void GreatCanvasGenarate(float x)
    {
        GameObject go = Instantiate(text2) as GameObject;
        go.transform.SetParent(canvas.transform, false);
        go.transform.localPosition = new Vector3(x, -30, 0);
    }
}
