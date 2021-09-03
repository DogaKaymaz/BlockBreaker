using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class StaticDatas
{
    public static int integerIndicatingWhichSceneItIs;
    private static levelScript _levelScript;

    public static void LevelCounter()
    {

        if (_levelScript.whichLevel != -1)
        {
            Debug.Log("Buraya geldi mi");

            integerIndicatingWhichSceneItIs = GameObject.FindObjectOfType<levelScript>().whichLevel;
                
        }
    }
}
