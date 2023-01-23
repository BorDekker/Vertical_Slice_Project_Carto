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

    public GameObject Player;
    public Image playerIcon;
    public enum State
    {
        OPEN,
        CLOSED
    }

    public State currentState = State.CLOSED;

    private void Start()
    {
        playerIcon.rectTransform.localPosition = new Vector3(0, 0, 0);
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
                // Get the player's current latitude and longitude
                float PlayerX = Player.transform.position.x;
                float PlayerZ = Player.transform.position.z;

                // Update the position of the player icon on the map
                playerIcon.transform.position = new Vector3(PlayerX += 950, PlayerZ += 550, 0);

                // Scale and position the player's icon
                playerIcon.rectTransform.localScale = new Vector3(2f, 1f, 2f);

                // Enable the player icon
                playerIcon.enabled = true;

                if (Input.GetKeyDown(KeyCode.M))
                {
                    currentState = State.CLOSED;
                }
                break;

            case State.CLOSED:
                playerIcon.enabled = false;
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
