using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyShoot : MonoBehaviour
{
   public GameObject player;          // Reference to the player's transform
   public GameObject projectilePrefab; // Projectile prefab
   public Transform firePoint;        // The point from which the projectile is fired
   public float rotationSpeed = 5f;   // Speed at which the enemy rotates towards the player
   

   void Start()
   {
      player = GameObject.Find("Root");
   }
   void Update()
   {
       // Rotate the enemy to face the player
       RotateTowardsPlayer();
       // Continuously shoot at the player
       ShootAtPlayer();
   }
   // Rotate the enemy to face the player
   void RotateTowardsPlayer()
   {
       // Get the direction from the enemy to the player
       Vector3 direction = player.transform.position - transform.position;
       direction.y = 0;  // Make sure to ignore vertical movement (for 2D or top-down views)
       // Calculate the desired rotation and smoothly rotate the enemy
       Quaternion targetRotation = Quaternion.LookRotation(direction);
       transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
   }
   // Shoot a projectile towards the player
   void ShootAtPlayer()
   {
       // Fire the projectile
       FireProjectile();
   }
   // Instantiate and fire the projectile
   void FireProjectile()
   {
       if (projectilePrefab != null && firePoint != null)
       {
           // Instantiate the projectile at the fire point, with the enemy's rotation
           GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
           Destroy(projectile, 2f); // Destroy the bullet after 2 seconds (you can adjust the time)
       }
   }
}
