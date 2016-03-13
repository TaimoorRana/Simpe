using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {
	AudioSource audioSource;
	public float bulletSpeed;
	public GameObject bullet;
	public Transform bulletStartLocation;
	ScoreManager scoreManager;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
		bulletSpeed = 100f;
		bulletStartLocation = transform.FindChild ("BulletStartLocation");
		scoreManager = GameObject.Find ("ScoreManager").GetComponent<ScoreManager>();
	}
	
	// Update is called once per frame
	void Update () {
		Shoot ();
	}


	void Shoot(){
		if (Input.GetKeyDown (KeyCode.Return)) {
			GameObject bulletCopy = (GameObject)Instantiate (bullet,bulletStartLocation.position,Quaternion.identity);
			bulletCopy.GetComponent<Rigidbody> ().velocity = transform.forward * bulletSpeed;
			audioSource.Play ();
			Destroy (bulletCopy, 2f);
			//scoreManager.ChangeScore ("Team McGames", 1);
		}
	}
}
