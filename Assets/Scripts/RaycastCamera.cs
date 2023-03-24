using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaycastCamera : MonoBehaviour
{
    //  public Vector3 screenPosition;
    //  public Vector3 worldPosition;
    //   public LayerMask layersToHit;

    // Ray cameraRay;
    //  RaycastHit hit;
    public float rayDistance = 10.0f;

    public Text objectLabel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        Debug.DrawRay(cameraRay.origin, cameraRay.direction * rayDistance);

        if (Physics.Raycast(cameraRay, out hit, rayDistance))
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log(hit.collider.gameObject.name + " was hit");
                //objectLabel.text = hitObject.collider.gameObject.name;
            }
        }




        //  screenPosition = Input.mousePosition;

        //  Ray ray = Camera.main.ScreenPointToRay(screenPosition);

        // if (Physics.Raycast(ray, out RaycastHit hitData, layersToHit))
        // {
        //      worldPosition = hitData.point;
        //  }

        //  transform.position = worldPosition;

    }

}
