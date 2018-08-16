using UnityEngine;
using System.Collections;

public class ShooterBehavior : MonoBehaviour {
	public GameObject Bullet;
	public GameObject PowerUp;
	public string Pattern; //set this in the prefab
	public float ShootFreq; //used for shootline
	public int times; //used for shootCircle
	public int Rotator;

	//method to test the shooting coroutines
	void Start(){
		//Self = gameObject.transform;
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "PlayerBullet") {
			Destroy (other.gameObject);
			float random = Random.value;
			if (random >= 0.8f) {
				Instantiate (PowerUp, gameObject.transform.position, gameObject.transform.rotation);
			}
			Destroy (this.gameObject);
		}
	}


	IEnumerator ShootLine(){
		while (true) {
			Instantiate (Bullet, gameObject.transform.position, gameObject.transform.rotation);
			yield return new WaitForSeconds (ShootFreq);
		}
	}
	IEnumerator ShootCircle(){
		for (int i = 0; i <= times; i++) {
			int angle = 0;
			while (angle < 360) {
				transform.Rotate (0, 0, Rotator);
				Instantiate (Bullet, gameObject.transform.position, gameObject.transform.rotation);
				angle+=Rotator;
			}
			yield return new WaitForSeconds(ShootFreq);
		}
	}
}
