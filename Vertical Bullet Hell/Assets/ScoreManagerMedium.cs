using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class ScoreManagerMedium : MonoBehaviour {
	public float Score;
	// Use this for initialization
	void Start () {
		Score = 0;

	}

	// Update is called once per frame
	void Update () {
		Score += Time.deltaTime * 10;
		PlayerPrefs.SetFloat ("MediumLevelScore", Score);
		this.gameObject.GetComponent<Text> ().text = "SCORE: " + (Mathf.Floor(PlayerPrefs.GetFloat("MediumLevelScore"))).ToString();

	}
}
