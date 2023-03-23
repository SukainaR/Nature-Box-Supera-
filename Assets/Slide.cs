using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{
    public Sprite PageImage;
    public List<Sprite> Numbers;
    public int PageNumber;

    private Vector2 startTouchposition;
    private Vector2 endTouchposition;

    private void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchposition = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchposition = Input.GetTouch(0).position;

            if (endTouchposition.x < startTouchposition.x)
            {
                NextPage();
            }

            if (endTouchposition.x < startTouchposition.x)
            {
                PreviousPage();
            }
        }
    }

    private void PreviousPage()
    {
        PageNumber--;
        PageImage = Numbers[PageNumber];
    }

    private void NextPage()
    {
        PageNumber++;
        PageImage = Numbers[PageNumber];
    }
}
