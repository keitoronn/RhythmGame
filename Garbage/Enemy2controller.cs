using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy2controller : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 47.4)
        {
            transform.Translate(0, -0.01f, 0);
        }
        else
        {
            transform.Translate(0, -0.6f, 0);
        }

        if (transform.position.y < -50)
        {
            Destroy(gameObject);
        }
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 2.5f;
        float r2 = 4.5f;
        if (d < r1 + r2)
        {
            SceneManager.LoadScene("Resultscene");
            ResultScore.gamemode = 0;
        }
    }
}
