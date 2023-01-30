using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Vector3 velocity = new Vector3();
    float Movementspeed = 6f;

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Movementspeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += -transform.right * Movementspeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Movementspeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -transform.forward * Movementspeed * Time.deltaTime;
        }
    }
}
