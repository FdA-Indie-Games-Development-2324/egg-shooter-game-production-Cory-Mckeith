using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newsc : MonoBehaviour
{
    public static int targetCount = 0; // Static variable to count total destroyed targets
    public GameObject explosionEffect; // Optional: reference for an explosion effect

    void OnDestroy()
    {
        // Increment the count when a target is destroyed
        targetCount++;
        if (targetCount >= 20)
        {
            // Load the next scene
            UnityEngine.SceneManagement.SceneManager.LoadScene("war");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the target collides with a bullet
        if (collision.gameObject.CompareTag("Bullet"))
        {
            // Optionally, instantiate an explosion effect
            if (explosionEffect != null)
            {
                Instantiate(explosionEffect, transform.position, transform.rotation);
            }
            // Destroy the target object
            Destroy(gameObject);
        }
    }
}
