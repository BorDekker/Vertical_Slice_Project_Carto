using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourAI : MonoBehaviour
{
    public Vector3 velocity = new Vector3();

    public GameObject[] waypointsKid;
    int waypointsKidIndex = 0;

    [SerializeField]
    float moveSpeedKid = 2f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = waypointsKid[waypointsKidIndex].transform.position;

        /*
        velocity.x = Random.Range(-5, 5);
        velocity.y = Random.Range(-5, 5);
        */
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(GameObject.FindGameObjectWithTag("Kid"))
        {
            transform.position += velocity * Time.deltaTime;

            if(transform.position.x > 3)
            {
                velocity.x = -velocity.x;
            }
            if(transform.position.x < -3)
            {
                velocity.x = -velocity.x;
            }

            if(transform.position.y > 3)
            {
                velocity.y = -velocity.y;
            }
            if(transform.position.y < -3)
            {
                velocity.y = -velocity.y;
            }
        }
        */

        transform.position = Vector3.MoveTowards(transform.position, waypointsKid[waypointsKidIndex].transform.position, moveSpeedKid * Time.deltaTime);
    }
}
