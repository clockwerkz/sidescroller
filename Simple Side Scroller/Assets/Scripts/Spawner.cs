using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public Transform[] spawnPoints;
    public GameObject[] hazards;

    private float timeBtwSpawns = 0;
    public float startTimeBtwSpawns;

    public float minTimeBetweenSpawns;
    public float decrease;

    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if (player)
        {
            if (timeBtwSpawns <= 0)
            {
                Transform rndSpawnPoint = spawnPoints[Random.Range(0, 8)];

                GameObject rndHazard = hazards[0];
                Instantiate(rndHazard, rndSpawnPoint.position, Quaternion.identity);
                if (startTimeBtwSpawns > minTimeBetweenSpawns)
                {
                    startTimeBtwSpawns -= decrease;
                }
                timeBtwSpawns = startTimeBtwSpawns;
            }
            else
            {
                timeBtwSpawns -= Time.deltaTime;
            }
        }
    }
}
