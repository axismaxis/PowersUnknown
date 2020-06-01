using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.zero;
        if (Input.GetKey(KeyCode.A))
        {
            movement.x -= Time.deltaTime * Speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement.x += Time.deltaTime * Speed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            movement.y += Time.deltaTime * Speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movement.y -= Time.deltaTime * Speed;
        }

        transform.Translate(movement);
    }
}
