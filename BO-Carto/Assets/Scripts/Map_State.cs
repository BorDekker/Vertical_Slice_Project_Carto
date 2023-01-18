using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map_State : MonoBehaviour
{
    [SerializeField] private CanvasGroup myUIGroup;

    public float xPosition, yPosition, zPosition;
    public float changePerSecondY;
    public float changePerSecondZ;

    public float ScalePerSecond;

    public float xScale;
    public float yScale;

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
        image.transform.localScale = new Vector3(xScale, yScale, 1);

        Debug.Log("curr" + currentState);
        switch (currentState)
        {
            case State.OPEN:
                image.SetActive(true);

                //Fading in UI
                if (xScale <= 4.2 && yScale <= 4.2 && xScale >= 1 && yScale >= 1)
                {
                    xScale -= ScalePerSecond * Time.deltaTime;
                    yScale -= ScalePerSecond * Time.deltaTime;
                }
                if (myUIGroup.alpha < 1)
                {
                    myUIGroup.alpha += Time.deltaTime * 2;
                }

                //Camera moves away from player
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
                //Fading out UI
                xScale = 4;
                yScale = 4;
                //dit werkt nog niet zoals ik wil, raadpleeg docent
                if (xScale <= 1 && yScale <= 1)
                {
                    xScale += ScalePerSecond * Time.deltaTime;
                    yScale += ScalePerSecond * Time.deltaTime;
                }
                if (myUIGroup.alpha >= 0)
                {
                    myUIGroup.alpha -= Time.deltaTime * 2;
                    if(myUIGroup.alpha == 0)
                    {
                        image.SetActive(false);
                    }
                }

                //Camera Moves towards player
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
