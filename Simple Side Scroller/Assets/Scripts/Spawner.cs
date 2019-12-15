using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public Transform[] spawnPoints;
    public GameObject[] hazards;

    private float timeBtwSpawns = 0;
    public float startTimeBtwSpawns;

	// Update is called once per frame
	void Update () {
        if (timeBtwSpawns <= 0)
        {
            Transform rndSpawnPoint = spawnPoints[Random.Range(0, 8)];

            GameObject rndHazard = hazards[0];
            Instantiate(rndHazard, rndSpawnPoint.position, Quaternion.identity);
            timeBtwSpawns = startTimeBtwSpawns;
        } else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
	}
}
