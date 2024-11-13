using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLevelGenerator : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public int numberOfObstacles = 20;
    public float levelWidth = 20f;
    public float minX = 1f;
    public float maxX = 10f;
     public float minZ = 1f;
    public float maxZ = 10f;
   

    void Start()
    {
        GenerateLevel();
    }

    void GenerateLevel()
    {
        for (int i = 0; i < numberOfObstacles; i++) // loops through the number of obsitcals set and then stops at 20
        {
            // looks for a point within the game between the level width its assigned levelwidth. randoms the x,y and z postions
            Vector3 spawnPosition = new Vector3(Random.Range(0, levelWidth), Random.Range(0, levelWidth), Random.Range(0, levelWidth)); 
            Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity); // spawning clones of the prefab that has been assigned to the spawn postition 
        }
    }
}