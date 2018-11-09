//Attach this script to a GameObject.
//Create a Text GameObject (Create>UI>Text) and attach it to the My Text field in the Inspector of your GameObject
//Press the space bar in Play Mode to see the Text change.

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

	// int w, h;
	// Rect rect;
	// GUIStyle style;
	// string text;

	public CollisionManager c;

    // I'm not gonna fix this mess entirely, 
    // but I wanna make this linked to an actual text object so
    // here comes the spaghetti XD                  - Tetra
    public Text gameOverA;
    public Text gameOverB;
    public Text reticle;

	void Start() {
		// w = Screen.width;
		// h = Screen.height;
		// rect = new Rect(w/2, h/2, 193, 12);
		// style = new GUIStyle();
		// style.alignment = TextAnchor.UpperLeft;
		// style.fontSize = 28;
		// style.normal.textColor = new Color(1, 1, 1, 1.0f);

        gameOverA.text = "";
        gameOverB.text = "";
	}

	void Update() {
		if(!c.alive) {
			// text = "RIP\nScore: " + c.aliveTime.ToString();
            reticle.text = ""; // hide reticle
            gameOverA.text = "RIP";
            gameOverB.text = "space: retry\nesc: menu";
			if(Input.GetKeyDown(KeyCode.Space)) {
				SceneManager.LoadScene (SceneManager.GetActiveScene ().name); // Restart level
			}
            if(Input.GetKeyDown(KeyCode.Escape)) {
                SceneManager.LoadScene ("menu");
            }
		}
	}

  //   void OnGUI()
  //   {
		// GUI.Label(rect, text, style);
  //   }
}