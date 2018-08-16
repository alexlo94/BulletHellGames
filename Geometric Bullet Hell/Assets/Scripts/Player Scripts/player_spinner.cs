using UnityEngine;
using System.Collections;

public class player_spinner : MonoBehaviour {
	public float rotate_speed = 1;


	// Update is called once per frame
	void Update () {
		transform.Rotate(0,0,rotate_speed);
	}
}
