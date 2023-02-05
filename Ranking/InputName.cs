using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputName : MonoBehaviour//–¼‘O‚Ì“o˜^
{
    public TMP_InputField inputField;

    void Start()
    {
        inputField = inputField.GetComponent<TMP_InputField>();

    }

    public void InputText()
    {
        ResultScore.name = inputField.text.ToString();
        Debug.Log(ResultScore.name);

    }
}
