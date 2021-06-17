using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeLeft = 3.0f;
    public Text startText; // used for showing countdown from 3, 2, 1 
    GameSession gameSession;
    public int PlayerLivesCount;

    private void Start()
    {
        gameSession = FindObjectOfType<GameSession>();
    }
    void Update()
    {
        PlayerLivesCount = gameSession.PlayerLives;
        timeLeft -= Time.deltaTime;
        startText.text = (timeLeft).ToString("0");
        if (timeLeft < 0 && PlayerLivesCount > 0)
        {
            FindObjectOfType<GameSession>().TakeLife();
            //Do something useful or Load a new game scene depending on your use-case
        }
        else if(timeLeft <= 10)
        {
            startText.color = Color.red;
        }
        else if(timeLeft < 0 && PlayerLivesCount < 0 || PlayerLivesCount == 0)
        {
            FindObjectOfType<GameSession>().ResetGameSession();
        }
    }
}
