using UnityEngine;
using System.Collections.Generic;

public class EnemyGenerator : MonoBehaviour {
	public GameObject enemy;
	Transform[] spawnLocations;
	int currentLocation = 0;
	public int enemyAmount = 1;
	public int currentEnemy = 0;
	// Use this for initialization
	void Start () {
		spawnLocations = GetComponentsInChildren<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (currentEnemy < enemyAmount) {
			if (currentLocation >= spawnLocations.Length)
				currentLocation = 0;
			
			Instantiate (enemy,spawnLocations[currentLocation].transform.position,Quaternion.identity);
			currentLocation++;
			currentEnemy++;
		}
	}

	public void enemyDead(){
		currentEnemy--;
	}
}
