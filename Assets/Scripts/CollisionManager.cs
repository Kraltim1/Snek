using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionManager : MonoBehaviour {

	public float aliveTime = 5;
	public float spawnRate = 0.2f;
	public Text scoreText;

	public bool alive = true;

	public PickupSounds ps;


	public int score = 0;


	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
	}

	public float PickupCooldown = 0.1f;
	private float PickupCooldownValue = 0;
	
	// Update is called once per frame
	void Update () {
		if (alive) {
			scoreText.text = "Score: " + score.ToString();
		}
        RaycastHit hit;
		PickupCooldownValue -= Time.deltaTime;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 0.2f)) { // Shoot ray ahead of player
			Debug.Log("Hit " + hit.transform.name);
			if(hit.transform.name != "Collider") {
				Debug.Log("Game over");
				Time.timeScale = 0.02f; // slow down time
				alive = false;
			}
			if(hit.transform.tag == "PickUpCollider") {
				if(PickupCooldownValue < 0f) {
					//Debug.Log("Yay");
					ps.playHitSound();
					hit.transform.GetComponentInParent<pickup>().Randomize();

					score++;
					for(int i = 0; i < 10; i++) {
						//Debug.Log("HHEELLOOOOO?");
						StartCoroutine(ExecuteAfterTime((float)i / 10f));
					}
					PickupCooldownValue = PickupCooldown;
				}
			}
		}
	}

	 IEnumerator ExecuteAfterTime(float time) {
     	yield return new WaitForSeconds(time);
		gameObject.GetComponent<Tail>().Add();
	}
}

