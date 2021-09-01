using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
   private Hand handScript;

   private void Start()
   {
      handScript = FindObjectOfType<Hand>();
   }

   private void OnCollisionEnter2D(Collision2D other)
   {
      if (handScript.hasStarted)
      {
         Destroy(gameObject);  
      }
   }
}
