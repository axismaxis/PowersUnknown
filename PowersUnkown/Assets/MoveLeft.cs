using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float Speed;
    // Start is called before the first frame update
    void Start()
    {
        Speed = Settings.WallMovementSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Time.deltaTime * Speed, 0, 0);
    }
}
