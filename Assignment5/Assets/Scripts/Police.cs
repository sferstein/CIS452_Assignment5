using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Police : Vehicle
{
    void Start()
    {
        this.VehicleType = "Police";
        this.Speed = 20;
    }
}
