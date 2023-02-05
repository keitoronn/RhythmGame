using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialDirector : MonoBehaviour//チュートリアルメッセージの表示制御
{
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public GameObject Text5;
    public GameObject Text6;
    public GameObject Text7;
    public GameObject Text8;
    public GameObject Text9;
    public GameObject Text10;
    public GameObject Text11;
    public GameObject Text12;
    public GameObject Text13;
    public GameObject Text14;
    public GameObject Text15;
    public GameObject Text16;
    public GameObject Text17;
    public GameObject Text18;
    public GameObject Text19;
    public GameObject Text20;
    public GameObject Text21;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TuneInfo.ddelta < 3.0f)
        {
            this.Text1.SetActive(false);
        }
        else if (TuneInfo.ddelta > 7.5f)
        {
            this.Text1.SetActive(false);
        }
        else
        {
            this.Text1.SetActive(true);
        }
        if (TuneInfo.ddelta < 8.0f)
        {
            this.Text2.SetActive(false);
        }
        else if (TuneInfo.ddelta > 11.5f)
        {
            this.Text2.SetActive(false);
        }
        else
        {
            this.Text2.SetActive(true);
        }
        if (TuneInfo.ddelta < 12.0f)
        {
            this.Text3.SetActive(false);
        }
        else if (TuneInfo.ddelta > 15.5f)
        {
            this.Text3.SetActive(false);
        }
        else
        {
            this.Text3.SetActive(true);
        }
        if (TuneInfo.ddelta < 16.0f)
        {
            this.Text4.SetActive(false);
        }
        else if (TuneInfo.ddelta > 19.5f)
        {
            this.Text4.SetActive(false);
        }
        else
        {
            this.Text4.SetActive(true);
        }
        if (TuneInfo.ddelta < 20.0f)
        {
            this.Text5.SetActive(false);
        }
        else if (TuneInfo.ddelta > 23.5f)
        {
            this.Text5.SetActive(false);
        }
        else
        {
            this.Text5.SetActive(true);
        }
        if (TuneInfo.ddelta < 24.0f)
        {
            this.Text6.SetActive(false);
        }
        else if (TuneInfo.ddelta > 27.5f)
        {
            this.Text6.SetActive(false);
        }
        else
        {
            this.Text6.SetActive(true);
        }
        if (TuneInfo.ddelta < 28.0f)
        {
            this.Text7.SetActive(false);
        }
        else if (TuneInfo.ddelta > 31.5f)
        {
            this.Text7.SetActive(false);
        }
        else
        {
            this.Text7.SetActive(true);
        }
        if (TuneInfo.ddelta < 32.0f)
        {
            this.Text8.SetActive(false);
        }
        else if (TuneInfo.ddelta > 35.5f)
        {
            this.Text8.SetActive(false);
        }
        else
        {
            this.Text8.SetActive(true);
        }
        if (TuneInfo.ddelta < 56.0f)
        {
            this.Text9.SetActive(false);
        }
        else if (TuneInfo.ddelta > 59.5f)
        {
            this.Text9.SetActive(false);
        }
        else
        {
            this.Text9.SetActive(true);
        }
        if (TuneInfo.ddelta < 60.0f)
        {
            this.Text10.SetActive(false);
        }
        else if (TuneInfo.ddelta > 63.5f)
        {
            this.Text10.SetActive(false);
        }
        else
        {
            this.Text10.SetActive(true);
        }
        if (TuneInfo.ddelta < 64.0f)
        {
            this.Text11.SetActive(false);
        }
        else if (TuneInfo.ddelta > 67.5f)
        {
            this.Text11.SetActive(false);
        }
        else
        {
            this.Text11.SetActive(true);
        }
        if (TuneInfo.ddelta < 68.0f)
        {
            this.Text12.SetActive(false);
        }
        else if (TuneInfo.ddelta > 71.5f)
        {
            this.Text12.SetActive(false);
        }
        else
        {
            this.Text12.SetActive(true);
        }
        if (TuneInfo.ddelta < 76.0f)
        {
            this.Text13.SetActive(false);
        }
        else if (TuneInfo.ddelta > 79.5f)
        {
            this.Text13.SetActive(false);
        }
        else
        {
            this.Text13.SetActive(true);
        }
        if (TuneInfo.ddelta < 80.0f)
        {
            this.Text14.SetActive(false);
        }
        else if (TuneInfo.ddelta > 83.5f)
        {
            this.Text14.SetActive(false);
        }
        else
        {
            this.Text14.SetActive(true);
        }
        if (TuneInfo.ddelta < 84.0f)
        {
            this.Text15.SetActive(false);
        }
        else if (TuneInfo.ddelta > 87.5f)
        {
            this.Text15.SetActive(false);
        }
        else
        {
            this.Text15.SetActive(true);
        }
        if (TuneInfo.ddelta < 88.0f)
        {
            this.Text16.SetActive(false);
        }
        else if (TuneInfo.ddelta > 91.5f)
        {
            this.Text16.SetActive(false);
        }
        else
        {
            this.Text16.SetActive(true);
        }
        if (TuneInfo.ddelta < 92.0f)
        {
            this.Text17.SetActive(false);
        }
        else if (TuneInfo.ddelta > 95.5f)
        {
            this.Text17.SetActive(false);
        }
        else
        {
            this.Text17.SetActive(true);
        }
        if (TuneInfo.ddelta < 108.0f)
        {
            this.Text18.SetActive(false);
        }
        else if (TuneInfo.ddelta > 111.5f)
        {
            this.Text18.SetActive(false);
        }
        else
        {
            this.Text18.SetActive(true);
        }
        if (TuneInfo.ddelta < 112.0f)
        {
            this.Text19.SetActive(false);
        }
        else if (TuneInfo.ddelta > 115.5f)
        {
            this.Text19.SetActive(false);
        }
        else
        {
            this.Text19.SetActive(true);
        }
        if (TuneInfo.ddelta < 116.0f)
        {
            this.Text20.SetActive(false);
        }
        else if (TuneInfo.ddelta > 119.5f)
        {
            this.Text20.SetActive(false);
        }
        else
        {
            this.Text20.SetActive(true);
        }
        if (TuneInfo.ddelta < 144.0f)
        {
            this.Text21.SetActive(false);
        }
        else if (TuneInfo.ddelta > 147.5f)
        {
            this.Text21.SetActive(false);
        }
        else
        {
            this.Text21.SetActive(true);
        }
        if (TuneInfo.ddelta >= TuneInfo.TuneTime - 1.0f)
        {
            SceneManager.LoadScene("playersetting");
            ResultScore.gamemode = 0;
            ResultScore.ranking = 0;
        }
    }
}
