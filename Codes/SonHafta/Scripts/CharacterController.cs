using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float hiz = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float zYonu = Input.GetAxis("Vertical") * hiz;
        float xYonu = Input.GetAxis("Horizontal") * hiz;
        zYonu += Time.deltaTime;
        xYonu += Time.deltaTime;
        transform.Translate(xYonu, 0, zYonu);

        
    }
}
