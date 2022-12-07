using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDragMap : MonoBehaviour
{
    Vector3 difference = Vector3.zero;

    public string mapOnItsPlace;

    public void OnMouseDown()
    {
        difference = (Vector3)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector3)transform.position;
    }

    public void OnMouseDrag()
    {
        transform.position = (Vector3)Camera.main.ScreenToWorldPoint(Input.mousePosition) - difference;
    }
}
