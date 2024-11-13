using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endlessgenration : MonoBehaviour
{
    public Transform startPos;
    int nextStep=0;
    public GameObject[] PrefabsRoad;

    // Update is called once per frame
    void Update()
    { 
        nextStep += 1;
        Instantiate(PrefabsRoad[Random.Range(0,PrefabsRoad.Length)], new Vector3(startPos.position.x,startPos.position.y,transform.position.z + nextStep), Quaternion.identity);
    }
}
