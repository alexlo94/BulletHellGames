using UnityEngine;
using System.Collections;

public class Lineshooter_behaviour : MonoBehaviour {
	public float speed = 0.1f;
	public float shoot_frequency = 0.6f;

	public GameObject bullet;
	public string orientation = "upper"; //use this to distinguish between horizontal and vertical lineshooters

	//define movement coroutine
	IEnumerator Move(string direction){
		if (direction == "upper" || direction == "lower") {
			if (transform.position.x <= -6.5f || transform.position.x >= 6.4f) {
				speed *= -1;
			}
			transform.Translate (new Vector3 (speed, 0, 0), Space.World);
			yield return null;
		} 
		else if(direction == "left" || direction == "right") {
			if (transform.position.y <= -2.8f || transform.position.y >= 2.8f) {
				speed *= -1;
			}
			transform.Translate (new Vector3 (0, speed, 0), Space.World);
			yield return null;
		}
	}

	//define circular movement coroutine
	IEnumerator Spiral(float radius, Vector3 center){
		float angle = 0;
		while (true) {
			angle++;
			transform.localPosition =  new Vector3(radius * Mathf.Sin (Mathf.Deg2Rad *(angle)), radius * Mathf.Cos (Mathf.Deg2Rad *(angle)), 0);
			transform.Rotate(new Vector3(0,0, -1));
			yield return null;
		}
	}

	IEnumerator Shoot(){
		while (true) {
			Instantiate (bullet, transform.position, transform.rotation);
			yield return new WaitForSeconds (shoot_frequency);
		}
	}

	void Start () {
		if (orientation == "upper") {
			transform.Rotate(0,0,0);
		}
		if (orientation == "left") {
			transform.Rotate(0,0,90);
		}
		if (orientation == "lower") {
			transform.Rotate(0,0,180);
		}
		if (orientation == "right") {
			transform.Rotate(0,0,270);

		}

		StartCoroutine (Shoot ());
		//StartCoroutine(Spiral(3.0f,new Vector3(0,0,0)));
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine (Move (orientation));
	}
}
