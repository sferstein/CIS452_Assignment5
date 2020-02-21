using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck : Vehicle
{
    void Start()
    {
        this.VehicleType = "Truck";
        this.Speed = 10;
    }
}
