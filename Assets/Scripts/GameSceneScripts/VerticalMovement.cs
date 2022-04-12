using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    //Up/DownSteps counter
    [SerializeField] public int VerticalSteps = 0;

    //SoundEffect that will b played
    [SerializeField] public NotesSound sound;


    //references
    //[SerializeField] public GameObject obj;

    //Is the selected Object active?
    [SerializeField] public bool IsActive = false;


    void Update()
    {
        //Up/Down Movement
        if (IsActive)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                sound.PlayNoteB(0);
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                DownMovement();
                Debug.Log("HeavenlyMusic"); 
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                UpMovement();
                Debug.Log("HellishMusic");
            }
        }
    }


    //Functions to move the button up or down
    void UpMovement()
    {
        print("W was pressed");

        //max steps
        if (VerticalSteps < 7)
        {
            VerticalSteps++;
            transform.position += new Vector3(0, 0, 0.5f);
        }
        //use function PlayNote from NoteSound and connect it to VerticalSteps
        sound.PlayNoteB(VerticalSteps);
    }

    void DownMovement()
    {
        print("S was pressed");

        //min steps
        if (VerticalSteps > 0)
        {
            VerticalSteps--;
            transform.position += new Vector3(0, 0, -0.5f);
        }
        sound.PlayNoteB(VerticalSteps);
    }
}
