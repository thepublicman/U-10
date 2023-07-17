using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DoorEvents : MonoBehaviour
{
    public Text myText;

    private bool oyuncuKapida; // Oyuncu kapýnýn içinde mi?


    private void Start()
    {
        myText.text = "";
    }
    //private void Update()
    //{
    //    if (oyuncuKapida && Input.GetKeyDown(KeyCode.E))
    //    {
    //        SahneGecisiniBaslat();
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            oyuncuKapida = true;
            myText.text = "Bulmacayý Çözemeden Odadan Çýkamazsýn!";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            oyuncuKapida = false;
            myText.text = "";
        }
    }

    //private void SahneGecisiniBaslat()
    //{
    //    SceneManager.LoadScene(hedefSahneAdi);
    //}
}
