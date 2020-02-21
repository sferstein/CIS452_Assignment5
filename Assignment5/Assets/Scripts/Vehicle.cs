using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * Vehicle.cs
 * Assignment 5
 * This is the initial vehicle class that will implement the other vehicle classes.
 */

public class Vehicle : MonoBehaviour
{
    protected string VehicleType { get; set; }
    protected float Speed { get; set; }

    private float boundary = -20;

    void Update()
    {
        if (transform.position.z < boundary)
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector3.right * Time.deltaTime * Speed);
    }
}
