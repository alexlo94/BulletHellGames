using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Start_Game : MonoBehaviour {

	void Start(){
		Button btn = gameObject.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	}

	void TaskOnClick(){
		SceneManager.LoadScene ("Tutorial");
	}
}
