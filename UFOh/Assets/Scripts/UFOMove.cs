using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOMove : MonoBehaviour
{
    public float moveSpeed = 500f;
    public Rigidbody2D UFORigidBody;
    Vector3 getTrans;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, -120 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, 120 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            getTrans = transform.up;
            UFORigidBody.velocity = -getTrans * moveSpeed;
        }
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            getTrans = transform.up;
            UFORigidBody.velocity = getTrans * moveSpeed;
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            UFORigidBody.velocity = -(Vector2)transform.TransformDirection(Vector3.up) * 0;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            UFORigidBody.velocity = (Vector2)transform.TransformDirection(Vector3.up) * 0;
        }
    }
}
