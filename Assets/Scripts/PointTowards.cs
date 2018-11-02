using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTowards : MonoBehaviour {

	public GameObject pickup;
	// Update is called once per frame
	void Update () {
		transform.LookAt(pickup.transform);
	}
}
