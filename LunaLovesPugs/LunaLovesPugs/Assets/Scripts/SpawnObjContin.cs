using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjContin : MonoBehaviour {

	public int maxObjects;

	//Bad game objects
	public GameObject pizza;
	public GameObject chocolate;
	public GameObject mushroom;
	public GameObject corn;
	public GameObject cherries;

	//Good game objects
	public GameObject fish;
	public GameObject meat;
	public GameObject apple;
	public GameObject medicine;
	public GameObject pumpkin;

	//How far we can move the objects from one another.
	public float horizontalMin;
	public float horizontalMax;
	public float verticalMin;
	public float verticalMax;

	private Vector2 originPosition;
	public GameObject Luna;
	float posMin = 250.0f;
	float posMax = 300.0f;

	// Use this for initialization
	void Start () {
		originPosition = transform.position;
		Spawn();
	}

	void Update()
	{
		if(Luna.transform.position.x >= posMin && Luna.transform.position.x <= posMax) {
			//maxPlatforms += 50;
			posMin += 250.0f;
			posMax += 250.0f;
			Spawn();
		}
	}

	private void Spawn () {
		for (int i=0; i < maxObjects; i++) {
			float RandomObj = Random.Range(0, 9);
			if (RandomObj == 0) {
				Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin, verticalMax));
				Instantiate(pizza, randomPosition, Quaternion.identity);
				originPosition = randomPosition;
			}
			else if (RandomObj == 1) {
				Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin, verticalMax));
				Instantiate(chocolate, randomPosition, Quaternion.identity);
				originPosition = randomPosition;
			}
			else if (RandomObj == 2) {
				Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin, verticalMax));
				Instantiate(mushroom, randomPosition, Quaternion.identity);
				originPosition = randomPosition;
			}
			else if (RandomObj == 3) {
				Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin, verticalMax));
				Instantiate(corn, randomPosition, Quaternion.identity);
				originPosition = randomPosition;
			}
			else if (RandomObj == 4) {
				Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin, verticalMax));
				Instantiate(cherries, randomPosition, Quaternion.identity);
				originPosition = randomPosition;
			}
			else if (RandomObj == 5) {
				Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin, verticalMax));
				Instantiate(fish, randomPosition, Quaternion.identity);
				originPosition = randomPosition;
			}
			else if (RandomObj == 6) {
				Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin, verticalMax));
				Instantiate(meat, randomPosition, Quaternion.identity);
				originPosition = randomPosition;
			}
			else if (RandomObj == 7) {
				Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin, verticalMax));
				Instantiate(apple, randomPosition, Quaternion.identity);
				originPosition = randomPosition;
			}
			else if (RandomObj == 8) {
				Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin, verticalMax));
				Instantiate(medicine, randomPosition, Quaternion.identity);
				originPosition = randomPosition;
			}
			else if (RandomObj == 9) {
				Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin, verticalMax));
				Instantiate(pumpkin, randomPosition, Quaternion.identity);
				originPosition = randomPosition;
			}
		}
	}
}
