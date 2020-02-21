using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle
{
    void Start()
    {
        this.VehicleType = "Car";
        this.Speed = 15;
    }
}
