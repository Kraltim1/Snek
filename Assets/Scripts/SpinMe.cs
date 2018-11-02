using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinMe : MonoBehaviour {

	public float speed = 5;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.left, Time.deltaTime * speed);
		transform.Rotate(Vector3.right, Time.deltaTime * speed / 5);
	}
}
