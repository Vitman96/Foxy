using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cherry_colider : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    
     void OnTriggerEnter2D(Collider2D col)
    {
        PlayerMovement.runSpeed +=10;
        audioSource.PlayOneShot(audioSource.clip);
        Destroy(gameObject);
    }
}
