using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsimlerVeEtiketler : MonoBehaviour
{
    GameObject nesne;
    //public GameObject nesne;

    void Start()
    {
        //nesne = GameObject.Find("Grifin");
        nesne = GameObject.FindWithTag("Dusman");

    }

    // Update is called once per frame
    void Update()
    {
        nesne.transform.Rotate(10, 0, 0);
        
    }
}
