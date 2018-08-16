using UnityEngine;
using System.Collections;

public class OffsetScroller : MonoBehaviour {

	public float scrollSpeed;
	public Renderer renderer;

	// Use this for initialization
	void Start () {
		renderer = gameObject.GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		float y = Mathf.Repeat (Time.time * scrollSpeed, 1.0f);
		Vector2 offset = new Vector2 (-0.5f, y);
		renderer.sharedMaterial.SetTextureOffset ("_MainTex", offset);
	}
}
