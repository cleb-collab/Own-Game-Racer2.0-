using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] carPrefabs;
    public int carIndex;
	private float spawnRangeX = -15;
	private float spawnRangeZ = -430.0f;
	private float startDelay = 3;
	private float spawnInterval = 1.0f;

    private float spawnLocRangeX = -14.5f;
	private float spawnLocRangeZ = -840.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomCar", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomLocation", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    void SpawnRandomCar()
	{
          int carIndex = Random.Range(0, carPrefabs.Length);
		  Vector3 spawnPos = new Vector3(Random.Range(7, -12), 1, spawnRangeZ);
		  Instantiate(carPrefabs[carIndex], spawnPos, carPrefabs[carIndex].transform.rotation);
    }
    void SpawnRandomLocation()
	{
          int carIndex = Random.Range(0, carPrefabs.Length);
		  Vector3 spawnPos = new Vector3(Random.Range(7, -12), 1, spawnLocRangeZ);
		  Instantiate(carPrefabs[carIndex], spawnPos, carPrefabs[carIndex].transform.rotation);
    }
}
