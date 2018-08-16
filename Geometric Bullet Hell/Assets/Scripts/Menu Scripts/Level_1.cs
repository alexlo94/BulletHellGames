using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Level_1 : MonoBehaviour {
	void Update(){
		if (Input.GetKeyDown ("space")) {
			SceneManager.LoadScene ("Level01");
		}
	}
}
