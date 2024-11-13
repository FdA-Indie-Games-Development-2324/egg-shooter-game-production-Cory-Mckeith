using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabrandoizer : MonoBehaviour
{
    public GameObject[] SpawnPoints;
     public GameObject[] colPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < SpawnPoints.Length; i++)
        {
            Instantiate(colPrefabs[Random.Range(0, colPrefabs.Length)],
            SpawnPoints[i].transform.position,Quaternion.identity, transform.parent);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
