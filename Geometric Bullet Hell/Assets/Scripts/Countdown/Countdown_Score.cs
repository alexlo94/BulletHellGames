using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Countdown_Score : MonoBehaviour {
	public float score = 0f;
	public float scoreStep = 10f;
	public float powerups = 0f;
	public float bonus = 250f;
	public GameObject timer;
	public float time;

	// Use this for initialization
	void Start () {
		timer = GameObject.Find ("Timer");	
	}
	
	// Update is called once per frame
	void Update () {
		time = Mathf.Round(timer.GetComponent<Countdown> ().timePassed);
		score = time * scoreStep + powerups * bonus;
		GetComponent<Text> ().text = "Score: " + score;
	}
}
