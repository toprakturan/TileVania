using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    [SerializeField] AudioClip arrowShootingSFX;

    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            AudioSource.PlayClipAtPoint(arrowShootingSFX, Camera.main.transform.position);
            animator.SetTrigger("Shooting");
            Shoot();
        }

    }

    void Shoot()
    {
        
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        
    }
  
    
}
