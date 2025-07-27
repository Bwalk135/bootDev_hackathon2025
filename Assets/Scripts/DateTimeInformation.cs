using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DateTimeInformation : MonoBehaviour
{
    private void Start()
    {
        string time = System.DateTime.UtcNow.ToLocalTime().ToString("HH: mm");
        print(time);
    }
}
