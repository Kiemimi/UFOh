using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFMovement : MonoBehaviour
{

    public float UFOMoveSpeed = 5f;

    public Rigidbody2D UFORigidBody;

    Vector2 UFOmovement;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("LeftArrow"))
        {
            UFOmovement.x = -1;
        }
        else if (Input.GetKey("RightArrow"))
        {
            UFOmovement.x = 1;
        }
        else
        {
            UFOmovement.x = 0;
        }

        if (Input.GetKey("DownArrow"))
        {
            UFOmovement.y = -1;
        }
        else if (Input.GetKey("UpArrow"))
        {
            UFOmovement.y = 1;
        }
        else
        {
            UFOmovement.y = 0;
        }
    }

    void FixedUpdate()
    {
        UFORigidBody.MovePosition(UFORigidBody.position + UFOmovement * UFOMoveSpeed * Time.fixedDeltaTime);
    }
}
