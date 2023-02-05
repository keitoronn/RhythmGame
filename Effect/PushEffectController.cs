using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushEffectController : MonoBehaviour
{

    float delta = 0;
    float span = 0.1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        this.delta += Time.deltaTime;
        if (this.delta > span)
        {
            Destroy(gameObject);
        }
    }
}
