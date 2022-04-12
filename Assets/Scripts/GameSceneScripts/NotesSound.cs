using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesSound : MonoBehaviour
{
    //create List of AudioClips for Buttons
    public List<AudioClip> SoundEffectsButton = new List<AudioClip>();

    public AudioSource audioSource;


    //Play selected AudioClip from list
    public void PlayNoteB(int noteIndex)
    {
        audioSource.PlayOneShot(SoundEffectsButton[noteIndex]);  
    }
}