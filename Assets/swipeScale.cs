using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swipeScale : MonoBehaviour
{
    private Vector2 startPosition;

    private void Update()
    {
        HandleScaleChange();    
    }

    private void HandleScaleChange()
    {
        Touch[] touches = Input.touches;
        if(touches.Length >= 1)
        {
            Touch currentTouch = touches[0];
            if(currentTouch.phase == TouchPhase.Began)
            {
                startPosition = currentTouch.position;
            }
            else if(currentTouch.phase == TouchPhase.Ended)
            {
                Vector2 endPosition = currentTouch.position;
                HandleSwipe(startPosition, endPosition);
            }
        }
    }

    private void HandleSwipe(Vector2 startPosition, Vector2 endPosition)
    {
        bool isUpwardSwipe = startPosition.y < endPosition.y;
        bool isDownwardSwipe = startPosition.y > endPosition.y;

        if(isUpwardSwipe)
        {
            transform.localScale = transform.localScale*1.1f;
        }
        else if(isDownwardSwipe)
        {
            transform.localScale = transform.localScale/1.1f;
        }
    }
}