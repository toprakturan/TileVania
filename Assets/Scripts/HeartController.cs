using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{
    public List<SpriteRenderer> Hearts = new List<SpriteRenderer>();
    private int GetHeartCount;
    GameSession gameSession;
    void Start()
    {
        gameSession = FindObjectOfType<GameSession>();
        GetHeartCount = gameSession.PlayerLives;
        
        
    }

    
    void Update()
    {
        
    }
}
