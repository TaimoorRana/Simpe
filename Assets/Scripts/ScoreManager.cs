using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class ScoreManager : MonoBehaviour {
	Dictionary<string,int> scores;
	// Use this for initialization
	void Start () {
		Init ();
	}


	public void Init(){
		if (scores != null)
			return;
		
		scores = new Dictionary<string, int> ();
		scores.Add ("Team McGames", 0);
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
			int previousScore = scores [username];
			scores [username] = previousScore + score;
		}
	}

	public string[] getPlayersNames(){
		
		return scores.Keys.ToArray();
	}

	public int[] getPlayersScores(){
		return scores.Values.ToArray ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
