using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public Transform gameOver;
	private float time;

	// Use this for initialization
	void Start () {
	
	}

	// coś nie działa to jeszcze chyba na debugu trzeba przepatrzyć.

	// Update is called once per frame
	void Update () {
		if (CollisionDetect.burnCar) {
			time += Time.deltaTime;
			if (time > 5.0f) {
				gameOver.gameObject.SetActive (true);
			} else {
				gameOver.gameObject.SetActive (false);
			}
		}
	}
}
