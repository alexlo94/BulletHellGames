using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LivesManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.GetComponent<Text> ().text = "LIVES: " + (PlayerPrefs.GetInt("Lives")).ToString();
	}
}
