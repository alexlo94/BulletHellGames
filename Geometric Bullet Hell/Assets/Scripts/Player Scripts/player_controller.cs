using UnityEngine;
using System.Collections;

public class player_controller : MonoBehaviour {
	private float hMove;
	private float vMove;
	public float speed = 2;
	public int lives = 3;
	private bool spun = false;

	private GameObject player;
	private Rigidbody2D rbPlayer;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		rbPlayer = player.GetComponent<Rigidbody2D> ();
		rbPlayer.freezeRotation = true;
	}
	
	// Update is called once per frame
	void Update () {
		hMove = Input.GetAxis ("Horizontal");
		vMove = Input.GetAxis ("Vertical");

		rbPlayer.velocity = new Vector2 (speed * hMove, speed * vMove);

		if (Input.GetKeyDown ("space") && spun == false) {
			StartCoroutine (spinDeflect ());
		}

		Debug.Log (spun);
	}

	IEnumerator spinDeflect(){
		spun = true;
		float curr_time = 0f;
		float target_time = 1f;
		gameObject.GetComponent<player_spinner> ().rotate_speed = 60;
		gameObject.GetComponent<CircleCollider2D> ().radius *= 3f;
		gameObject.tag = "Deflect";
		while (curr_time <= target_time) {
			curr_time += Time.deltaTime;
			yield return null;
		}
		gameObject.tag = "Player";
		gameObject.GetComponent<player_spinner> ().rotate_speed = 1;
		gameObject.GetComponent<CircleCollider2D> ().radius /= 3f;
		gameObject.GetComponent<SpriteRenderer> ().color = new Color(1f,0f,0f);
		StartCoroutine (spinDeflectCD ());
	}

	IEnumerator spinDeflectCD(){
		float curr_time = 0f;
		float target_time = 3f;

		while (curr_time <= target_time) {
			curr_time += Time.deltaTime;
			yield return null;
		}
		gameObject.GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f);
		spun = false;
	}
}
