using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sample_UI_Toggle_Single : MonoBehaviour
{
    public GameObject Toggle;
    void Start(){
        Toggle.GetComponent<Toggle>().isOn = false;
    }
    
    public void ToggleSingle(){
        print("toggle Single:" + Toggle.GetComponent<Toggle>().isOn);
    }

    public void ToggleSingleBool(bool value){ //dynamic
        print("toggle single bool:" + value);
    }

    public void ToggleSingleBoolButton(){
        print(Toggle.GetComponent<Toggle>().isOn);        
    }
}
