using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {
	static public int score = 10;

	void Awake(){
		if (PlayerPrefs.HasKey ("LunaLovesPugsHighScore")) {
			score = PlayerPrefs.GetInt ("LunaLovesPugsHighScore");
		}
		PlayerPrefs.SetInt ("LunaLovesPugsHighScore", score);
	}
	void Start () {

	}
	void Update () {
		Text gt = this.GetComponent<Text> ();
		gt.text = "High Score: " + score;

		if (score > PlayerPrefs.GetInt ("LunaLovesPugsHighScore")) {
			PlayerPrefs.SetInt ("LunaLovesPugsHighScore", score);
		}
	}
}
