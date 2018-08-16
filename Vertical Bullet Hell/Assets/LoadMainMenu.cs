using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadMainMenu : MonoBehaviour {

	void Start(){
		Button btn = gameObject.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	}

	void TaskOnClick(){
		SceneManager.LoadScene ("MenuScreen");
	}
}
