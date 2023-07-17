using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BookButton : MonoBehaviour
{
    public string hedefSahneAdi; // Ge�i� yap�lacak hedef sahnenin ad�
    public Text myText;

    private bool oyuncuKapida; // Oyuncu kap�n�n i�inde mi?


    private void Start()
    {
        myText.text = "";
    }
    private void Update()
    {
        if (oyuncuKapida && Input.GetKeyDown(KeyCode.E))
        {
            SahneGecisiniBaslat();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            oyuncuKapida = true;
            myText.text = "E tu�una bas.";
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

    private void SahneGecisiniBaslat()
    {
        SceneManager.LoadScene(hedefSahneAdi);
    }
}
