﻿using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	
	public Player1 player1;
	public Player2 player2;
	
	public Enemy1 enemy1;
	public Enemy2 enemy2;
	
	public Transform[] spawnPoints;

	private int randomPlace;

	public float left;
	public float right;
	
	// Use this for initialization
	void Start () {
		
		InvokeRepeating ("spawnEnemy", 1.0f, 5.0f);

		// move players to random position
		player1.transform.position = new Vector3 (Random.Range (-7, 7), 1.39f, Random.Range (-7, 7));
		player2.transform.position = new Vector3 (Random.Range (-7, 7), 1.39f, Random.Range (-7, 7));
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.LoadLevel(0);
		}
		
	}

//	void spawnPlayers() {
//		Player1 newPlayer = (Player1)Instantiate (player1, spawnPoints [Random.Range (0, spawnPoints.Length)].position, Quaternion.identity);
//		Player2 newPlayer2 = (Player2)Instantiate (player1, spawnPoints [Random.Range (0, spawnPoints.Length)].position, Quaternion.identity);
//
//	}
	
	void spawnEnemy() {

		Enemy1 newEnemy = (Enemy1)Instantiate (enemy1, spawnPoints [Random.Range (0, spawnPoints.Length)].position, Quaternion.identity);
		Enemy2 newEnemy2 = (Enemy2)Instantiate (enemy2, spawnPoints [Random.Range (0, spawnPoints.Length)].position, Quaternion.identity);

		newEnemy.transform.position = new Vector3 (Random.Range (-7, 7), 1.39f, Random.Range (-7, 7));
		newEnemy2.transform.position = new Vector3 (Random.Range (-7, 7), 1.39f, Random.Range (-7, 7));

		newEnemy.gameObject.SetActive (true);
		newEnemy2.gameObject.SetActive (true);

	}
	
}