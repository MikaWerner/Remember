using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge_Movement : MonoBehaviour
{
    private void Update()
    {
        //move object each time the melody is played correctly
        //starting location (0, -5, 170)
        //ending location (0, -5, 65)
        //30 lvls oooff

        //move Bridge
        if(Input.GetKeyDown(KeyCode.Q))
        {
            if(transform.position.z > 65f)
            {
                Debug.Log("Q pressed");
                transform.Translate(0, 0, -3.5f);
            }
            else
            {
                Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, 65f);
                Debug.Log("StopBridge");
            }
        }
    }

    //door opens, black, lights on, rick astley and never gonna give you up plays
}
