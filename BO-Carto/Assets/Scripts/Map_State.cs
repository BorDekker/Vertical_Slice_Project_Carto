using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_State : MonoBehaviour
{
    public float xPosition, yPosition, zPosition;
    public float changePerSecondY;
    public float changePerSecondZ;


    public GameObject image;
    public GameObject Camera;
    public enum State
    {
        OPEN,
        CLOSED
    }

    public State currentState = State.CLOSED;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Camera.transform.localPosition = new Vector3(xPosition, yPosition, zPosition);

        Debug.Log("curr" + currentState);
        switch (currentState)
        {
            case State.OPEN:
                image.SetActive(true);
                if(yPosition <=43 && zPosition >= -59)
                {
                    yPosition += changePerSecondY * Time.deltaTime;
                    zPosition += changePerSecondZ * Time.deltaTime;
                }
                if (Input.GetKeyDown(KeyCode.M))
                {
                    currentState = State.CLOSED;
                }
                break;

            case State.CLOSED:
                image.SetActive(false);
                if (yPosition >= 11.26308f && zPosition <= -27.90452f)
                {
                    yPosition -= changePerSecondY * Time.deltaTime;
                    zPosition -= changePerSecondZ * Time.deltaTime;
                }
                if (Input.GetKeyDown(KeyCode.M))
                {
                    currentState = State.OPEN;
                }
                break;
        }
    }
}
