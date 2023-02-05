using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushEffectGenerator : MonoBehaviour//Good,Greatのエフェクトを表示
{
    public GameObject PushEffectGreat;
    public GameObject PushEffectGood;
    public GameObject PushEffectNormal;
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

    public void GreatPushEffectGenarate(float x)
    {
        GameObject go = Instantiate(PushEffectGreat) as GameObject;
        go.transform.localPosition = new Vector3(x, 0, 0);
    }
    public void GoodPushEffectGenarate(float x)
    {
        GameObject go = Instantiate(PushEffectGood) as GameObject;
        go.transform.localPosition = new Vector3(x, 0, 0);
    }
    public void NormalPushEffectGenarate(float x)
    {
        GameObject go = Instantiate(PushEffectNormal) as GameObject;
        go.transform.localPosition = new Vector3(x, 0, 0);
    }
}
