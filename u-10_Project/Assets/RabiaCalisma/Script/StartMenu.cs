using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
<<<<<<< HEAD:Bootcamp_U-10/Assets/RabiaCalisma/Script/StartMenu.cs
    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
=======
    
>>>>>>> 4faf5c660eb5e82e0466d601da97b6711f21523e:u-10_Project/Assets/RabiaCalisma/Script/StartMenu.cs
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
