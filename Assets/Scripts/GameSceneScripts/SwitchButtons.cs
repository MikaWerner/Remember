using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SwitchButtons : MonoBehaviour
{
    //references
    public List<MusicScale> buttons = new List<MusicScale>();
    public int activeButtonIndex = 0;
    public MusicScale activeButton;

    //functions

    private void Start()
    {
        ActiveButton();
    }

    private void Update()
    {
        //Controlls for A/D
        if (Input.GetKeyDown(KeyCode.D))
        {
            activeButtonIndex ++;
            ActiveButton();
            Debug.Log("Button nb." + activeButtonIndex);
        }
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            activeButtonIndex--;
            ActiveButton();
            Debug.Log("Button nb." + activeButtonIndex);
        }
    }

    void ActiveButton()
    {
        if (activeButtonIndex < 0)
        {
            activeButtonIndex = 0;
        }
        else if (activeButtonIndex >= buttons.Count)
        {
            activeButtonIndex = buttons.Count - 1;
        }

        if (activeButton != null)
        {
            activeButton.IsActive = false; //deactivates previous gameobject 
        }
        activeButton = buttons[activeButtonIndex]; //refresh index   
        activeButton.IsActive = true;
    }
}
