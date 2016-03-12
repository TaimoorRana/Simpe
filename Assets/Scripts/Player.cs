using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	float horizontalMovement = 0f;
	float verticalMovement = 0f;
	const float minimumHeightForJump = 1.2f;
	Rigidbody rb;

	public float moveSpeed;
	public float rotationSpeed;

	// Use this for initialization
	void Start () {
		horizontalMovement = 0f;
		verticalMovement = 0f;
		moveSpeed = 7.5f;
		rotationSpeed = 15f;
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
		Jump ();
		Rotate ();

	}

	void Move(){
		
		verticalMovement = Input.GetAxis ("Vertical");
		if (verticalMovement != 0) {
			gameObject.transform.Translate (verticalMovement * moveSpeed * Time.deltaTime, 0, 0);
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
}
