using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public Vector3 velocity = new Vector3();
    float Movementspeed = 6f;

    public GameObject Player;
    private bool isFacingRight = true;
    public Animator animator;

    //public Sprite playerRight;
    //public Sprite playerLeft;
    //public Sprite playerForward;
    //public Sprite playerBack;

    void Update()
    {
        animator.SetFloat("Speed", 0f);
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Movementspeed * Time.deltaTime;
            animator.SetFloat("Speed", Movementspeed);
            //Player.GetComponent<SpriteRenderer>().sprite = playerRight;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += -transform.right * Movementspeed * Time.deltaTime;
            animator.SetFloat("Speed", Movementspeed);
            //Player.GetComponent<SpriteRenderer>().sprite = playerLeft;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Movementspeed * Time.deltaTime;
            animator.SetFloat("Speed", Movementspeed);
            //Player.GetComponent<SpriteRenderer>().sprite = playerForward;
        } 

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -transform.forward * Movementspeed * Time.deltaTime;
            animator.SetFloat("Speed", Movementspeed);
            //Player.GetComponent<SpriteRenderer>().sprite = playerBack;
        }

        Flip();
    }

    private void Flip()
    {
        if (isFacingRight && Input.GetKey(KeyCode.A) || !isFacingRight && Input.GetKey(KeyCode.D))
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
