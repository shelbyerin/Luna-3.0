using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour {

	public int maxObjects;
	public GameObject mushroom;
	public GameObject apple;
	public GameObject medicine;
	public GameObject pizza;
	//How far we can move the objects from one another.
	public float horizontalMin;
	public float horizontalMax;
	public float verticalMin;
	public float verticalMax;

	private Vector2 originPosition;

	// Use this for initialization
	void Start () {
		originPosition = transform.position;
		Spawn();
	}

	private void Spawn () {
		for (int i=0; i < maxObjects; i++) {
			float RandomObj = Random.Range(0, 9);
			if (RandomObj == 0 || RandomObj == 1) {
				Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin, verticalMax));
				Instantiate(mushroom, randomPosition, Quaternion.identity);
				originPosition = randomPosition;
			}
			else if (RandomObj == 2 || RandomObj == 3 || RandomObj == 4) {
				Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin, verticalMax));
				Instantiate(pizza, randomPosition, Quaternion.identity);
				originPosition = randomPosition;
			}
			else if (RandomObj == 5 || RandomObj == 6) {
				Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin, verticalMax));
				Instantiate(medicine, randomPosition, Quaternion.identity);
				originPosition = randomPosition;
			}
			else if (RandomObj == 7 || RandomObj == 8 || RandomObj == 9) {
				Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin, verticalMax));
				Instantiate(apple, randomPosition, Quaternion.identity);
				originPosition = randomPosition;
			}
		}
	}
}
