using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * EnemySpawner.cs
 * Assignment 5
 * This is the enemy spawner class.
 */

public class EnemySpawner : MonoBehaviour
{
    public SimpleEnemyFactory factory;
    public SimplePrefabFactory prefabFactory;
    private GameObject vehicle;
    private GameManager gameManager;
    private float spawnPosZ = 15;
    private float delay = 0.5f;
    private float spawnRangeX = 20;
    private float spawnInterval = 1;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void spawnVehicle(string type)
    {
        vehicle = prefabFactory.createVehicle(type);
        vehicle = factory.createVehicle(vehicle, type);

        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while(gameManager.isGameActive)
        {
            yield return new WaitForSeconds(delay);
            InvokeRepeating("spawnVehicle", delay, spawnInterval);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 1, spawnPosZ);
            Instantiate(vehicle, spawnPos, vehicle.transform.rotation);
        }
    }
}
