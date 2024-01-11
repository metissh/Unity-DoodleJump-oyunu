using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class karakter_hareket : MonoBehaviour
{
    public float hiz, hareketInput;
    public Rigidbody2D karakter;
    int skor;
    float maxY;
    public TextMeshProUGUI skorYazisi;

    void Start()
    {
        
    }
    void Update()
    {
        hareketInput = Input.GetAxis("Horizontal");
        karakter.velocity = new Vector2(hiz * hareketInput, karakter.velocity.y);
        skorYazisi.text = "Skor:" + skor.ToString();
        if (karakter.transform.position.y > maxY)
        {
            skor++;
            maxY = karakter.transform.position.y;
        }
    }

    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "bitis")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        /*if (temas.gameObject.tag == "platform")
            skor++;*/
    }
}
