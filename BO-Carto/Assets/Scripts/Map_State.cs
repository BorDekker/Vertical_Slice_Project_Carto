using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_State : MonoBehaviour
{

    public GameObject image;
    public enum State
    {
        OPEN,
        CLOSED
    }

    public State currentState = State.CLOSED;

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case State.OPEN:
                image.SetActive(true);
                if (Input.GetKeyDown(KeyCode.M))
                {
                    currentState = State.CLOSED;
                }
                break;

            case State.CLOSED:
                image.SetActive(false);
                if (Input.GetKeyDown(KeyCode.M))
                {
                    currentState = State.OPEN;
                }
                break;
        }
    }
}
