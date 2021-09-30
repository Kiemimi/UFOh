using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOMove : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D UFORigidBody;

    Vector2 movement;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movement.x = -1;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            movement.x = 1;
        }
        else
        {
            movement.x = 0;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            movement.y = -1;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            movement.y = 1;
        }
        else
        {
            movement.y = 0;
        }
    }

    void FixedUpdate()
    {
        UFORigidBody.MovePosition(UFORigidBody.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
