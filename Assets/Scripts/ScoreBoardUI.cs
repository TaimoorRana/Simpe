using UnityEngine;
using System.Collections;

public class ScoreBoardUI : MonoBehaviour {
	public GameObject scorePanel;
	PlayerScoreList scoreList;
	// Use this for initialization
	void Start () {
		scoreList = GameObject.Find("Player Score List").GetComponent<PlayerScoreList> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Tab)) {
			scorePanel.SetActive (!scorePanel.activeSelf);
			scoreList.updateScore ();
		}
	}
}
