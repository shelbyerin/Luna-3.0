using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class BadGuyController : MonoBehaviour {

	[HideInInspector] public bool facingRight = true;
	public float maxSpeed = 0f;

	void Awake ()
	{	}

	void FixedUpdate()	{

		Vector2 pos = transform.position;
		int lunaPos = GameObject.Find ("Luna").GetComponent<LunaController> ().xPOS;
		if ((int)pos.x == lunaPos || (int)pos.x > lunaPos) {
			maxSpeed = 0f;
		} else {
			maxSpeed = 4f;
		}
		pos.x += maxSpeed * Time.deltaTime;
		transform.position = pos;
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Luna")) {
			Debug.Log ("collided with Luna"); //correctly displaying
			GameObject.Find("Timer").SendMessage("Finish");
            //Loads Scene Game Over
            LoadScene("GameOver");
        }
		if (other.gameObject.CompareTag ("PickUp")) {
			Destroy (other.gameObject);
		}
	}

    //Method Loads a scene by a given name encasped in quotes
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
