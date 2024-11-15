using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;
    // Start is called before the first frame update
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>(); 
    }

    void OnTriggerExit (Collider other)
    {
        if(other.CompareTag("Player")){
            groundSpawner.SpawnTile();
            Destroy(gameObject, 2);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
