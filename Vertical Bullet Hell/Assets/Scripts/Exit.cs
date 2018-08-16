using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Exit : MonoBehaviour {

	void Start(){
		Button btn = gameObject.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	}

	void TaskOnClick(){
		Application.Quit ();
	}
}
