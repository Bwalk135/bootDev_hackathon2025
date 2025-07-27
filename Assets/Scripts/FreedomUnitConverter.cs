using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FreedomUnitConverter : MonoBehaviour
{
    // convert lbs to kg by multiplying 0.4536
    //convert kg to lbs by multiplying 2.205

    [SerializeField] Toggle toggleObj;
    public bool isMetric;
    public void metricToggle()
    {
        bool state = toggleObj.isOn;
        print(state);
        if (state)
        {
            isMetric = true;
        }
        else
        {
            isMetric = false;
        }
    }
}
