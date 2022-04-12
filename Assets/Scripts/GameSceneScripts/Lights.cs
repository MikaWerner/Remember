using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{
    //Answer
    //bool correctAnswer = false;
    //bool wrongAnswer = false;

    public GameObject GreenLight;
    public GameObject RedLight;

    private bool lightStatus = false;

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Y))
        {
        CorrectEyes();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            WrongEyes(); 
        }

        //correctAnswer
        void CorrectEyes()
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
        void WrongEyes()
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

}
