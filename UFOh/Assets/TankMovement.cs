using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D tankRigidBody;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey("a"))
        {
            movement.x = -1;
        }
       else if (Input.GetKey("d"))
        {
            movement.x = 1;
        }
       else
        {
            movement.x = 0;
        }

        if (Input.GetKey("s"))
        {
            movement.y = -1;
        }
        else if (Input.GetKey("w"))
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
        Debug.Log(tankRigidBody.position + movement * moveSpeed * Time.fixedDeltaTime);
        tankRigidBody.MovePosition(tankRigidBody.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
