using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControl : MonoBehaviour
{
    private bool isTouching = false;

    private void Update()
    {
        // Check for touch events
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touch = Input.GetTouch(i);

            // Check if a finger started touching the screen
            if (touch.phase == TouchPhase.Began)
            {
                isTouching = true;
                // Call your function when touch begins
                Movement.instance.moveUp();
            }
            // Check if a finger is still touching the screen
            else if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
            {
                // Call your function while touch is active
                Movement.instance.moveUp();
            }
            // Check if a finger is removed from the screen
            else if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
            {
                isTouching = false;
            }
        }
    }
}
