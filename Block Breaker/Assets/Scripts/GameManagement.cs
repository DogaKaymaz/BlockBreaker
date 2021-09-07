using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    [NonSerialized] public bool hasLevelCompleted = false;

    public void PlayBrickBreakerNextLevel()
    {
        SceneManager.LoadScene(sceneBuildIndex: UndestroyableNumber.integerIndicatingWhichSceneItIs + 3 );
        Debug.Log(UndestroyableNumber.integerIndicatingWhichSceneItIs + 3);
        makeBoolFalse();
    }


    public void OpenLevelsPage()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }
    
    public void BackToMenu()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }

    public void RetryLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GameLevelEnd()
    {
        SceneManager.LoadScene(sceneBuildIndex: 2);
    }

    public void GalleryPage()
    {
        Debug.Log("Gallery Page Opened.");
    }
    

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void makeBoolFalse()
    {
        hasLevelCompleted = false;
    }

    public void makeBoolTrue()
    {
        hasLevelCompleted = true;
    }
    
    
}
