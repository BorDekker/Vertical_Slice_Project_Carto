using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapEffects : MonoBehaviour
{
    public float ZoomZ;
    public float changePerSecondZ;
    
    // Dit wil ik gebruiken om een max zoomuit te setten
    //public float MaxZoomX, MaxZoomY;

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(0, 0 , ZoomZ);
        if (Input.GetKey(KeyCode.M) && ZoomZ >= -50f)
        {
            ZoomOutZ();
        }
    }

    void ZoomOutZ()
    {
        ZoomZ += changePerSecondZ * Time.deltaTime;
    }
}
