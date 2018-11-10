using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tail : MonoBehaviour {

	public FollowNext first; // The first sphere trailing behind the player
	private FollowNext last; // The last sphere trailing behind the player
	
	static int count = 0;

	void Start() {
		last = first;
	}

	void Update() {
		last.UpdateMove();
	}

	public void Add() {
		Debug.Log("Adding tail");
		FollowNext temp = Instantiate(last);
		temp.name = "Tail" + count.ToString();
		count++;
		temp.follow = last;
		temp.waitTime = 0.1f;
		temp.initial = false;
		last = temp.GetComponent<FollowNext>();
	}
}
