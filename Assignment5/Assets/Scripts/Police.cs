using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * Police.cs
 * Assignment 5
 * This is a vehicle subclass to differentiate the vehicles in the factory pattern.
 */

public class Police : Vehicle
{
    void Start()
    {
        this.VehicleType = "Police";
        this.Speed = 20;
    }
}
