using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Sample_UI_InputField : MonoBehaviour
{
    public TMP_InputField InputField_Focus;
    public TMP_InputField InputField_SetPlaceHolder;
    public TMP_InputField InputField_Get, InputField_Set;
    public TMP_InputField InputField_ValueChanged;
    // Start is called before the first frame update
    void Start()
    {
        SetFocus(InputField_Focus);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetFocus(TMP_InputField InputField)
    {
        InputField.Select(); // focus
    }

    public void OnClick_ClearInputFieldPlaceHolder()
    {
        TMP_Text Text = InputField_Focus.transform.GetChild(0).Find("Placeholder").GetComponent<TMP_Text>();
        Text.text = "";
    }

    public void OnClick_ClearInputField()
    {
        TMP_InputField Text = InputField_Focus.GetComponent<TMP_InputField>();
        Text.text = "";
        InputField_Focus.Select(); // focus
    }

    public void OnClick_SetInputFieldPlaceHolder(string text)
    {
        TMP_Text Text = InputField_SetPlaceHolder.transform.GetChild(0).Find("Placeholder").GetComponent<TMP_Text>();
        Text.text = text;
    }

    public void OnClick_GetInputField()
    {
        TMP_InputField Text = InputField_Get.GetComponent<TMP_InputField>();
        print(Text.text);
    }

    public void OnClick_SetInputField(string text)
    {
        TMP_InputField Text = InputField_Set.GetComponent<TMP_InputField>();
        Text.text = text;
    }

    public void OnValueChanged_Print()
    {
        TMP_InputField Text = InputField_ValueChanged.GetComponent<TMP_InputField>();
        print(Text.text);
    }
}
