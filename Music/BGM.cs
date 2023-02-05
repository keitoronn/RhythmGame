using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour//‰¹Šy‚ð—¬‚·
{
    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;
    public AudioClip sound4;
    public AudioClip sound5;

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if(TuneInfo.TuneName == "ShiningStar")
        {
            Invoke(nameof(BGM1), 3.0f);
        }
        else if (TuneInfo.TuneName == "SummerTriangle")
        {
            Invoke(nameof(BGM2), 3.0f);
        }
        else if (TuneInfo.TuneName == "Carmen")
        {
            Invoke(nameof(BGM3), 3.0f);
        }
        else if (TuneInfo.TuneName == "AlienAlien")
        {
            Invoke(nameof(BGM4), 3.0f);
        }
        else if (TuneInfo.TuneName == "Tutorial")
        {
            Invoke(nameof(BGM5), 3.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BGM1()
    {
        audioSource.PlayOneShot(sound1);
    }
    public void BGM2()
    {
        audioSource.PlayOneShot(sound2);
    }
    public void BGM3()
    {
        audioSource.PlayOneShot(sound3);
    }
    public void BGM4()
    {
        audioSource.PlayOneShot(sound4);
    }
    public void BGM5()
    {
        audioSource.PlayOneShot(sound5);
    }
}
