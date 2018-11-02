using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSounds : MonoBehaviour {

Object[] myMusic; // declare this as Object array
     
	//AudioSource a;

     void Awake () {
		//a = GetComponent<AudioSource>();
        myMusic = Resources.LoadAll("Music/Pickups",typeof(AudioClip));
		Debug.Log("Tracks found: " + myMusic.Length);
        //a.clip = myMusic[0] as AudioClip;
     }
     
     public void playRandomMusic() {
		AudioSource a = gameObject.AddComponent<AudioSource>();
        a.clip = myMusic[Random.Range(0,myMusic.Length)] as AudioClip;
        a.Play();
     }
}
