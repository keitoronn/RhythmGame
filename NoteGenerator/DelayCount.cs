using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DelayCount : MonoBehaviour//ノーツの生成タイミングをずらす
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public int score = 0;
    public TextMeshProUGUI delayText;
    public int gameflag = 0;

    public void AddDelay1()
    {
        TuneInfo.Delay += 0.01f;
    }

    public void SubDelay1()
    {
        TuneInfo.Delay -= 0.01f;


    }

    // Update is called once per frame
    void Update()
    {
        delayText.text = (Mathf.RoundToInt(TuneInfo.Delay * 1000)).ToString() + " ms";
    }
}
