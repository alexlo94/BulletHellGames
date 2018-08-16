using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class DeathScreenEasy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.gameObject.GetComponent<Text> ().text = "EASY SCORE: " + (Mathf.Floor(PlayerPrefs.GetFloat("EasyLevelScore"))).ToString();
	
	}
}
