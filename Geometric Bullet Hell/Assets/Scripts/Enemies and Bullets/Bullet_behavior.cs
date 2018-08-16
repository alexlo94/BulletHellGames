using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Bullet_behavior : MonoBehaviour {
	public float speed = -2.5f;
	private bool deflected = false;
	private GameObject self;
	private GameObject player;

	void Start(){
		self = this.gameObject;
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void Update () {
		transform.position += transform.up * speed * Time.deltaTime;
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			int curr_lives = player.GetComponent<player_controller> ().lives;
			if (curr_lives <= 0) {
				Destroy (player);
				DontDestroyOnLoad (GameObject.Find ("scoreholder"));
				SceneManager.LoadScene ("Death Screen");
			} else {
				player.GetComponent<player_controller> ().lives--;
				player.transform.position = new Vector3 (0, 0, 0);
				wipeBullets ();
			}
		}
		if(other.tag == "Barrier"){
			Destroy(self);
		}
		if (other.tag == "Deflect" && deflected == false) {
			deflected = true;
			transform.up *= -1f;


		}
	}

	void wipeBullets(){
		GameObject[] bullets = GameObject.FindGameObjectsWithTag ("Bullet");
		for (int i = 0; i < bullets.Length; i++){
			if (bullets [i].transform.position.x > -14f) {
				Destroy (bullets [i]);
			}
		}
	}
}
