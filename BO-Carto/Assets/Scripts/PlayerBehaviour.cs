using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float movementSpeed;

    public Rigidbody2D rb2D;

    private Vector2 movementDirection;

    // Update is called once per frame
    void Update()
    {
        ProcessingInputs();
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessingInputs()
    {
        float movementX = Input.GetAxisRaw("Horizontal");
        float movementY = Input.GetAxisRaw("Vertical");

        movementDirection = new Vector2(movementX, movementY).normalized;
    }

    void Move()
    {
        rb2D.velocity = new Vector2(movementDirection.x * movementSpeed, movementDirection.y * movementSpeed);
    }
}
