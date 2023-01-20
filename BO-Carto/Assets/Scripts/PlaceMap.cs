using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceMap : MonoBehaviour
{
    [SerializeField]
    private Camera mainCamera;

    [SerializeField]
    GameObject mapPosition;

    public GameObject selectedMapPiece;

    bool cursorMap;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);

        mouseWorldPosition.z = 0;
        transform.position = mouseWorldPosition;

        if(Input.GetKeyDown(KeyCode.Mouse0) && cursorMap && selectedMapPiece.GetComponent<ClickDragMap>().mapOnItsPlace == mapPosition.transform.name)
        {
            //
        }
    }
}
