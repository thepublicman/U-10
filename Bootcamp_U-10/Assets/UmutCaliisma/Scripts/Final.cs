using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Final : MonoBehaviour
{
    public string hedefSahneAdi; // Ge�i� yap�lacak hedef sahnenin ad�

    private bool oyuncuKapida; // Oyuncu kap�n�n i�inde mi?


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
