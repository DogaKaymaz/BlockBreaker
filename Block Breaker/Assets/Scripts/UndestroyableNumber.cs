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

    private GameManagement _gameManagement;

    private void Awake()
    {
        
        _gameManagement = FindObjectOfType<GameManagement>();
        int unCount = FindObjectsOfType<UndestroyableNumber>().Length; // unCount = UndestroyableNumber Count

        if (unCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(this);
        }

        else
        {
            DontDestroyOnLoad(this);
        }


        lastScene = SceneManager.GetActiveScene().buildIndex;
       
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
            Debug.Log("asıl burası önemli" + _gameManagement.hasLevelCompleted);
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
