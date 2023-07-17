using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
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
