using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDistroy : MonoBehaviour
{
    void Awake()
    {
        GameObject UIObj = GameObject.FindGameObjectWithTag("UI");
        DontDestroyOnLoad(this.gameObject);
    }
}
