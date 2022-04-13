using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{
    public GameObject GreenLight;
    public GameObject RedLight;

    private bool lightStatus = false;


    //correctAnswer
    public void CorrectEyes()
    {
        if (lightStatus == true)
        {
            GreenLight.SetActive(false);
            lightStatus = false;
        }
        else if (lightStatus == false)
        {
            GreenLight.SetActive(true);
            lightStatus = true;
        }
    }

    //wrongAnswer
    public void WrongEyes()
    {
        if (lightStatus == true)
        {
            RedLight.SetActive(false);
            lightStatus = false;
        }
        else if (lightStatus == false)
        {
            RedLight.SetActive(true);
            lightStatus = true;
        }
    }

}
