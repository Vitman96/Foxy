using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectHitSound : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;
     void OnTriggerEnter2D(Collider2D col)
    {
        audioSource.PlayOneShot(audioSource.clip);
    }
}
