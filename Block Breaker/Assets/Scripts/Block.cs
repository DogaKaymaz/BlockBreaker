using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using Random = UnityEngine.Random;

public class Block : MonoBehaviour
{
   private Hand handScript;
   
   [SerializeField] private AudioClip breakSound;
   
   [SerializeField] private GameObject impactVFX;
   
   Quaternion randomRotation = new Quaternion();
   

   private void Start()
   {
      handScript = FindObjectOfType<Hand>();
   }

   private void OnCollisionEnter2D(Collision2D other)
   {
      if (handScript.hasStarted)
      {
         AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
         Destroy(gameObject);
         TriggerSparkles();
      }
   }

   void TriggerSparkles()
   {
      
      randomRotation.y = Random.Range(1f, 360f);

      GameObject sparkles = Instantiate(
         impactVFX,
         transform.position, 
         randomRotation);
      
      Destroy(sparkles, 1f);
   }
   
}
