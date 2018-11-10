using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lol : MonoBehaviour {

	public GameObject pickup;
	
	public float xD = 30.8f;

	void Start() {
		Invoke("asdf", xD);
	}
	public void asdf () {
		for(int i = 0; i < 200; i++) {
			GameObject temp = Instantiate(pickup);
			temp.GetComponent<pickup>().Randomize();
		}
	}
}
