using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] carPrefabs;
    public int carIndex;
	private float spawnRangeX = -12;
	private float spawnRangeZ = -191.0f;
	private float startDelay = 3;
	private float spawnInterval = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomCar", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    void SpawnRandomCar()
	{
          int carIndex = Random.Range(0, carPrefabs.Length);
		  Vector3 spawnPos = new Vector3(Random.Range(-1, -11), 1, spawnRangeZ);
		  Instantiate(carPrefabs[carIndex], spawnPos, carPrefabs[carIndex].transform.rotation);
    }
}
