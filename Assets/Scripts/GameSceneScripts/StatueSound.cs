using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatueSound : MonoBehaviour
{
    //play sounds after answer is correct


    //create List of AudioClips for Statue
    public List<AudioClip> SoundEffectsStatue = new List<AudioClip>();

    public AudioSource audioSource;

    //Play selected AudioClip from list
    public void PlayNoteS(int noteIndex)
    {
        audioSource.PlayOneShot(SoundEffectsStatue[noteIndex]);
    }

    //Statue_Answers.bool = true;
}
