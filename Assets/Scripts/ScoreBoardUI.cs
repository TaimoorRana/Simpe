using UnityEngine;
using System.Collections;

public class ScoreBoardUI : MonoBehaviour {
	public GameObject scorePanel;
	public PlayerScoreList scoreList;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Tab)) {
			scorePanel.SetActive (!scorePanel.activeSelf);
			scoreList.updateScore ();
		}
	}
}
