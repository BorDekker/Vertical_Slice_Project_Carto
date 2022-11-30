using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapEffects : MonoBehaviour
{
    public float variableToChangeX, variableToChangeY;
    public float changePerSecondX, changePerSecondY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(variableToChangeX, variableToChangeY, 1);
        //variableToChangeX += changePerSecond * Time.deltaTime;
        //variableToChangeY += changePerSecond * Time.deltaTime;
        if (Input.GetKey(KeyCode.M))
        {
            variableToChangeX += changePerSecondX * Time.deltaTime;
            variableToChangeY += changePerSecondY * Time.deltaTime;
        }
    }
}
