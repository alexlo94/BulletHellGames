using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour {
	public float speed;
	private Rigidbody2D playerRB;
	public GameObject Shield;
	public bool ShieldActive = false;
	public GameObject PlayerBullet;

	void Start(){
		playerRB = gameObject.GetComponent<Rigidbody2D> ();
		playerRB.freezeRotation = true;
	}

	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		playerRB.velocity = new Vector2 (moveHorizontal*speed, moveVertical*speed);
	}
	void Update(){
		if(Input.GetButton("Fire1")){
			Instantiate(PlayerBullet, transform.position, PlayerBullet.transform.rotation);
		}
	}
	void OnTriggerEnter2D(Collider2D other){
		if ((other.tag == "Bullet" || other.tag == "Enemy") && ShieldActive == false) {
			if (PlayerPrefs.GetInt ("Lives") > 0) {
				PlayerPrefs.SetInt ("Lives", PlayerPrefs.GetInt ("Lives") - 1);
				this.gameObject.transform.position = new Vector3 (0, -4.5f, -1f);
			} else {
				SceneManager.LoadScene ("DeathScreen");
			}
		}
		if ((other.tag == "Bullet" || other.tag == "Enemy") && ShieldActive == true) {
			Destroy (other.gameObject);
			ShieldActive = false;
			Shield.SetActive (false);
		}
		if (other.tag == "PowerUpShield" && ShieldActive == true) {
			PlayerPrefs.SetInt ("Lives", PlayerPrefs.GetInt ("Lives") + 1);
			Debug.Log ("Life Get!");
			Destroy (other.gameObject);
		}
		if (other.tag == "PowerUpShield" && ShieldActive == false) {
			ShieldActive = true;
			Shield.SetActive (true);
			Debug.Log ("Shield activated!");
			Destroy (other.gameObject);
		}
	}
}
