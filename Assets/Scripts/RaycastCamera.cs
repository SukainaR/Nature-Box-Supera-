using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastCamera : MonoBehaviour
{
    public Vector3 screenPosition;
    public Vector3 worldPosition;
    public LayerMask layersToHit;

    Ray ray;
    RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) ;

         screenPosition = Input.mousePosition;

         Ray ray = Camera.main.ScreenPointToRay(screenPosition);

        if (Physics.Raycast(ray, out RaycastHit hitData, layersToHit))
        {
            worldPosition = hitData.point;
        }

         transform.position = worldPosition;
   
    }

}
