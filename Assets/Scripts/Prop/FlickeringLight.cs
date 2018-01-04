using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour
{


    private Light thisLight;
    private Color originalColor;
    private float timePassed = 0;
    private float changeValue = 0;

    // Use this for initialization
    void Start()
    {
        thisLight = GetComponent<Light>();
        if (thisLight != null)
        {
            originalColor = thisLight.color;
        }
        else
        {
            enabled = false;
            return;
        }

    }

    // Update is called once per frame
    void Update()
    {
        timePassed = Mathf.Ceil(Time.time);
        //  Debug.Log(timePassed);
    }

    private float CalculateChange()
    {
        changeValue = -Mathf.Sin(timePassed * 12 * Mathf.PI) * 0.05f + 0.95f;
        return changeValue;
    }
}
