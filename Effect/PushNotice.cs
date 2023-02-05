using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushNotice : MonoBehaviour//各キーを押している間,エフェクトを表示
{
    public GameObject left1;
    public GameObject left2;
    public GameObject left3;
    public GameObject right1;
    public GameObject right2;
    public GameObject right3;
    GameObject player;
    GameObject director;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");  //playerさがし
        this.director = GameObject.Find("GameDirector");

        left1.SetActive(false);
        left2.SetActive(false);
        left3.SetActive(false);
        right1.SetActive(false);
        right2.SetActive(false);
        right3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) && this.player.transform.position.x < 0)
        {
            left1.SetActive(true);
        }
        else if (Input.GetKey(KeyCode.A) && this.player.transform.position.x > 0)
        {
            right1.SetActive(true);
        }
        else
        {
            left1.SetActive(false);
            right1.SetActive(false);
        }
        if ((Input.GetKey(KeyCode.S) || Input.GetMouseButton(0)) && this.player.transform.position.x < 0)
        {
            left2.SetActive(true);
        }
        else if ((Input.GetKey(KeyCode.S) || Input.GetMouseButton(0)) && this.player.transform.position.x > 0)
        {
            right2.SetActive(true);
        }
        else
        {
            left2.SetActive(false);
            right2.SetActive(false);
        }

        if ((Input.GetKey(KeyCode.D) || Input.GetMouseButton(1)) && this.player.transform.position.x < 0)
        {
            left3.SetActive(true);
        }
        else if ((Input.GetKey(KeyCode.D) || Input.GetMouseButton(1)) && this.player.transform.position.x > 0)
        {
            right3.SetActive(true);
        }
        else
        {
            left3.SetActive(false);
            right3.SetActive(false);
        }
    }
}
