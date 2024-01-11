using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Zıplama : MonoBehaviour
{
    public float ziplamaGucu;
    Vector2 karakterHizi;
    Rigidbody2D fizik;

    void Start()
    {
        
    }
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D temas)
    {
        fizik = temas.collider.GetComponent<Rigidbody2D>();
        if(temas.relativeVelocity.y <=0)
        {
            if (fizik != null)
            {
                karakterHizi = fizik.velocity;
                karakterHizi.y = ziplamaGucu;
                fizik.velocity = karakterHizi;
            }
        }
    }
}
