using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour//ゲーム画面で各機能にアクセスするハブ
{
    GameObject CountText;
    GameObject SoundEffect;
    GameObject goodgenerator;
    GameObject pusheffectgenerator;
    // Start is called before the first frame update
    void Start()
    {
        this.CountText = GameObject.Find("CountText");
        this.goodgenerator = GameObject.Find("GoodGenerator");
        this.pusheffectgenerator = GameObject.Find("PushEffectGenerator");
        this.SoundEffect = GameObject.Find("SE");
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ScoreUp1()
    {
        this.CountText.GetComponent<CountText>().AddScore1();
        Debug.Log("a");
    }
    public void ScoreUp2()
    {
        this.CountText.GetComponent<CountText>().AddScore2();
    }
    public void MaxShow1()
    {
        this.CountText.GetComponent<CountText>().ScoreMax1();
    }
    public void MaxShow2()
    {
        this.CountText.GetComponent<CountText>().ScoreMax2();
    }
    public void ComboUp()
    {
        this.CountText.GetComponent<ComboText>().AddCombo();
    }
    public void ComboReset()
    {
        this.CountText.GetComponent<ComboText>().ResetCombo();
    }
    public void DelayAddSmall()
    {
        this.CountText.GetComponent<DelayCount>().AddDelay1();
    }
    public void DelaySubSmall()
    {
        this.CountText.GetComponent<DelayCount>().SubDelay1();
    }
    public void GoodShow(float x)
    {
        this.goodgenerator.GetComponent<GoodGenerator>().GoodCanvasGenarate(x);
    }
    public void GreatShow(float x)
    {
        this.goodgenerator.GetComponent<GoodGenerator>().GreatCanvasGenarate(x);
    }
    public void SEone()
    {
        this.SoundEffect.GetComponent<SE>().SE1();
    }
    public void SEtwo()
    {
        this.SoundEffect.GetComponent<SE>().SE2();
    }
    public void SEthree()
    {
        this.SoundEffect.GetComponent<SE>().SE3();
    }
    public void SEfour()
    {
        this.SoundEffect.GetComponent<SE>().SE4();
    }
    public void SEfive()
    {
        this.SoundEffect.GetComponent<SE>().SE5();
    }
    public void PushGreatShow(float x)
    {
        this.pusheffectgenerator.GetComponent<PushEffectGenerator>().GreatPushEffectGenarate(x);
    }
    public void PushGoodShow(float x)
    {
        this.pusheffectgenerator.GetComponent<PushEffectGenerator>().GoodPushEffectGenarate(x);
    }
    public void PushNormaldShow(float x)
    {
        this.pusheffectgenerator.GetComponent<PushEffectGenerator>().NormalPushEffectGenarate(x);
    }
}
