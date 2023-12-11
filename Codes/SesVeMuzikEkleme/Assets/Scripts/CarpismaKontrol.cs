using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarpismaKontrol : MonoBehaviour
{

    public GameObject patlama;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision obj)
    {
        Debug.Log("OnCollisionEnter Carpisma gerceklesti.");
        Destroy(obj.gameObject);
        Destroy(this.gameObject);
        Instantiate(patlama, this.gameObject.transform.position, this.gameObject.transform.rotation);
     }

}
