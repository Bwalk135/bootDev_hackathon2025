using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;

public class BarMathScript : MonoBehaviour
{
    //keepin it in freedom units (lbs) for now
    [SerializeField] private float baseBarWeight = 45f;
    private float barMathUpdated;
    private float fortyFive = 45f, thirtyFive = 35f, twentyFive = 25f, ten = 10f, five = 5f, twoFive = 2.5f;

    [SerializeField] private bool alreadyAdded = false;
    [SerializeField] private bool isAdding;

    public GameObject barMathHolder;
    public GameObject homeController;

    public TextMeshProUGUI bathMathResultText;
    [SerializeField] private string metricImperialText = " Lbs";
    public FreedomUnitConverter freedomUnitConverterScript;

    public void barMathButton()
    {
        homeController.SetActive(false);
        barMathHolder.SetActive(true);
    }

    public void backButton()
    {
        homeController.SetActive(true);
        barMathHolder.SetActive(false);
    }

    #region fortyFives
    public void add45()
    {
        barMathUpdated += (fortyFive * 2);
        isAdding = true;
        revealResultText();
    }
    public void sub45()
    {
        barMathUpdated -= (fortyFive * 2);
        isAdding = false;
        maintainBarWeight();
        revealResultText();
    }
    #endregion

    #region thirtyFives
    public void add35()
    {
        barMathUpdated += (thirtyFive * 2);
        isAdding = true;
        revealResultText();
    }
   public void sub35()
    {
        barMathUpdated -= (thirtyFive * 2);
        isAdding = false;
        maintainBarWeight();
        revealResultText();
    }
    #endregion

    #region twentyFives
    public void add25()
    {
        barMathUpdated += (twentyFive * 2);
        isAdding = true;
        revealResultText();
    }
    public void sub25()
    {
        barMathUpdated -= (twentyFive * 2);
        isAdding = false;  
        maintainBarWeight();
        revealResultText();
    }
    #endregion

    #region tens
    public void add10()
    {
        barMathUpdated += (ten * 2);
        isAdding = true;
        revealResultText();
    }
    public void sub10()
    {
        barMathUpdated -= (ten * 2);
        isAdding = false;
        maintainBarWeight();
        revealResultText();
    }
    #endregion

    #region fives
   public void add5()
    {
        barMathUpdated += (five * 2);
        isAdding = true;
        revealResultText();
    }
    public void sub5()
    {
        barMathUpdated -= (five * 2);
        isAdding = false;
        maintainBarWeight();
        revealResultText();
    }
    #endregion

    #region two_fives
    public void add2_5()
    {
        barMathUpdated += (twoFive * 2);
        isAdding = true;
        revealResultText();
    }
    public void sub2_5()
    {
        barMathUpdated -= (twoFive * 2);
        isAdding = false;
        maintainBarWeight();
        revealResultText();
    }
    #endregion

    void revealResultText()
    {
        if (alreadyAdded)
        {
            bathMathResultText.text = "Bar Math Result: " + barMathUpdated + metricImperialText;
        }
        else
        {
            alreadyAdded = true; 
            if (isAdding)
            {
                barMathUpdated += baseBarWeight;
            }
            else //is subtracting
            {
                barMathUpdated -= baseBarWeight;
            }
            bathMathResultText.text = "Bar Math Result: " + barMathUpdated + metricImperialText;
        }
    }
    void maintainBarWeight()
    {
        if (barMathUpdated <= baseBarWeight)
        {
            barMathUpdated = baseBarWeight;
        }
    }

    void weightConversion()
    {
        if (!freedomUnitConverterScript.isMetric)
        {
            metricImperialText = " Kg";
            barMathUpdated *= 0.4536f;
        }
        if (freedomUnitConverterScript.isMetric)
        {
            metricImperialText = " Lbs";
            //barMathUpdated *= 0.4536f;
        }
    }
}
