using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UndestroyableNumber : MonoBehaviour
{
    private levelScript _levelScript;
    public static int integerIndicatingWhichSceneItIs;
    private int lastScene;
    private bool sceneChangeCheck;

    private void Awake()
    {
        lastScene = SceneManager.GetActiveScene().buildIndex;
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        hasSceneChanged();
        
        if (sceneChangeCheck)
        {
            LevelCounter();
        }
    }

    public void LevelCounter()
    {
        _levelScript = FindObjectOfType<levelScript>();
        
        if (_levelScript.whichLevel != -1)
        {
            Debug.Log("Buraya geldi mi");

            integerIndicatingWhichSceneItIs = _levelScript.whichLevel;
        }
    }

    void hasSceneChanged()
    {
        if (lastScene != SceneManager.GetActiveScene().buildIndex)
        {
            sceneChangeCheck = true;
            lastScene = SceneManager.GetActiveScene().buildIndex;
        }

        else
        {
            sceneChangeCheck = false;
        }
    }
    
}
