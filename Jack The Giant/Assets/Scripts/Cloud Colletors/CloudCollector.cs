using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudCollector : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D target) {

		if (target.tag == "Cloud" || target.tag == "Deadly") {
			
			target.gameObject.SetActive (false);
		}
	}
}
