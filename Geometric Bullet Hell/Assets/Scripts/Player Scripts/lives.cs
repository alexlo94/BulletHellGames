using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class lives : MonoBehaviour {
	private GameObject player;
	private int curr_lives;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		curr_lives = player.GetComponent<player_controller> ().lives;
	
	}
	
	// Update is called once per frame
	void Update () {
		curr_lives = player.GetComponent<player_controller> ().lives;
		gameObject.GetComponent<Text> ().text = "Lives: " + curr_lives.ToString ();
	
	}
}
