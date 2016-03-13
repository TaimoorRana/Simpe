using UnityEngine;
using System.Collections.Generic;

public class ScoreManager : MonoBehaviour {
	Dictionary<string,int> scores;
	// Use this for initialization
	void Start () {
		
	}

	public void Init(){
		if (scores != null)
			return;
		
		scores = new Dictionary<string, int> ();
	}

	public int GetScore(string username){
		Init ();
		if (!scores.ContainsKey (username)) {
			return 0;
		}
		return scores [username];
	}

	public void SetScore(string username, int score){
		Init ();
		scores.Add (username, score);
	}

	public void ChangeScore(string username, int score){
		Init ();
		if (scores.ContainsKey (username)) {
			scores [username] = score;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
