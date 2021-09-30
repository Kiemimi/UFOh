using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{

    public float moveSpeed = 500f;
    public Rigidbody2D tankRigidBody;
    Vector3 getTrans;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            transform.Rotate(0, 0, 120 * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(0, 0, -120 * Time.deltaTime);
        }

        if (Input.GetKey("s") == true)
        {
            getTrans = transform.up;
            tankRigidBody.velocity = -getTrans * moveSpeed;
        }
        if (Input.GetKey("w") == true)
        {
            getTrans = transform.up;
            tankRigidBody.velocity = getTrans * moveSpeed;
        }

        if (Input.GetKeyUp("s"))
        {
            tankRigidBody.velocity = -(Vector2)transform.TransformDirection(Vector3.up) * 0;
        }
        if (Input.GetKeyUp("w"))
        {
            tankRigidBody.velocity = (Vector2)transform.TransformDirection(Vector3.up) * 0;
        }
    }
}
