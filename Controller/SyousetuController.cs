using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyousetuController : MonoBehaviour//è¨êﬂÇÃê¸ÇÃóéâ∫ÅAîjâÛÇÃêßå‰
{
    GameObject player;
    GameObject director;
    GameObject goodgenerator;
    GameObject SoundEffect;
    int flagS = 0;
    int flagLong = 0;
    float BPM = 158f;
    float great = 3.0f;
    float good = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -40)
        {
            Destroy(gameObject);
        }
        else
        {
            float v = 1.4f;
            transform.Translate(0, -v, 0);
        }
    }
}
