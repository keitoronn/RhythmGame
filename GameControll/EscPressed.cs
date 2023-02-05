using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscPressed : MonoBehaviour//ƒQ[ƒ€‰æ–Ê‚ÅEsc‚ğ‰Ÿ‚µ‚½‚Æ‚«,‹È‘I‘ğ‚É–ß‚é
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("TuneChoose");
            ResultScore.gamemode = 0;
            ResultScore.ranking = 0;
        }
    }
}
