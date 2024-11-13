using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerJump : MonoBehaviour
{
   public float jumpForce = 5f;      // How high the player jumps
   public float groundCheckDistance = 0.1f; // Small value to check if the player is grounded
   public LayerMask groundLayer;     // Layer to define what is considered the ground
   private Rigidbody rb;             // The Rigidbody component of the player
   private bool isGrounded;          // Whether the player is on the ground or not
   void Start()
   {
       // Get the Rigidbody component on the player
       rb = GetComponent<Rigidbody>();
   }
   void Update()
   {
       // Check if the player is grounded using a raycast
       isGrounded = Physics.Raycast(transform.position, Vector3.down, groundCheckDistance, groundLayer);
       // If the player is grounded and the spacebar is pressed, jump
       if (isGrounded && Input.GetKeyDown(KeyCode.Space))
       {
           Jump();
       }
   }
   void Jump()
   {
       // Apply a vertical force to the Rigidbody to make the player jump
       rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z); // Reset any vertical velocity to prevent stacking
       rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
   }
}
