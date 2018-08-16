using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Start_Game_Hard : MonoBehaviour {

	void Start(){
		Button btn = gameObject.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	}

	void TaskOnClick(){
		PlayerPrefs.SetInt ("Lives", 3);
		PlayerPrefs.SetFloat ("EasyLevelScore", 0f);
		PlayerPrefs.SetFloat ("MediumLevelScore", 0f);
		PlayerPrefs.SetFloat ("HardLevelScore", 0f);
		SceneManager.LoadScene ("HardLevel");
	}
}
