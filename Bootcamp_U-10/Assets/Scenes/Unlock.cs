using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock : MonoBehaviour
{
    public Animator animator;
    public GameObject anahtar;
    public GameObject UyariText;
    public void Start()
    {
        animator = GetComponent<Animator>();
        UyariText.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Player"))
    {
        animator.SetBool("Open", true);
        anahtar.SetActive(false);
        if (animator.GetInteger("RedKey") == 0)
        {
            UyariText.SetActive(true);
        }
        
    }
}

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetBool("Open", false);
            UyariText.SetActive(false);
        }
    }
}
