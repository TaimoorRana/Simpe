using UnityEngine;
using System.Collections;

public class PlayerScoreList : MonoBehaviour {
	public GameObject PlayerScoreUI;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < 6; i++) {
			GameObject score = Instantiate (PlayerScoreUI);
			score.transform.SetParent (transform);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
