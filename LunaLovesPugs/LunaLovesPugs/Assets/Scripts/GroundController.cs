using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour {

	private Vector2 originPositionGround;
	private Vector2 originPositionSky;
	private bool groundEnd;
	public GameObject ground;
	public GameObject sky;

	// Use this for initialization
	void Start () {
		originPositionGround = transform.position;
		originPositionSky = transform.position;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		groundEnd = true;
		Spawn();
	}

	// Update is called once per frame
	void Spawn() {
		Vector2 groundPosition = originPositionGround + new Vector2 (198.15f, 0);
		Instantiate(ground, groundPosition, Quaternion.identity);
		originPositionGround = groundPosition;
	}
}
