using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Countdown : MonoBehaviour {
	public float timePassed = 0f;
	public float level_time = 60f; //change this later

	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text> ().text = "Time: " + Mathf.Round(level_time).ToString();
		level_time -= Time.deltaTime;
		timePassed += Time.deltaTime;
	}
}
