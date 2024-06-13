using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 5.0f;

    void Update()
    {
        // Initialize movement vectore to zero
        Vector3 movement = Vector3.zero;

        // Check for input from player
        if (Input.GetKey(KeyCode.W)) 
        {
            movement.z += Speed;
        }  
        if (Input.GetKey(KeyCode.S))
        {
            movement.z -= Speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            movement.x -= Speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement.x += Speed;
        }

        // If any movement is detected, normalize and apply it
        if (movement != new Vector3(0, 0, 0))
        {
           movement = movement.normalized * Speed * Time.deltaTime;
            transform.position += movement;
        }

    }
}
