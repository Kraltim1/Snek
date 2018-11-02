using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsHit : MonoBehaviour {

	public pickup p;
		void OnTriggerStay() {
			p.GotHit();
		}
}
