using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSounds : MonoBehaviour {

    public AudioClip hitSound;

    public void playHitSound(){
        AudioSource a = gameObject.AddComponent<AudioSource>();
        a.clip = hitSound;
        a.Play();
    }
    
}
