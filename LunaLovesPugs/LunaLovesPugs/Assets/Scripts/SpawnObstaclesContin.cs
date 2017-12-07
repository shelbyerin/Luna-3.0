using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstaclesContin : MonoBehaviour {

	public int maxObjects;

		//Bad game objects
	public GameObject bush;
	public GameObject wood_spikes;

		//Generic game objects
	public GameObject tree;
	public GameObject stone;

		//How far we can move the objects from one another.
	private float horizontalMin = 20;
	private float horizontalMax = 30;
	private float verticalMin = -1;
	private float verticalMax = 1;

	private Vector2 originPosition;
	public GameObject Luna;
	private float posMin = 100.0f;
	private float posMax = 110.0f;

		// Use this for initialization
		void Start () {
			originPosition = transform.position;
			Spawn();
		}

		void Update()
		{
			if(Luna.transform.position.x >= posMin && Luna.transform.position.x <= posMax) {
				posMin += 100.0f;
				posMax += 100.0f;
				Spawn();
			}
		}

		private void Spawn () {
			for (int i=0; i < maxObjects; i++) {
				float RandomObj = Random.Range(0, 4);
				if (RandomObj == 0) {
					Vector2 randomPosition = originPosition + new Vector2 (Random.Range(horizontalMin,horizontalMax), Random.Range(verticalMin, verticalMax));
				Instantiate(bush, randomPosition, Quaternion.identity);
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
				Instantiate(stone, randomPosition, Quaternion.identity);
					originPosition = randomPosition;
				}
			}
		}
	}
