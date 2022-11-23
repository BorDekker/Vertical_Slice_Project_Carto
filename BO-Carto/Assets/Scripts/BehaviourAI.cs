using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourAI : MonoBehaviour
{
    public GameObject[] waypointsKid;
    public int waypointsKidIndex = 0;

    [SerializeField]
    float moveSpeedKid = 2f;

    // Start is called before the first frame update
    void Start()
    {
        waypointsKidIndex = Random.Range(0, 12);

        transform.position = waypointsKid[waypointsKidIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, waypointsKid[waypointsKidIndex].transform.position, moveSpeedKid * Time.deltaTime);

        if(transform.position == waypointsKid[waypointsKidIndex].transform.position)
        {
            waypointsKidIndex = Random.Range(0, 12);
        }
    }
}
