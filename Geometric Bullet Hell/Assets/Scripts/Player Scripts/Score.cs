using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {
	public float score = 0f;
	public float scoreStep = 10f;
	public float powerups = 0f;
	public float bonus = 250f;
	public GameObject timer;
	public GameObject scoreholder;
	public float time;

	// Use this for initialization
	void Start () {
		time = timer.GetComponent<timer> ().timeAlive;
		scoreholder = GameObject.Find ("scoreholder");
	}
	
	// Update is called once per frame
	void Update () {
		time = Mathf.Round(timer.GetComponent<timer> ().timeAlive);
		score = time*scoreStep + bonus*powerups;

		GetComponent<Text> ().text = "Score: " + score;
		scoreholder.GetComponent<scoreHolder> ().score = score;
	}
}
