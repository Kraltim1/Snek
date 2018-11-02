using UnityEngine;
using System.Collections;

public class FPSDisplay : MonoBehaviour
{
	float deltaTime = 0.0f;
	int w, h;
	Rect rect;
	GUIStyle style;
	float msec;
	float fps;

	string text;

	void Start() {
		w = Screen.width;
		h = Screen.height;
		rect = new Rect(0, 0, 100, 12);
		style = new GUIStyle();
		style.alignment = TextAnchor.UpperLeft;
		style.fontSize = 10;
		style.normal.textColor = new Color(1, 1, 1, 1.0f);

		//create a transparent black box behind the text
		//for easier readability
		Texture2D blah = new Texture2D (1, 1);
		Color backColor = new Color (0, 0, 0, 0.5f);
		blah.SetPixel (0, 0, backColor);
		blah.Apply ();
		style.normal.background = blah;

		//recreate our text string 5x a second
		//both for optimization and easier to read
		InvokeRepeating ("UpdateFPS", 1, 0.33f);
	}

    void Update()
    {
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
        msec = deltaTime * 1000.0f;
        fps = 1.0f / deltaTime;
    }

    //update the string holding the text
    void UpdateFPS() {

		text = string.Format("Fps: {0:0.0} ({1:0.00} ms)", fps, msec);

	}

	//apply the text on screen
    void OnGUI()
    {
		GUI.Label(rect, text, style);
    }
}