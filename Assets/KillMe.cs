using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillMe : MonoBehaviour {
	public float aliveTime;

	public float currentAliveTime;
	public float newAliveTime;

	public GameObject c;
	
	void Update () {
		newAliveTime = c.GetComponent<CollisionManager>().aliveTime;

		// If the player picks up a new object, extend the life of it to make the trail longer
		if(newAliveTime != currentAliveTime) {
			aliveTime += newAliveTime - currentAliveTime;
			currentAliveTime = newAliveTime;
			//Debug.Log("Updating time");
		}

		aliveTime -= Time.deltaTime;
		if(aliveTime < 0) {
			Destroy(gameObject); //Goodbye!
		}
	}
}
