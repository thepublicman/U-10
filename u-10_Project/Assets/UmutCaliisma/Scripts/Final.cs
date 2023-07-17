using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Final : MonoBehaviour
{
    public string hedefSahneAdi; // Geçiþ yapýlacak hedef sahnenin adý

    private bool oyuncuKapida; // Oyuncu kapýnýn içinde mi?


    private void Update()
    {
        if (oyuncuKapida)
        {
            SahneGecisiniBaslat();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            oyuncuKapida = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            oyuncuKapida = false;
        }
    }

    private void SahneGecisiniBaslat()
    {
        SceneManager.LoadScene(hedefSahneAdi);
    }
}
