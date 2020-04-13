using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMusic : MonoBehaviour
{
    public AudioClip newTrack;

    private AudioMangager audioManager;
    
    // Start is called before the first frame update
    void Start(){
        audioManager = FindObjectOfType<AudioMangager>();
    }

    void OnTriggerEnter2D(Collider2D col){
        if(newTrack != null){
            audioManager.ChangeBGM(newTrack);
		}
    }
}
