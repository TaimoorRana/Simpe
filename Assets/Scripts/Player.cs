using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	float horizontalMovement = 0f;
	float verticalMovement = 0f;
	const float minimumHeightForJump = 1.2f;
	Rigidbody rb;

	public float moveSpeed;
	public float rotationSpeed;
	public float bulletSpeed;
	public GameObject bullet;
	public Transform bulletStartLocation;

	// Use this for initialization
	void Start () {
		horizontalMovement = 0f;
		verticalMovement = 0f;
		moveSpeed = 7.5f;
		rotationSpeed = 100f;
		bulletSpeed = 10f;
		rb = GetComponent<Rigidbody> ();
		bulletStartLocation = transform.FindChild ("BulletStartLocation");
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
		Jump ();
		Rotate ();
		Shoot (); 

	}

	void Move(){
		
		verticalMovement = Input.GetAxis ("Vertical");
		if (verticalMovement != 0) {
			gameObject.transform.Translate (0, 0, verticalMovement * moveSpeed * Time.deltaTime);
		}
	}

	void Rotate(){
		horizontalMovement = Input.GetAxis ("Horizontal");
		if ( horizontalMovement != 0) {
			gameObject.transform.Rotate (0, horizontalMovement * rotationSpeed * Time.deltaTime, 0);
		}
	}

	void Jump(){
		if (Input.GetKeyDown (KeyCode.Space) && transform.position.y <= minimumHeightForJump) {
			rb.velocity = new Vector3 (0, 10f, 0);

		}
	}

	void Shoot(){
		if (Input.GetKeyDown (KeyCode.Return)) {
			GameObject bulletCopy = (GameObject)Instantiate (bullet,bulletStartLocation.position,Quaternion.identity);
			bulletCopy.GetComponent<Rigidbody> ().velocity = transform.forward * bulletSpeed;
			Destroy (bulletCopy, 2f);
		}
	}

}
