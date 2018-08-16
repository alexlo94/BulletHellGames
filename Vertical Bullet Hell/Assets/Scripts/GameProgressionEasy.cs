using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameProgressionEasy : MonoBehaviour {
	public GameObject[] Clusters;
	public int[] Wavesizes = {4,2,2,4,4,4,2,4};
	private int SizeIndex = 0;
	private int ClusterIndex = 0;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < Clusters.Length; i++) {
			Clusters [i].SetActive (false);
		}
		StartCoroutine (ActivateWaves ());
	}

	IEnumerator ActivateWaves(){
		yield return new WaitForSeconds (5.0f);
		Activate (ClusterIndex, ClusterIndex + Wavesizes [SizeIndex]);
		ClusterIndex += Wavesizes [SizeIndex];
		SizeIndex++;
		yield return new WaitForSeconds (11.0f);
		Activate (ClusterIndex, ClusterIndex + Wavesizes [SizeIndex]);
		ClusterIndex += Wavesizes [SizeIndex];
		SizeIndex++;
		yield return new WaitForSeconds (12.0f);
		Activate (ClusterIndex, ClusterIndex + Wavesizes [SizeIndex]);
		ClusterIndex += Wavesizes [SizeIndex];
		SizeIndex++;
		yield return new WaitForSeconds (12.0f);
		Activate (ClusterIndex, ClusterIndex + Wavesizes [SizeIndex]);
		ClusterIndex += Wavesizes [SizeIndex];
		SizeIndex++;
		yield return new WaitForSeconds (12.0f);
		Activate (ClusterIndex, ClusterIndex + Wavesizes [SizeIndex]);
		ClusterIndex += Wavesizes [SizeIndex];
		SizeIndex++;
		yield return new WaitForSeconds (17.0f);
		Activate (ClusterIndex, ClusterIndex + Wavesizes [SizeIndex]);
		ClusterIndex += Wavesizes [SizeIndex];
		SizeIndex++;
		yield return new WaitForSeconds (12.0f);
		Activate (ClusterIndex, ClusterIndex + Wavesizes [SizeIndex]);
		ClusterIndex += Wavesizes [SizeIndex];
		SizeIndex++;
		yield return new WaitForSeconds (12.0f);
		Activate (ClusterIndex, ClusterIndex + Wavesizes [SizeIndex]);
		ClusterIndex += Wavesizes [SizeIndex];
		SizeIndex++;
		yield return new WaitForSeconds (12.0f);
		SceneManager.LoadScene ("MediumLevel");
	}
	void Activate(int I1, int I2){
		for(int i = I1; i < I2; i++){
			Clusters [i].SetActive (true);
		}
	}
}
