using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunningSFXController : MonoBehaviour
{
    Player player;
    bool isPlayerMoving;
    Rigidbody2D playerRigidBody;
    AudioSource audioSource;
    
    void Start()
    {
        player = GetComponent<Player>();
        audioSource = GetComponent<AudioSource>();
        
    }

    
    void Update()
    {
        playerRigidBody = player.myRigidBody;
        if (playerRigidBody.velocity.magnitude > 1f && audioSource.isPlaying == false)
        {
            audioSource.Play();
        }
    }
}
