using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parentBrickScript : MonoBehaviour
{
    [SerializeField] private GameManagement gameManagementScript;
   
    
    void Update()
    {
        StartCoroutine(Retry());
    }
    
    IEnumerator Retry()
    {

        
        
        if (transform.childCount == 0)
        {
            yield return new WaitForSeconds(0.5f);
            gameManagementScript.GameLevelEnd();
        }
        
    }

}
