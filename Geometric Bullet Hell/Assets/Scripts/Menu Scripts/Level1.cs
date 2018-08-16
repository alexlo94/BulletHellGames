using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Level1 : MonoBehaviour {

	void Start(){
		Button btn = gameObject.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	}

	void TaskOnClick(){
		Debug.Log ("button clicked");
		SceneManager.LoadScene ("Opening Screen");
	}
}
