using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Collider : MonoBehaviour {

	public GameObject scoreText;
	public GameObject TaskCompl;
	public int score = 0;
	public AudioSource collectSound;

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Point") {
			collectSound.Play ();
			score += 10;
			Destroy (col.gameObject);
		}
	}

	void Update()
	{
		scoreText.GetComponent<Text> ().text = "Score:" + score;
		if (score > 49) {
			TaskCompl.SetActive (true);
		} else{
			TaskCompl.SetActive (false);
		}
	}
}
