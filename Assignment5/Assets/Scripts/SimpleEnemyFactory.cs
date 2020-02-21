using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * SimpleEnemyFactory.cs
 * Assignment 5
 * This is the enemy factory to implement the simple factory pattern.
 */

public class SimpleEnemyFactory : MonoBehaviour
{
    private GameObject vehicleToSpawn;

    public GameObject createVehicle(GameObject prefab, string type)
    {
        vehicleToSpawn = prefab;

        if (type.Equals("Car"))
        {
            if (vehicleToSpawn.GetComponent<Car>() == null)
            {
                vehicleToSpawn.AddComponent<Car>();
            }
        }
        else if (type.Equals("Truck"))
        {
            if (vehicleToSpawn.GetComponent<Truck>() == null)
            {
                vehicleToSpawn.AddComponent<Truck>();
            }
        }
        else if (type.Equals("Police"))
        {
            if (vehicleToSpawn.GetComponent<Police>() == null)
            {
                vehicleToSpawn.AddComponent<Police>();
            }
        }
        return vehicleToSpawn;
    }
}
