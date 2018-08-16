using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Game_progression : MonoBehaviour {
	//private float time; //get time from timer gameobject
	private float bullet_speed; //use this to increase the speed of the bullets
	private float shooter_speed; //use this to adjust enemy speed
	private float shooter_frequency; //use this to adjust shooter frequency
	private float timeSpawned = -1f;

	private GameObject time;
	private Camera view;
	private GameObject lineshooter;
	private GameObject lineshooter_left;
	private GameObject lineshooter_lower;
	private GameObject lineshooter_right;
	private GameObject powerup;
	private GameObject[] bullets; //use this to adjust bullet characteristics
	private GameObject[] spawns; //use this to spawn powerups

	void Start(){
		spawns = GameObject.FindGameObjectsWithTag ("Spawn");
		powerup = GameObject.Find ("PowerUp");
	}

	// Update is called once per frame
	void Update () {
		//collect neccessary game objects
		time = GameObject.Find ("Timer");
		lineshooter = GameObject.Find ("LineShooter");
		float timer = float.Parse (time.GetComponent<timer>().scoreNumber);


		//trigger events based on the timer value
		if (timer == 20 && lineshooter_left == null) {
			lineshooter_left = (GameObject)Instantiate(lineshooter, new Vector3(-6.65f, 2.4f, 0f), Quaternion.identity);
			lineshooter_left.GetComponent<Lineshooter_behaviour> ().orientation = "left";
		}
		if (timer == 40 && lineshooter_lower == null) {
			lineshooter_lower = (GameObject)Instantiate (lineshooter, new Vector3 (-6.25f, -2.83f, 0f), Quaternion.identity);
			lineshooter_lower.GetComponent<Lineshooter_behaviour> ().orientation = "lower";
		}
		if (timer == 60 && lineshooter_right == null) {
			lineshooter_right = (GameObject)Instantiate (lineshooter, new Vector3 (6.65f, -2.4f, 0f), Quaternion.identity);
			lineshooter_right.GetComponent<Lineshooter_behaviour> ().orientation = "right";
		}

		if (timer % 10f == 0 && timer != timeSpawned) {
			int randomInt = Random.Range (0, 3);
			GameObject pup = Instantiate (powerup);
			pup.transform.localPosition = spawns [randomInt].transform.localPosition;
			timeSpawned = timer;
		}
	}
}
