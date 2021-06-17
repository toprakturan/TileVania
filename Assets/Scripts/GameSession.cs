using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSession : MonoBehaviour
{
    [SerializeField] public int PlayerLives = 3;
    Player player;
    [SerializeField] AudioClip gameMusic;
    CapsuleCollider2D getPlayerBodyCollider;
    CoinPickUp coinPickup;
    

    private void Awake()
    {
        
        int numberOfGameSessions = FindObjectsOfType<GameSession>().Length;
        if(numberOfGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }

        
    }

    private void Start()
    {
        player = FindObjectOfType<Player>();
        getPlayerBodyCollider = player.myBodyCollider2D;
        
    }

    public void ProcessPlayerDeath()
    {
        if(PlayerLives > 1)
        {
            TakeLife();
        }
        else
        {
            ResetGameSession();
        }
    }
    
    void Update()
    {

        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            PlayerPrefs.DeleteAll();
        }

        

    }

    public void TakeLife()
    {
        PlayerLives--;
        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void ResetGameSession()
    {
        SceneManager.LoadScene(0);
        Destroy(gameObject);
    }

    

}
