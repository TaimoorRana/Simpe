using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class PlayerScoreList : MonoBehaviour {
	public  GameObject PlayerScoreUI;
	ScoreManager scoreManager;
	// Use this for initialization
	void Start () {
		scoreManager = GameObject.FindObjectOfType<ScoreManager> ();
		updateScore ();

	}

	public void updateScore(){
		// delete all the list
		for ( int i=transform.childCount-1; i>=0; --i )
		{
			var child = transform.GetChild(i).gameObject;
			Destroy( child );
		}
		string[] names = scoreManager.getPlayersNames ();
		int[] scores = scoreManager.getPlayersScores ();

		// add new scores
		for (int x = 0; x < names.Length; x++) {
			GameObject score = Instantiate (PlayerScoreUI);
			score.transform.FindChild ("Name").GetComponent<Text> ().text = names [x];
			score.transform.FindChild ("Score").GetComponent<Text> ().text = scores [x].ToString();
			score.transform.parent = this.transform;
		}
	}


	
	// Update is called once per frame
	void Update () {
	}
}
