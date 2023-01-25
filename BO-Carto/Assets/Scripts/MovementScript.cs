using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public Vector3 velocity = new Vector3();
    float Movementspeed = 6f;

    public GameObject Player;

    public Animator animator;

    //public Sprite playerRight;
    //public Sprite playerLeft;
    //public Sprite playerForward;
    //public Sprite playerBack;

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Movementspeed * Time.deltaTime;
            animator.SetFloat("Speed", value: Movementspeed);
            //Player.GetComponent<SpriteRenderer>().sprite = playerRight;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += -transform.right * Movementspeed * Time.deltaTime;
            //Player.GetComponent<SpriteRenderer>().sprite = playerLeft;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Movementspeed * Time.deltaTime;
            //Player.GetComponent<SpriteRenderer>().sprite = playerForward;
        } 

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -transform.forward * Movementspeed * Time.deltaTime;
            //Player.GetComponent<SpriteRenderer>().sprite = playerBack;
        }

        animator.SetFloat("Speed", Mathf.Abs(Movementspeed));
    }
}
