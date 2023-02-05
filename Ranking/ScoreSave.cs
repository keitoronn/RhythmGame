using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;
public class ScoreSave : MonoBehaviour//�I�����C��DB�Ɏ��g�̃X�R�A�𑗐M
{
    public void SaveScore()
    {
        NCMBObject scoreClass = new NCMBObject(TuneInfo.TuneName);
        scoreClass["score"] = ResultScore.result;
        scoreClass["name"] = ResultScore.name;
        NCMBObject semafo = new NCMBObject("Semafo");
        semafo["sema"] = 0;
        scoreClass.SaveAsync((NCMBException e) =>
        {
            if (e != null)
            {
                Debug.Log("Error: " + e.ErrorMessage);
            }
            else
            {
                //Debug.Log("success");
            }
        });
        semafo.SaveAsync((NCMBException e) =>
        {
            if (e != null)
            {
                Debug.Log("Error: " + e.ErrorMessage);
            }
            else
            {
                //Debug.Log("success");
            }
        });
    }
}