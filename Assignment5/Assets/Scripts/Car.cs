using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * Car.cs
 * Assignment 5
 * This is a vehicle subclass to differentiate the vehicles in the factory pattern.
 */

public class Car : Vehicle
{
    void Start()
    {
        this.VehicleType = "Car";
        this.Speed = 15;
    }
}
