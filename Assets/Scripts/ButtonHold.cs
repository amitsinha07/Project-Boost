using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonHold : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool isButtonPressed = false;
    public void YourFunctionToCall()
    {
        // Your code here.
        Movement.instance.moveUp();
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isButtonPressed = true;
        InvokeRepeating("YourFunctionToCall", 0f, 0.01f); 
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isButtonPressed = false;
        CancelInvoke("YourFunctionToCall"); 
    }
}