using UnityEngine;
using System.Collections;

public class pickup : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		GameObject scoreCount = GameObject.Find("Score");
		GameObject self = this.gameObject;

		if (other.tag == "Player" || other.tag == "Deflect"){
			scoreCount.GetComponent<Score> ().powerups += 1;
			Destroy (self);
		}
	}
}
