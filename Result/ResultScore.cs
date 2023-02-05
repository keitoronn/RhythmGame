using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultScore//リザルト画面に表示する数値のリスト
{
    public static int result = 0;
    public static int gamemode = 0;
    public static int ranking = 0;
    public static int[] rankscore = new int[5] {0,0,0,0,0};
    public static string[] rankername = new string[5] { "", "", "", "", "" };
    public static string name = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
