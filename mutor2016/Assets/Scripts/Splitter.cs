﻿using UnityEngine;
using System.Collections;

public class Splitter : MonoBehaviour {

	public GameObject gameManager;

	// Use this for initialization
	void Start () {
		gameManager = GameObject.FindGameObjectWithTag("GameManager");
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.gameObject.tag == "Player") {
			GameManager manager = gameManager.GetComponent<GameManager>();
			manager.SplitterCounter = 1;
			Destroy(gameObject);
		}
	}
}