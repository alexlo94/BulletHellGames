using UnityEngine;
using System.Collections;

public class ShieldCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Bullet" || other.tag == "Enemy") {
			Destroy (other.gameObject);
			this.gameObject.SetActive (false);
		}
	}
}
