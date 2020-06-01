using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public static float WallMovementSpeed = 3.0f;
    public static float WallIntervalSpeed = 1.0f;

    public float WallSpeed = 3.0f;
    public float WallInterval = 1.0f;

    private void Awake()
    {
        WallMovementSpeed = WallSpeed;
        WallIntervalSpeed = WallInterval;
    }
}
