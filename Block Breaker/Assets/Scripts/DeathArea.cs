using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathArea : MonoBehaviour
{
    // [SerializeField] private GameManagement gameManagementScript;
    [SerializeField] private Canvas FailCanvas;
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        Debug.Log("DIED DIED DIED");
        FailCanvas.gameObject.SetActive(true);
        
        Destroy(other.gameObject);

    }
}
