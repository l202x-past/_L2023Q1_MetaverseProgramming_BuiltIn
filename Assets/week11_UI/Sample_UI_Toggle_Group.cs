using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sample_UI_Toggle_Group : MonoBehaviour
{
    void Start(){
        ToggleGroup TG = GameObject.Find("Toggle_Group").GetComponent<ToggleGroup>();
        TG.allowSwitchOff = true;
        TG.SetAllTogglesOff();
    }

    public void GetActiveToggles(){
        IEnumerable<Toggle> ActiveToggles = GetComponent<ToggleGroup>().ActiveToggles();
        foreach(Toggle ActiveToggle in ActiveToggles){
            print(ActiveToggle);
        }
    }
}
