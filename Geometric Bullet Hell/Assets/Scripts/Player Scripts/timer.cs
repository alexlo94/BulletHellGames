using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class timer : MonoBehaviour {
	public float timeAlive = 0f;
	public string scoreNumber = "";

	void Update () {
		timeAlive += Time.deltaTime;
		scoreNumber = Mathf.Round(timeAlive).ToString();
		GetComponent<Text> ().text = "Time: " + scoreNumber;
	}
}
