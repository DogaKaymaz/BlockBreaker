using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    [SerializeField] private Paddle platform;

    private Vector2 platformToHandVector;

    private Rigidbody2D handRB;

    private bool hasStarted;

    [SerializeField] private float
        handVelocityX = 2f,
        handVelocityY = 15,
        collisionForce = 50f;
    
    // Start is called before the first frame update
    void Start()
    {
        platformToHandVector = transform.position - platform.transform.position;
        handRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            LockHandToPlatform();
            LaunchOnMouseClick();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("BİR ŞEYLER OLUYOR");
        handRB.AddForce(transform.up * collisionForce);
    }

    private void LaunchOnMouseClick()
    {
        if (Input.GetMouseButton(0))
        {
            handRB.velocity = new Vector2(handVelocityX, handVelocityY);
            hasStarted = true;
        }
    }

    void LockHandToPlatform()
    {
        transform.position = platform.paddlePos + platformToHandVector;
    }
}
