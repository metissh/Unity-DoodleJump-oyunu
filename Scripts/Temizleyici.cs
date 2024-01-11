using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Temizleyici : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D temas)
    {
        if (temas.gameObject.tag == "platform")
        {
            float rastgeleY = Random.Range(9.2f, 10f);
            float rastgeleX = Random.Range(-2.47f, 2.47f);

            temas.transform.position = new Vector3(rastgeleX, temas.transform.position.y + rastgeleY, temas.transform.position.z);
        }
    }
}
