using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyousetuGenerator : MonoBehaviour//¬ß‚²‚Æ‚Éü‚ðo‚·
{
    public GameObject Syousetu;
    int TuneStartFlag = 0;
    float span = 100.0f;
    float span2 = 0.6f;
    float delta = 0.0f;
    float delta2 = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        span = TuneInfo.StartTime;
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        this.delta2 += Time.deltaTime;
        if (TuneInfo.ddelta > span && TuneStartFlag == 0)
        {
            TuneStartFlag = 1;
            this.delta = 0;
            span += 240.0f / TuneInfo.BPM;
            GameObject go = Instantiate(Syousetu) as GameObject;
            go.transform.position = new Vector3(0, 50.0f, 0);
        }
        else if(TuneInfo.ddelta > span && TuneStartFlag == 1)
        {
            span += 240.0f / TuneInfo.BPM;
            GameObject go = Instantiate(Syousetu) as GameObject;
            go.transform.position = new Vector3(0, 50.0f, 0);
        }
    }
}
