using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sample_UI_Button : MonoBehaviour
{
    // Game View Resolution = 800, 600

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick_ButtonFunction()
    {
        print("button clicked");
    }

    public void OnClick_ButtonFunction(int value)
    {
        print(value + " is passed to button function");
    }

    public void OnClick_ButtonFunction(string value)
    {
        print(value + " is passed to button function");
    }
}
