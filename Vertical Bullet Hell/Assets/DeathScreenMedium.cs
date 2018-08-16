using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class DeathScreenMedium : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.gameObject.GetComponent<Text> ().text = "NORMAL SCORE: " + (Mathf.Floor(PlayerPrefs.GetFloat("MediumLevelScore"))).ToString();

	}
}
