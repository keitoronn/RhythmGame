using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFnotes : MonoBehaviour
{
    GameObject player;
    GameObject director;
    GameObject SoundEffect;
    int flagF = 0;
    int flagLong = 0;
    float BPM = 158f;
    float great = 3.0f;
    float delta = 0.0f;
    float clap = 0.0f;
    float notesize = 0.0f;
    List<float> timing = new List<float>();
    // Start is called before the first frame update
    void Start()
    {
        this.SoundEffect = GameObject.Find("SE");
        clap = 28.0f / BPM;
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        this.notesize += Time.deltaTime;
        if (Input.GetKey(KeyCode.F))
        {
            if(flagF == 0)
            {
                CreateData.Enemytiming.Add(this.delta);
                //SoundEffect.GetComponent<SE>().SE3();
                flagF = 1;
            }
        }
        else
        {
            flagF = 0;
        }

        /*else if (Input.GetKey(KeyCode.F) && notesize >= clap)
        {

        }*/

    }
}
