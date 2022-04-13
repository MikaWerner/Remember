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
        GreenLight.SetActive(true);
    }

    //wrongAnswer
    public void WrongEyes()
    {
        RedLight.SetActive(true);
    }

    public void ResetLights()
    {
        GreenLight.SetActive(false);
        RedLight.SetActive(false);
    }
}
