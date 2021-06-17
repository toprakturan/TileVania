using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class CoinPickUp : MonoBehaviour
{
    [SerializeField] float coin = 0f;
    [SerializeField] AudioClip coinInteractSFX;
    public Text coinCounterText;
    Player player;
    bool checkAlive;

    private void Start()
    {
        if (PlayerPrefs.HasKey("coin"))
        {
            coin = PlayerPrefs.GetFloat("coin");
            coinCounterText.text = coin.ToString();
        }
        else
        {
            PlayerPrefs.SetFloat("coin", 0f);
            coinCounterText.text = PlayerPrefs.GetFloat("coin").ToString();

        }

        player = FindObjectOfType<Player>();
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "coin")
        {
            AudioSource.PlayClipAtPoint(coinInteractSFX, Camera.main.transform.position);
            coin++;
            PlayerPrefs.SetFloat("coin", coin);
            Destroy(collision.gameObject);
            
        }
    }
    private void Update()
    {
       
        coinCounterText.text = coin.ToString();
        checkAlive = player.isAlive;
    }
}
