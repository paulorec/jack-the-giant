using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour {

	public float distanceBetweenClouds;

	[SerializeField]
	private GameObject[] clouds;

	[SerializeField]
	private GameObject[] collectables;

	private float minX,maxX;

	private float lastCloudPosY;

	private float controlX;

	private GameObject player;

	void Awake() {
		SetMinMax ();
	}
	// Use this for initialization
	void Start () {
		
	}

	void SetMinMax() {

		Vector3 bounds = Camera.main.ScreenToWorldPoint (new Vector3 (Screen.width, Screen.height, 0));
		maxX = bounds.x - 0.5f;
		minX = -bounds.x + 0.5f;
			
	}

	void Shuffle(GameObject[] arrayToShuffle) {
		for (int i = 0; i < arrayToShuffle.Length; i++) {
			GameObject temp = arrayToShuffle [i];

			int random = Random.Range (i, arrayToShuffle.Length);
			arrayToShuffle [i] = arrayToShuffle [random];
			arrayToShuffle [random] = temp;
		}

	}

	void CreateClouds() {

	}
}
