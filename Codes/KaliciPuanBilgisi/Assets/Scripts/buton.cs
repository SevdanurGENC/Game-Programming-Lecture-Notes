using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buton : MonoBehaviour
{
    int puan = 0;
    public UnityEngine.UI.Text text;
    void Start()
    {
        puan = PlayerPrefs.GetInt("Puan");
        text.text = puan + "";
    }

    public void PuanVer()
    {
        puan += 10;
        PlayerPrefs.SetInt("Puan", puan);
        text.text = puan + "";
    }
}