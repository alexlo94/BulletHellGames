using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class finalscore : MonoBehaviour {
	public float scoredisplay;
	public GameObject finalscoreholder;

	// Use this for initialization
	void Start () {
		//SceneManager.MergeScenes(SceneManager.GetSceneByName("DontDestroyOnLoad"), SceneManager.GetSceneByName("Death Screen"));
		finalscoreholder = GameObject.Find ("scoreholder");
		scoredisplay = finalscoreholder.GetComponent<scoreHolder> ().score;
		gameObject.GetComponent<Text> ().text = "Your Score Was: " + scoredisplay.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	}
}
