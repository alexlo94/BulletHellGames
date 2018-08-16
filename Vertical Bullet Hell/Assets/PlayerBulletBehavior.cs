using UnityEngine;
using System.Collections;

public class PlayerBulletBehavior : MonoBehaviour {
	public float speed = 1.0f;
	// Use this for initialization
	void Start () {
		StartCoroutine (BulletDeath ());
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.up * speed * Time.deltaTime;
	}

	IEnumerator BulletDeath(){
		int counter = 0;
		while (true) {
			counter++;
			if (counter >= 10) {
				Destroy (this.gameObject);
			}
			yield return null;
		}
	}
}
