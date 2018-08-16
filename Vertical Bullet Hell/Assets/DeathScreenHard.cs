using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class DeathScreenHard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.gameObject.GetComponent<Text> ().text = "HARD SCORE: " + (Mathf.Floor(PlayerPrefs.GetFloat("HardLevelScore"))).ToString();

	}
}
