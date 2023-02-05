using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateQuit : MonoBehaviour
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
        this.delta += Time.deltaTime;
        d = d - (int)this.delta;
        if(this.delta >= 30.0f){
            SceneManager.LoadScene("CreateFinish");
            ResultScore.gamemode = 0;
            ResultScore.ranking = 0;
        }
    }

}
