using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletForce = 20f;
    public float fireRate = 0.2f;

    private float fireCooldown;

    private void Update()
    {
        fireCooldown -= Time.deltaTime;

        if (Input.GetButtonDown("Fire1") && fireCooldown <= 0f)
        {
            Shoot();
            fireCooldown = fireRate;
        }
    }

    private void Shoot()
    {
    GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
    
    // Set the bullet's direction based on the firePoint's right vector
    if (firePoint.right.x > 0)
        rb.velocity = firePoint.right * -bulletForce; // Move right
    else
        rb.velocity = firePoint.right * bulletForce; // Move left
    }

}
