using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BUtton : MonoBehaviour
{
    public UnityEngine.UI.Text text;
    int sayi = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SayiyiArtir() {
        sayi++;
        text.text = sayi + "";
    }
}
