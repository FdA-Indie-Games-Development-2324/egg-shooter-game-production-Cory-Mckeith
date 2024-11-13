using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBullet : MonoBehaviour
{
    public GameObject bullet;
    public GameObject firePoint;

    
    // Start is called before the first frame update
    
    // Update is called once per frame

    
    void Update()
    {
        if(Input.GetButtonDown("Fire1")) // looks in control settings to see what fire 1 is assigned to 
        {
            Shoot();
        }
    }

    void Shoot()
    {

      GameObject clone = Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation); // looks for a empty gameobject to shoot 
      Destroy(clone, 10f); //destroys clone very 10seconds

    }
}
