using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerPlatforms : MonoBehaviour {

	public int maxPlatforms = 20;
	public GameObject platform;
	public float horizontalMin = 6.5f;
	public float horizontalMax = 14f;
	public float verticalMin = -2f;
	public float verticalMax = 6f;
	private Vector2 originPosition;

	// Use this for initialization
	void Start () {
		originPosition = transform.position;
		Spawn ();
	}
	
	void Spawn(){
		for (int i = 0; i < maxPlatforms; i++) {
			if (i < 4) {
				Vector2 randomPosition = originPosition + new Vector2(Random.Range(horizontalMin, horizontalMax), Random.Range(0, verticalMax));
				Instantiate (platform, randomPosition, Quaternion.identity);
				originPosition.x = randomPosition.x;
				originPosition.y = 0;
			} else {
				Vector2 randomPosition = originPosition + new Vector2(Random.Range(horizontalMin, horizontalMax), Random.Range(verticalMin, verticalMax));
				Instantiate (platform, randomPosition, Quaternion.identity);
				originPosition.x = randomPosition.x;
				originPosition.y = 0;
			}
		}
	}
}