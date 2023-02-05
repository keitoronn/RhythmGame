using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour//SE‚ð–Â‚ç‚·
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

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SE1()
    {
        audioSource.PlayOneShot(sound1);
    }
    public void SE2()
    {
        audioSource.PlayOneShot(sound2);
    }
    public void SE3()
    {
        audioSource.PlayOneShot(sound3);

    }
    public void SE4()
    {
        audioSource.PlayOneShot(sound4);

    }
    public void SE5()
    {
        audioSource.PlayOneShot(sound5);

    }
}
