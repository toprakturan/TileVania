using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    Player player;
    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    
    void Update()
    {
        Vector2 newCamPosition = new Vector2(player.transform.position.x, player.transform.position.y);
        transform.position = new Vector3(newCamPosition.x, newCamPosition.y, transform.position.z);
    }
}
