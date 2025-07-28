using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class InputConversionHandler : MonoBehaviour
{
    [SerializeField] TMP_InputField InputField;
    [SerializeField] TextMeshProUGUI resultText;

    public void validateInput()
    {
        string input = InputField.text;
        float newInput = float.Parse(input) * 2.205f;
        input = newInput.ToString("0.00") + " Kg";
        resultText.text = input; 
    }
}
