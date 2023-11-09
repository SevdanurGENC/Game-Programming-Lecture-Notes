using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopKontrol : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody rb;
    float hiz = 2.5f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");
        Vector3 kuvvet = new Vector3(yatay, 0, dikey);
        rb.AddForce(kuvvet * hiz);
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 120f, 0));
        }
    }
}
