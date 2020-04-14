using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemytHitSound : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;
    public Animator animator;
     void OnTriggerEnter2D(Collider2D col)
    {
        animator.SetBool("isHurt",true); 
        Invoke("SetBoolBack", 0.25f);
        if(ScoreTextScribt.coinAmount >0){
            ScoreTextScribt.coinAmount -=1;

            audioSource.PlayOneShot(audioSource.clip);
        }
        //animator.SetBool("isHurt",false); 
    }

   private void SetBoolBack()
   {
       animator.SetBool("isHurt",false); 
   }
}
