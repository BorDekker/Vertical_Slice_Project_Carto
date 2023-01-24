using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            animator.SetBool("Walking", true);
        }

        else
        {
            animator.SetBool("Walking", false);
        }

        if (Input.GetKey("d"))
        {
            animator.SetBool("Walking", true);
        }

        if (!Input.GetKey("d"))
        {
            animator.SetBool("Walking", false);
        }

        if (Input.GetKey("a"))
        {
            animator.SetBool("Walking", true);
        }

        if (!Input.GetKey("a"))
        {
            animator.SetBool("Walking", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("Walking", true);
        }

        if (!Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("Walking", false);
        }
    }
}
