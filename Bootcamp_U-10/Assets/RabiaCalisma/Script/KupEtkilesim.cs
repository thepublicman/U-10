using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KupEtkilesim : MonoBehaviour
{
    public Canvas interactionCanvas;
    public Text interactionText;

    private bool isPlayerInRange;

    private void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            interactionCanvas.gameObject.SetActive(true);
            // Eylem gerçekleştirildiğinde yapılacak işlemler
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
            interactionText.text = "Press E to interact";
            interactionCanvas.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
            interactionCanvas.gameObject.SetActive(false);
        }
    }
}
