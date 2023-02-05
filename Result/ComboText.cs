using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ComboText : MonoBehaviour//�R���{�������瑱���������Z����
{
    public int combo = 0;
    public TextMeshProUGUI comboText;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void AddCombo()
    {
        combo++;
    }
    public void ResetCombo()
    {
        combo=0;
    }

    // Update is called once per frame
    void Update()
    {
        if (ResultScore.gamemode == 1)
        {
            comboText.text = combo.ToString();
        }
        else
        {
            combo = 0;
        }
    }
}
