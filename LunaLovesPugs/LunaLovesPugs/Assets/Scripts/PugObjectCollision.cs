using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PugObjectCollision : MonoBehaviour {

	public static float maxSpeed;
	Animator anim;

	void OnTriggerEnter2D(Collider2D other)
	{
		float currentSpeed = GameObject.Find ("Luna").GetComponent<LunaController> ().maxSpeed;
		if (other.gameObject.CompareTag ("GoodPickUp")) {
			Destroy (other.gameObject);
			if (currentSpeed == maxSpeed) {
				GameObject.Find ("Luna").GetComponent<LunaController> ().maxSpeed = (currentSpeed);
			}
			else {
				GameObject.Find ("Luna").GetComponent<LunaController> ().maxSpeed = (currentSpeed + 1);
			}
		}
		else if (other.gameObject.CompareTag ("BadPickUp")) {
			Destroy (other.gameObject);
			GameObject.Find ("Luna").GetComponent<LunaController> ().maxSpeed = (currentSpeed - 1);
			if (currentSpeed == 0) {
				GameObject.Find ("Luna").GetComponent<LunaController> ().maxSpeed = (currentSpeed);
			}
		}
		else if (other.gameObject.CompareTag ("BadObstacle")) {
			GameObject.Find("Timer").SendMessage("Finish");
			//Loads Scene Game Over
			LoadScene("GameOver");
		}
	}
	public void LoadScene(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}
}
