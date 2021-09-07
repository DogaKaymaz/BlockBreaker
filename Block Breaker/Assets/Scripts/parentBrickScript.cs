using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class parentBrickScript : MonoBehaviour
{
    [SerializeField] private GameManagement gameManagementScript;
    private AudioSource _audioSource;

    [SerializeField] private Canvas LevelCompletedCanvas;

    private void Awake()
    {
        _audioSource = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        StartCoroutine(Retry());
    }
    
    IEnumerator Retry()
    {
        if (transform.childCount == 0)
        {
            gameManagementScript.makeBoolTrue();

            PlayAudio();
            ShowCanvas();
            
            yield return new WaitForSeconds(3f);
            
            gameManagementScript.GameLevelEnd();
        }
    }


    void PlayAudio()
    {
        if (!_audioSource.isPlaying)
        {
            _audioSource.Play();
        }
    }

    void ShowCanvas()
    {
        if (!LevelCompletedCanvas.isActiveAndEnabled)
        {
            LevelCompletedCanvas.gameObject.SetActive(true);
        }
    }




}
