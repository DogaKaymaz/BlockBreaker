using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{

    public void PlayBrickBreakerNextLevel()
    {
        SceneManager.LoadScene(sceneBuildIndex: StaticDatas.integerIndicatingWhichSceneItIs + 3 );
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
    
    
}
