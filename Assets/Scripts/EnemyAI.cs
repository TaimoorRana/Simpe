using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
	GameObject player;
	public float speed = 0.5f  ;
	EnemyGenerator enemyGenerator;
	ScoreManager scoreManager;
	// Use this for initialidzation
	void Start () {
		player = GameObject.Find ("Player");
		enemyGenerator = GameObject.Find("EnemyGenerator").GetComponent<EnemyGenerator>();
		scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
	}
	
	// Update is called once per frame
	void Update () {
		if (player == null) // in case the player dies
			return;
		Vector3 direction = new Vector3 (transform.position.x - player.transform.position.x, transform.position.y - player.transform.position.y, transform.position.z - player.transform.position.z);
		transform.Translate (-direction * Time.deltaTime * speed); 
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Bullet") {
			Destroy (gameObject);
			enemyGenerator.enemyDead ();
			scoreManager.ChangeScore ("Team McGames", 1);
		}else if(other.gameObject.tag == "Player"){
			other.gameObject.GetComponent<Player> ().Dead ();
		}
	} 
}
