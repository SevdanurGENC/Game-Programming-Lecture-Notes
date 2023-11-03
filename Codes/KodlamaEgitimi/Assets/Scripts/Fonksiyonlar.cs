using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fonksiyonlar : MonoBehaviour
{
    // Deger donderemeyen fonksiyonlar
    // Deger donderebilen fonksiyonlar
    // Parametre alabilen fonksiyonlar (deger donderebilen)
    // Parametre alabilen fonksiyonlar (deger donderemeyen)

    public void DegerDondermeyenFonksiyon() 
    {
        Debug.Log("Deger dondermeyen bir fonksiyon tipidir.");   
    }

    public float DegerDonderebilenFonksiyon()
    {
        float deger = 10.8f;
        return deger;
    }

    public string EkranaYazdir(string isim) 
    {
        return isim;
    }

    public void SonucYazdir(string isim)
    {
        Debug.Log(isim + " isimli ogrenci basarilidir.");
    }

    void Start()
    {
        //DegerDondermeyenFonksiyon();
        //Debug.Log(DegerDonderebilenFonksiyon());

        //Debug.Log(EkranaYazdir("Sevdanur"));
        //SonucYazdir("Sevdanur");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
