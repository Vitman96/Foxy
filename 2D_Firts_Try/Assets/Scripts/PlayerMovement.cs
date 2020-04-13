using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{

       public CharacterController2D controller;


       public AudioSource jumpSound;
       public AudioSource crouchSound;
       public AudioClip clip;
       public float bgmVolume= 0.5f;

       public Animator animator;

       public static float runSpeed = 40f;

       float horizontalMove  = 0f;

       bool jump = false;

       bool crouch = false;

        // Update is called once per frame
       void Update(){
         horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
      
         animator.SetFloat("Speed",Mathf.Abs(horizontalMove));
         
         if(Input.GetButtonDown("Jump")){
            jump = true;
            animator.SetBool("isJumping",true); 
            jumpSound.PlayOneShot(jumpSound.clip);
         }

         if(Input.GetButtonDown("Crouch")){
            crouch = true;
         }else if(Input.GetButtonUp("Crouch")){
            crouch = false;
         }
       }

       public void OnLanding(){
        animator.SetBool("isJumping",false);
       }

       public void OnCrunching(bool crouching){
        animator.SetBool("isCrouching",crouching);
        crouchSound.PlayOneShot(crouchSound.clip);
       }

       void FixedUpdate(){
         controller.Move(horizontalMove * Time.fixedDeltaTime,crouch , jump);
         jump = false;
       }
}
