using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {
	public float shoot_frequency = 0.4f;
	public bool rotating = false;
	public GameObject bullet;

	IEnumerator Shoot(){
		while (true) {
			if(rotating)
				Instantiate (bullet, transform.position, transform.rotation);
			yield return new WaitForSeconds (shoot_frequency);
		}
	}

	// Use this for initialization
	void Start () {
		StartCoroutine (Shoot ());
	
	}
	
	// Update is called once per frame
	void Update () {
	}
}
