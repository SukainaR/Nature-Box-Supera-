using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.DrawRay(mousePos, Camera.main.transform.forward * 1000, Color.green);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
