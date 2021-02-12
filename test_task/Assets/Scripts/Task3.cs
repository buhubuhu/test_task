using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task3 : MonoBehaviour
{
    private int clips;
    
    private void Start()
    {
        clips = GetComponentsInChildren<AudioSource>().Length;
    }
    public void PlayRandomSound()
    {
        if(clips == 0)
        {
            Debug.Log("Turn On atleast one sound");
            return;
        }

        AudioSource[] sound = GetComponentsInChildren<AudioSource>();
        

        sound[Random.Range(0, sound.Length)].Play();
        
    }
    public void SoundAdded()
    {
        clips++;
    }
    public void SoundDisabled()
    {
        clips--;
    }



    public void Kenney()
    {
        Application.OpenURL("https://kenney.nl/assets");
    
    }
    public void MyWork()
    {
        Application.OpenURL("https://www.reddit.com/user/buhubuhu");
    }
}
