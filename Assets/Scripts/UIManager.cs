using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject IntroScreen;
    [SerializeField] GameObject MenuScreen;

    void Start()
    {
        IntroScreen.SetActive(true);
        StartCoroutine(EnableScreen());
    }

    void Update()
    {
        
    }

    IEnumerator EnableScreen()
    {

        yield return new WaitForSeconds(3.0f);
        IntroScreen.SetActive(false);
        MenuScreen.SetActive(true);
    }
}
