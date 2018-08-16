using UnityEngine;
using System.Collections;

public class LineClusterMovement : MonoBehaviour {
	public float Speed;
	private Vector3 CurrPos;
	public Transform[] Enemies;
	public Vector3[] Path;
	private int PathIndex = 0;
	public int WhenToShoot;

	// Use this for initialization
	void Start () {
		Enemies = transform.GetComponentsInChildren<Transform> ();
		StartCoroutine (MoveTo(Path[PathIndex]));
	}
	IEnumerator MoveTo(Vector3 targetPos){
		StartCoroutine (CommandShoot (WhenToShoot));
		CurrPos = transform.position;
		while(!Vector3.Equals(CurrPos, targetPos)){
			CurrPos = Vector3.MoveTowards(CurrPos, targetPos, Speed*Time.deltaTime);
			transform.localPosition = CurrPos;
			yield return null;
		}
		if (PathIndex == Path.Length-1) {
			this.gameObject.SetActive (false);
		} else {
			PathIndex++;
			//yield return new WaitForSeconds (2.0f);
			StartCoroutine (MoveTo (Path [PathIndex]));
		}
	}
	IEnumerator CommandShoot(int DesiredPathIndex){
		if (PathIndex == DesiredPathIndex) {
			for (int i = 1; i < Enemies.Length; i++) {
				Enemies [i].gameObject.GetComponent<ShooterBehavior> ().StartCoroutine (Enemies[i].gameObject.GetComponent<ShooterBehavior>().Pattern);
			}
		}
		yield return null;
	}
	IEnumerator StopShoot(){
		for (int i = 1; i < Enemies.Length; i++) {
			Enemies [i].gameObject.GetComponent<ShooterBehavior> ().StopCoroutine (Enemies[i].gameObject.GetComponent<ShooterBehavior>().Pattern);
		}
		yield return null;
	}
}
