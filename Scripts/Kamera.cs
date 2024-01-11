using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    Transform KarakterPoz, kamera;
    void Start()
    {
        KarakterPoz = GameObject.Find("Karakter").GetComponent<Transform>();
        kamera = GameObject.Find("Main Camera").GetComponent<Transform>();
    }

    
    void Update()
    {
        if(KarakterPoz.position.y > kamera.position.y)
        {
            kamera.position = new Vector3 (kamera.position.x,KarakterPoz.position.y,kamera.position.z);
        }
    }
}
