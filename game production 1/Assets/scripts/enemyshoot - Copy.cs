using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bullet : MonoBehaviour
{
   public float speed = 5f;   // Speed of the bullet
   public float lifetime = 1f; // How long the bullet will exist before being destroyed
   private void Start()
   {
       // Destroy the bullet after its lifetime
       Destroy(gameObject, lifetime);
   }
   private void Update()
   {
       // Move the bullet forward
       transform.Translate(Vector3.forward * speed * Time.deltaTime);
   }
   private void OnCollisionEnter(Collision collision)
   {
       // Destroy the bullet when it collides with something
       Destroy(gameObject);
   }
}