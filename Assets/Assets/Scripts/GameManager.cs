﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;
	public GameObject spawnPoint;
	public GameObject[] checkpoints;
	public GameObject exitPoint;
	public GameObject[] enemies;
	public int maxEnemiesOnScreen;
	public int totalEnemies;
	public int enemiesPerSpawn;
	private int enemiesOnScreen = 0;
	
	void Awake () {
		if(instance == null) {
			instance = this;
		} else if (instance != null) {
			Destroy(gameObject);
		}

		DontDestroyOnLoad(gameObject);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	void spawnEnemy() {
		if(enemiesPerSpawn > 0 && enemiesOnScreen < totalEnemies) {
			for(int i = 0; i < enemiesOnScreen; i++) {
				GameObject newEnemy = Instantiate(enemies[0]);
				newEnemy.transform.position = spawnPoint.transform.position;
				enemiesOnScreen++;
			}
		}
	}
}
