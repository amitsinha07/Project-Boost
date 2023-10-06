using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControl : MonoBehaviour
{
    private bool isTouching = false;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                // Check if the touch hits the panel's collider
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
                {
                    // Call the moveUp() function when the panel is touched
                    Movement.instance.moveUp();
                }
            }
        }
    }
}
