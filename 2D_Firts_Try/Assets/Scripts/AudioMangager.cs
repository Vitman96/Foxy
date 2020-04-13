using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMangager : MonoBehaviour
{
    public AudioSource audioSource;

    public void ChangeBGM(AudioClip music){

        if(audioSource.clip.name != music.name){
            audioSource.Stop();
            audioSource.clip = music;
            audioSource.PlayOneShot(audioSource.clip);
        }
    }
}
