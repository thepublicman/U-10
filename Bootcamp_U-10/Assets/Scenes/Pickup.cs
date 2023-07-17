using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Animator animator;
    public GameObject KeyOnPlayer;
    public GameObject PickupText;

    void Start()
    {
        KeyOnPlayer.SetActive(false);
        PickupText.SetActive(false);
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PickupText.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);

                KeyOnPlayer.SetActive(true);

                PickupText.SetActive(false);

                animator.SetInteger("RedKey", animator.GetInteger("RedKey") + 1);
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        PickupText.SetActive(false);
    }
}
