﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScaler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SpriteRenderer sr = GetComponent<SpriteRenderer> ();

		Vector3 tScale = transform.localScale;

		float width = sr.sprite.bounds.size.x;
		float worldHeight = Camera.main.orthographicSize * 2f;
		float worldWidth = worldHeight / Screen.height * Screen.width;

		tScale.x = worldWidth / width;

		transform.localScale = tScale;
			
	}

}
