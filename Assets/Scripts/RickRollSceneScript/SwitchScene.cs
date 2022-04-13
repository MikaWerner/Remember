using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    //show image
    //light

    //camera collides with triggerzone
    void OnTriggerEnter(Collision coll)
    {
        if (coll.collider.tag == "MainCamera")
        {
            LoadScene();
        }
    }

    void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
