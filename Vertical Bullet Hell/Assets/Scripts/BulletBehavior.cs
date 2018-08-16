using UnityEngine;
using System.Collections;

public class BulletBehavior : MonoBehaviour {
	public float speed;

	void Update(){
		transform.position += transform.up * speed * Time.deltaTime;
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "BulletBarrier") {
			Destroy (this.gameObject);
		}
	}
}
