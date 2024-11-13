
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    Rigidbody rb;
    public float bulletSpeed; 
    //public GameObject ScoreMan;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // place rigidbody to object 
        rb.AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);
      
      //ScoreMan = GameObject.Find("Canvas"); // looks for the canvas to put thwm score on the ui
    }

   void OnTriggerEnter(Collider other)
   {
      if(other.CompareTag("Target")) // looks for objects tagged with Target 
      {
         Destroy(other.gameObject);//the object that has been hit with the bullet will be destroyed
         Destroy(gameObject); 
         //ScoreMan.GetComponent<ScoreManager>().scoreCount += 10;
         
      }
   }
}
