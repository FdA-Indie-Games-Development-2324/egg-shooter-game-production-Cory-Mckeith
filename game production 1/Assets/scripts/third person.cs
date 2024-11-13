using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdperson : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;

    public float speed = 6f;

    public float turnSmoothTime = 0.1f;

    float turnSmoothVelocity;

 

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        Vector3 direction = new Vector3(horizontal, 0f, 0).normalized;
        
        if(Input.GetKey(KeyCode.A)){
            controller.Move(-transform.right  * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.D)){
            controller.Move(transform.right  * speed * Time.deltaTime);
        }

        controller.Move(transform.forward  * speed * Time.deltaTime);

       
        
    }
}
