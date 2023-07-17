using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    
    public void Baslangic()
    {
        Invoke("sahneGecisi", 0.5f);
    }

    public void Cikis()
    {
        Application.Quit();
    }

    public void sahneGecisi()
    {
        SceneManager.LoadScene("Scene");
    }
}
