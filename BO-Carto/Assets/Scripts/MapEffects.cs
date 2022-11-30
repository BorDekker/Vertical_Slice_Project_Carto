using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapEffects : MonoBehaviour
{
    public float ZoomX, ZoomY;
    public float changePerSecondX, changePerSecondY;
    
    // Dit wil ik gebruiken om een max zoomuit te setten
    //public float MaxZoomX, MaxZoomY;

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(ZoomX, ZoomY, 1);
        if (Input.GetKey(KeyCode.M) && ZoomX >= 0f)
        {
            ZoomOutX();
        }

        if (Input.GetKey(KeyCode.M) && ZoomY >= 0f)
        {
            ZoomOutY();
        }
    }

    void ZoomOutX()
    {
        ZoomX += changePerSecondY * Time.deltaTime;
    }
    void ZoomOutY()
    {
        ZoomY += changePerSecondY * Time.deltaTime;
    }
}
