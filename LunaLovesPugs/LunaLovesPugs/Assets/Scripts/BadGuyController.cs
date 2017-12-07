using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class BadGuyController : MonoBehaviour {

	[HideInInspector] public bool facingRight = true;
	public float maxSpeed;
	public float jumpForce = 800f;
	private Rigidbody2D rb2d;
	private float currentSpeed;


	void Awake ()
	{
		currentSpeed = maxSpeed;
		rb2d = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate()	{

		Vector2 pos = transform.position;

		int lunaPos = GameObject.Find ("Luna").GetComponent<LunaController> ().xPOS;
		if ((int)pos.x == lunaPos || (int)pos.x > lunaPos) {
			rb2d.AddForce(new Vector2(0f, jumpForce));
			rb2d.gravityScale = 2.5f;
			currentSpeed = 0f;
		} else {
			currentSpeed = maxSpeed;
			if (pos.x < (lunaPos - 25)) {
				currentSpeed = maxSpeed + 4;
			} else if (pos.x >= (lunaPos - 10)) {
				currentSpeed = maxSpeed;
			}
		}

	//	int lunaPosY = GameObject.Find ("Luna").GetComponent<LunaController> ().yPOS;
	//	pos.y = lunaPosY+1;

		pos.x += currentSpeed * Time.deltaTime;
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
		if (other.gameObject.CompareTag ("GoodPickUp") || other.gameObject.CompareTag ("BadPickUp") || other.gameObject.CompareTag ("Obstacle") || other.gameObject.CompareTag ("BadObstacle")) {
			Destroy (other.gameObject);
		}
	}

    //Method Loads a scene by a given name encasped in quotes
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
