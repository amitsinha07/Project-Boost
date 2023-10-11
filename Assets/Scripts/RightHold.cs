using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RightHold : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool isButtonPressed = false;
    public void YourFunctionToCall()
    {
        // Your code here.
        Debug.Log("Hii my name is Amit");
        Movement.instance.ApplyRotation(100f);
        
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