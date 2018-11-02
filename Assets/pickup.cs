using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour {

	public float MaxHeight = 100;
	public float MaxWidth = 100;

	public GameObject p;

	public void GotHit() {
		//Debug.Log("xD");
		transform.position = new Vector3((Random.value * MaxWidth) - MaxWidth / 2, (Random.value * MaxHeight) - MaxHeight / 2, (Random.value * MaxWidth) - MaxWidth / 2);
		p.GetComponent<CollisionManager>().aliveTime++;
	}
}
