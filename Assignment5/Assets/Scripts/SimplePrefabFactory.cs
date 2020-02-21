using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * SimplePrefabFactory.cs
 * Assignment 5
 * This is the prefab factory to help spawn the prefabs in the factory pattern.
 */

public class SimplePrefabFactory : MonoBehaviour
{
    public GameObject CarPrefab;
    public GameObject TruckPrefab;
    public GameObject PolicePrefab;
    private GameObject VehicleToSpawn;

    public GameObject createVehicle(string type)
    {
        VehicleToSpawn = null;

        if (type.Equals("Car"))
        {
            VehicleToSpawn = CarPrefab;
        }
        else if (type.Equals("Truck"))
        {
            VehicleToSpawn = TruckPrefab;

        }
        else if (type.Equals("Police"))
        {
            VehicleToSpawn = PolicePrefab;

        }
        return VehicleToSpawn;
    }
}
