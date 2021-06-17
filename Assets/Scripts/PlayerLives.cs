using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    GameSession gameSession;
    public int PlayerLive;
    public GameObject[] health;

    void Start()
    {
        
        
    }

    
    void Update()
    {
        gameSession = FindObjectOfType<GameSession>();
        PlayerLive = gameSession.PlayerLives;
        Destroy(health[PlayerLive].gameObject);
        if(PlayerLive <= 2)
        {
            health[2].gameObject.SetActive(false);
        }
    }
}
