using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourAI : MonoBehaviour
{
    public GameObject[] waypointsAI;
    public int waypointsAIIndex = 0;

    [SerializeField]
    float moveSpeedKid = 2f;

    // Start is called before the first frame update
    void Start()
    {
        waypointsAIIndex = Random.Range(0, 12);

        transform.position = waypointsAI[waypointsAIIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, waypointsAI[waypointsAIIndex].transform.position, moveSpeedKid * Time.deltaTime);

        if(transform.position == waypointsAI[waypointsAIIndex].transform.position)
        {
            waypointsAIIndex = Random.Range(0, 12);
        }
    }
}
