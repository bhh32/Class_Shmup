using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour 
{
    [SerializeField] GameObject objToSpawn;

    float spawnTimer = 0f;
    [SerializeField] float restTime = 3f;

    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0f)
        {
           
           var newObj = Instantiate(objToSpawn, transform.position, Quaternion.identity) as GameObject;

            spawnTimer = restTime;
        }
    }
}
