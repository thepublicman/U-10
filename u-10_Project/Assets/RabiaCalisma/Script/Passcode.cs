using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace RabiaCalisma.Script
{
    public class NewBehaviourScript : MonoBehaviour
{
    string Code = "123";
    string Nr = null;
    int NrIndex = 0;
    string alpha;
    public Text UiText = null;

    int flag = 0;

    public RawImage rawImage;
    public Color newColor;

    public void CodeFunction(string Numbers)
    {
        NrIndex++;
        Nr = Nr + Numbers;
        UiText.text = Nr;
    }

    public void Enter()
    {
        if (Nr == Code)
        {
            Color newColor = Color.green;
            ChangeColor(newColor);
            Debug.Log("Başarili");
            flag = 1;
            Invoke("sahneGecisi", 0.5f);
        }
        else
        {
            Color newColor = Color.red;
            ChangeColor(newColor);
        }
        NrIndex++;
        Nr = null;
        UiText.text = Nr;
    }

    public void Delete()
    {
        NrIndex++;
        Nr = null;
        UiText.text = Nr;
    }

    public void ChangeColor(Color newColor)
    {
        rawImage.color = newColor;
    }

        public void sahneGecisi()
    {
<<<<<<< HEAD:Bootcamp_U-10/Assets/RabiaCalisma/Script/Passcode.cs
        SceneManager.LoadScene("SceneUmut"); // bulmacayı tamamladıktan sonra gelmesi gereken sahne adı
    }
        private void Start()
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
=======
        SceneManager.LoadScene("Scene"); // bulmacayı tamamladıktan sonra gelmesi gereken sahne adı
    }
}
}
>>>>>>> 4faf5c660eb5e82e0466d601da97b6711f21523e:u-10_Project/Assets/RabiaCalisma/Script/Passcode.cs
