using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioClip patlama;
    AudioSource aSource;
    // Use this for initialization 
    void Start()
    {
        aSource = GetComponent<AudioSource>();
    }
        // Update is called once per frame 
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                aSource.Pause();
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                aSource.Play();
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                aSource.PlayOneShot(patlama, .7f);  
            }
     }
 }


//public AudioClip patlama; 
//void Update()
//{ 
//    if (Input.GetKeyDown(KeyCode.Space))
//    {
//        AudioSource.PlayClipAtPoint(patlama, Camera.main.transform.position); 
//    }
//}