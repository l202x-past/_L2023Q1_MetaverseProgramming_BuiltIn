using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample_UI_Dropdown : MonoBehaviour
{
    public void Dropdown_SelectFunction()
    {
        print("Select Done");        
    }

    public void Dropdown_SelectFunction_DynamicInt(int i)
    {
        string s = string.Format("Select {0} Done.", i);
        print(s);        
    }
}
