using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PugObjectCollision : MonoBehaviour {

	public static float maxSpeed;
	void Start () {
	}
	void Update () {		
	}
	void OnTriggerEnter2D(Collider2D other)
	{ 
		float currentSpeed = GameObject.Find ("Luna").GetComponent<LunaController> ().maxSpeed;
		if (other.gameObject.CompareTag ("PickUp")) {
			Destroy (other.gameObject);
			if (other.gameObject.name == "Mushroom(Clone)") {
				GameObject.Find ("Luna").GetComponent<LunaController> ().maxSpeed = (currentSpeed - 2);
			} else if (other.gameObject.name == "Pizza(Clone)") {
				GameObject.Find ("Luna").GetComponent<LunaController> ().maxSpeed = (currentSpeed - 1);
			} else if (other.gameObject.name == "Apple(Clone)") {
				if (currentSpeed == 5) {
					GameObject.Find ("Luna").GetComponent<LunaController> ().maxSpeed = (currentSpeed);
				} else {
					GameObject.Find ("Luna").GetComponent<LunaController> ().maxSpeed = (currentSpeed + 1);
				}
			} else if (other.gameObject.name == "Medicine(Clone)") {
				if (currentSpeed >= 3) {
					GameObject.Find ("Luna").GetComponent<LunaController> ().maxSpeed = 5f;
				} else {
					GameObject.Find ("Luna").GetComponent<LunaController> ().maxSpeed = (currentSpeed + 2);
				}
			}  else { }
		}
	}
}