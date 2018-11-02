using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionManager : MonoBehaviour {

	public float aliveTime = 5;
	public float spawnRate = 0.2f;
	public GameObject ColliderPrefab;
	public Text scoreText;

	public bool alive = true;


	// Use this for initialization
	void Start () {
		InvokeRepeating("Spawn", 1, spawnRate);
		Time.timeScale = 1;
		SetScoreText();
	}
	
	// Update is called once per frame
	void Update () {
		SetScoreText();
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 0.2f)) { // Shoot ray ahead of player
			Debug.Log("Hit " + hit.transform.name);
			if(hit.transform.name != "Collider") {
				Debug.Log("Game over");
				Time.timeScale = 0.02f; // slow down time
				alive = false;
			}
		}
	}

	void Spawn() { // Spawns a trail of sphere behind player, not optimal, best to have a pool of pre spawned object already for better performance
		GameObject temp = Instantiate(ColliderPrefab);
		temp.GetComponent<KillMe>().aliveTime = aliveTime;
		temp.name = temp.GetInstanceID().ToString();
		temp.transform.position = gameObject.transform.position;
		temp.GetComponent<KillMe>().c = gameObject;
	}

	void SetScoreText() {
		if (alive) {
			scoreText.text = "Score: " + aliveTime.ToString();
		}
	}
}

