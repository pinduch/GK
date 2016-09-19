using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public Transform gameOver;

	// Use this for initialization
	void Start () {
	
	}

	// coś nie działa to jeszcze chyba na debugu trzeba przepatrzyć.


	// Update is called once per frame
	void Update () {
		if (CollisionDetect.burnCar) {
			if (gameOver.gameObject.activeInHierarchy == false) {
				gameOver.gameObject.SetActive (true);
				Time.timeScale = 0;
			} else {
				gameOver.gameObject.SetActive (false);
				Time.timeScale = 1;
			}
		}
	}
}
