using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private float screenWidthInUnits = 16f,
        minX = 1f,
        maxX = 15f;

    private float mousePosInUnits;
            
        
    public Vector2 paddlePos;

    // Update is called once per frame
    void Update()
    {
        mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosInUnits, minX, maxX);

        transform.position = paddlePos;
    }
}
