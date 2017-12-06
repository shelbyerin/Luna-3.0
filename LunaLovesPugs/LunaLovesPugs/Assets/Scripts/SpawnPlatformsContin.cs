using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstaclesLevel1 : MonoBehaviour {

	public int maxObjects = 15;

	//Bad game objects
	public GameObject bush;
	public GameObject wood_spikes;

	//generic game objects
	public GameObject stone;
	public GameObject tree;

	//How far we can move the objects from one another.
	private float horizontalMin = 20;
	private float horizontalMax = 30;
	private float verticalMin = -1;
	private float verticalMax = 1;

	private Vector2 originPosition;

	// Use this for initialization
	void Start () {
		originPosition = transform.position;
		Spawn();
	}

	private void Spawn () {
		for (int i=0; i < maxObjects; i++) {
			float RandomObj = Random.Range(0, 4);
			if (RandomObj == 0) {
				Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin, verticalMax));
				Instantiate(stone, randomPosition, Quaternion.identity);
				originPosition = randomPosition;
			}
			else if (RandomObj == 1) {
				Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin, verticalMax));
				Instantiate(wood_spikes, randomPosition, Quaternion.identity);
				originPosition = randomPosition;
			}
			else if (RandomObj == 2) {
				Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin, verticalMax));
				Instantiate(tree, randomPosition, Quaternion.identity);
				originPosition = randomPosition;
			}
			else if (RandomObj == 3) {
				Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin, verticalMax));
				Instantiate(bush, randomPosition, Quaternion.identity);
				originPosition = randomPosition;
			}
		}
	}
}
