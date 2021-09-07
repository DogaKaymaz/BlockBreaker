using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathArea : MonoBehaviour
{
    // [SerializeField] private GameManagement gameManagementScript;
    [SerializeField] private Canvas FailCanvas;
    private AudioSource _audioSource;
    [SerializeField] private GameManagement _gameManagementScript;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!_gameManagementScript.hasLevelCompleted)
        {
            Debug.Log("DIED DIED DIED");
       
        FailCanvas.gameObject.SetActive(true);
        _audioSource.Play();

        Destroy(other.gameObject);
        }
    }
}
