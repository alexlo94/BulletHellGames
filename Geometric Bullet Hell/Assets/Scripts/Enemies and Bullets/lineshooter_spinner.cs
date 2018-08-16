using UnityEngine;
using System.Collections;

public class lineshooter_spinner : MonoBehaviour {
	public float y_rotate = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, y_rotate, 0);
	}
}
