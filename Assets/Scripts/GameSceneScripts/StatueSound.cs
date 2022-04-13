using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatueSound : MonoBehaviour
{

    //create List of AudioClips for Statue
    public List<AudioClip> SoundEffectsStatue = new List<AudioClip>();

    public AudioSource audioSource;

    //play selected audioclip from list
    public void PlayNote(int noteindex)
    {
        audioSource.PlayOneShot(SoundEffectsStatue[noteindex]);
    }
}
