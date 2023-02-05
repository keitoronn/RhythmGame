using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultChange : MonoBehaviour//‹È‚ªI‚í‚Á‚½‚çƒŠƒUƒ‹ƒg‰æ–Ê‚É‘JˆÚ‚·‚é
{
    float delta = 0;
    int d=30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TuneInfo.ddelta += Time.deltaTime;
        d = d - (int)this.delta;
        if(TuneInfo.ddelta >= TuneInfo.TuneTime)
        {
            SceneManager.LoadScene("Resultscene");
            ResultScore.gamemode = 0;
            ResultScore.ranking = 0;
        }
    }

}
