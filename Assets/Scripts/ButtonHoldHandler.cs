using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonHoldHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool isButtonPressed = false;
    public float repeatRate = 0.2f; // Adjust the rate at which the function is called.

    private void Start()
    {
        // Disable the button's default onClick behavior.
        Button button = GetComponent<Button>();
        button.onClick.AddListener(() => { });
    }

    private void Update()
    {
        if (isButtonPressed)
        {
            // Call your function here.
            YourFunctionToCallWhileHoldingButton();
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isButtonPressed = true;
        InvokeRepeating("YourFunctionToCallWhileHoldingButton", 0f, repeatRate);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isButtonPressed = false;
        CancelInvoke("YourFunctionToCallWhileHoldingButton");
    }

    // Define the function you want to call repeatedly here.
    private void YourFunctionToCallWhileHoldingButton()
    {
        // Place your code here.
        Debug.Log("Button is being held!");
    }
}
