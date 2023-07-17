using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
   public void OnTriggerEnter(Collider other)
   {
        if(other.gameObject.CompareTag("collectible"))
        {
            Destroy(other.gameObject);
        }
   }
}
