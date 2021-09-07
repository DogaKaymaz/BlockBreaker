using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Hand : MonoBehaviour
{
    [SerializeField] private Paddle platform;

    private Vector2 platformToHandVector;

    private Rigidbody2D handRB;

    public bool hasStarted;

    [SerializeField] private AudioClip[] handSounds;

    private AudioSource _audioSource;
    

    [SerializeField] private float
        handVelocityX = 2f,
        handVelocityY = 15,
        collisionForce = 50f,
        balanceDownPower = 9f;
    
    void Start()
    {
        platformToHandVector = transform.position - platform.transform.position;
        handRB = GetComponent<Rigidbody2D>();
        _audioSource = gameObject.GetComponent<AudioSource>();
    }

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
        if (hasStarted)
        {
            
            if (other.gameObject.name == "leftWall")
            {
                GiveRightPowerToHand();
                PlaySounds();
            }
            
            else if (other.gameObject.name == "rightWall")
            {
                GiveLeftPowerToHand();
                PlaySounds();
            }
            
            else if (other.gameObject.name == "upWall")
            {
                GiveDownPowerToHand();
                PlaySounds();
            }

            else
            {
                GiveUpPowerToHand();
                PlaySounds();
            }
            
        }
    }

    private void LaunchOnMouseClick()
    {
        if (Input.GetMouseButton(0))
        {
            GiveUpPowerToHand();
            // handRB.velocity = new Vector2(handVelocityX, handVelocityY);
            hasStarted = true;
        }
    }

    void LockHandToPlatform()
    {
        transform.position = platform.paddlePos + platformToHandVector;
    }

    
    void GiveUpPowerToHand()
    {
        handRB.AddForce(Vector2.up * collisionForce);
    }
    void GiveDownPowerToHand()
    {
        handRB.AddForce(Vector2.down * collisionForce / balanceDownPower);
    }
    
    void GiveRightPowerToHand()
    {
        handRB.AddForce(Vector2.right * collisionForce);
    }
    
    void GiveLeftPowerToHand()
    {
        handRB.AddForce(Vector2.left * collisionForce);
    }

    void PlaySounds()
    {
        AudioClip clip = handSounds[UnityEngine.Random.Range(0, handSounds.Length)];
        _audioSource.PlayOneShot(clip);
    }
    
    
}
