using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxColliders : MonoBehaviour
{

    GameSession gameSession;
    public int PlayerLive;
    bool isCollide = false;
    void Start()
    {
        gameSession = FindObjectOfType<GameSession>();
    }

    
    void Update()
    {
        PlayerLive = gameSession.PlayerLives;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "BottomBoxCollider" && isCollide == false)
        {
            if(PlayerLive > 0)
            {
                FindObjectOfType<GameSession>().TakeLife();
                isCollide = true;
            }
            else if(PlayerLive < 0 || PlayerLive == 0)
            {
                gameSession.ResetGameSession();
            }
            
        }
    }
}
