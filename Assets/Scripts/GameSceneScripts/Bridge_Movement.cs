using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge_Movement : MonoBehaviour
{
    public void MoveBridge()
    {
        if (transform.position.z > 65f)
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
