using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * Truck.cs
 * Assignment 5
 * This is a vehicle subclass to differentiate the vehicles in the factory pattern.
 */

public class Truck : Vehicle
{
    void Start()
    {
        this.VehicleType = "Truck";
        this.Speed = 10;
    }
}
