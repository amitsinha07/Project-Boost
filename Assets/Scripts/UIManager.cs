using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject IntroScreen;
    [SerializeField] GameObject MenuScreen;
    [SerializeField] GameObject ControlsMenu;
    [SerializeField] TMP_Text textMeshProText;
    Scene currentScene;


    void Start()
    {
        currentScene = SceneManager.GetActiveScene();

       
        if (IntroScreen != null && currentScene.name == "UI")
        {
            IntroScreen.SetActive(true);
            StartCoroutine(EnableScreen());
        }
        else
        {
            if (ControlsMenu != null)
            {
                ControlsMenu.SetActive(true);
            }
        }
    }


    void Update()
    {
        
        if (currentScene != null)
        {
            switch (currentScene.name)
            {
                case "Level-1":
                    if(textMeshProText != null)
                        textMeshProText.text = "Level 01";
                    break;
                case "Level-2":
                    if(textMeshProText != null)
                        textMeshProText.text = "Level 02";
                    break;
                case "Level-3":
                    if (textMeshProText != null)
                        textMeshProText.text = "Level 03";
                    break;
                case "Level-4":
                    if (textMeshProText != null)
                        textMeshProText.text = "Level 04";
                    break;
                case "Level-5":
                    if (textMeshProText != null)
                        textMeshProText.text = "Level 05";
                    break;
                case "Level-6":
                    if (textMeshProText != null)
                        textMeshProText.text = "Level 06";
                    break;

            }
        }

    }

    IEnumerator EnableScreen()
    {

        yield return new WaitForSeconds(3.0f);
        IntroScreen.SetActive(false);
        MenuScreen.SetActive(true);
    }
}
