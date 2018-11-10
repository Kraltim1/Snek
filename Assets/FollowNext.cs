using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowNext : MonoBehaviour {

	// Use this for initialization
	// Given another object as reference, will move towards that object at a fixed pace
	// If several objects do this in a chain, it should create a moving snake like effect

	public FollowNext follow;
	public float speed = 1;
	public float waitTime = 1;

	public GameObject player;
	public bool initial = false; // True only for first sphere
	
	// Update is called once per frame
	public void UpdateMove () {
		// Newly spwaned spheres behind the snake require to lag for a few seconds first
		if(waitTime > 0) {
			waitTime -= Time.deltaTime;
		} else {
			// If the initial sphere, follow after player, else, follow after the next sphere
			if(initial) {
				transform.position = Vector3.Lerp(transform.position, player.transform.position, Time.deltaTime * 10); // Not really that accurate
			} else {
				transform.position = Vector3.Lerp(transform.position, follow.transform.position, Time.deltaTime * 10);
			}
		}

		if(!initial) {
			follow.UpdateMove(); // Tell the following sphere to move itself
		}
	}
}
