using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_script : MonoBehaviour
{
  
    public AudioSource audioSource;
    public AudioClip clip;

    void OnTriggerEnter2D(Collider2D col)
    {
        ScoreTextScribt.coinAmount +=1;
        audioSource.PlayOneShot(audioSource.clip);
        Destroy(gameObject);
    }
}
