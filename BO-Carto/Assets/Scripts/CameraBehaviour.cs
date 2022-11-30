using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    private GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveToPlayer = new Vector3(transform.position.x, transform.position.y, -10f);
        transform.position = Vector3.Lerp(transform.position, moveToPlayer, 10.0f * Time.deltaTime);
    }
}
