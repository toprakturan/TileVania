using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public GameObject floatingDamagetext;
    public int score = 0;
    


    private void Start()
    {
        
    }
    private void Update()
    {

    }


    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health > 0)
        {
            GameObject points = Instantiate(floatingDamagetext, transform.position, Quaternion.identity) as GameObject;
            points.transform.GetChild(0).GetComponent<TextMesh>().text = damage.ToString();
        }
        else if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        score = score + 10;
        Destroy(gameObject);
    }
}
