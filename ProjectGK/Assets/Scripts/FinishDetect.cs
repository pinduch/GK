using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class FinishDetect : MonoBehaviour {

	public GameObject meta;
	public Text lapText;
	public Text timeText;
	private int lapCounter = 0;
	private bool onFinish = false;
	private float elapsedTime;
	public Transform finishGame;

	// Use this for initialization
	void Start () {
		lapText.text = "Lap: 0 / 3";
		timeText.text = "Time: 0:00";
	}

	// Update is called once per frame
	void Update () {

		if (checkCollision ()) {
			onFinish = true;
		} 
		if (!checkCollision () && onFinish) {
			lapCounter++;
			if (lapCounter > 3) {
				lapText.text = "Lap: 3 / 3";
			} else {
				lapText.text = "Lap: " + lapCounter.ToString () + " / 3";
			}
			onFinish = false;
		}
		if (lapCounter > 0 && lapCounter <= 3 && !CollisionDetect.burnCar) {
			elapsedTime += Time.deltaTime;
			timeText.text = "Time: " + elapsedTime.ToString ("f2");
			finishGame.gameObject.SetActive (false);
		} else if (lapCounter > 3 && !CollisionDetect.burnCar) {
			finishGame.gameObject.SetActive (true);
			if (this.GetComponent<CarUserControl>().isActiveAndEnabled == true)
				this.GetComponent<CarUserControl>().enabled = false;
			if (this.GetComponent<CarAudio>().isActiveAndEnabled == true)
				this.GetComponent<CarAudio>().enabled = false;
		} else {
			finishGame.gameObject.SetActive (false);
		}
	}


	private bool checkCollision(){

		if (Mathf.Abs (meta.transform.position.x - this.transform.FindChild ("Cube").position.x) <=
		    (meta.GetComponent<Renderer> ().bounds.size.x + this.transform.FindChild ("Cube").GetComponent<Renderer> ().bounds.size.x) / 2) {
			if (Mathf.Abs (meta.transform.position.y - this.transform.FindChild ("Cube").position.y) <=
			    (meta.GetComponent<Renderer> ().bounds.size.y + this.transform.FindChild ("Cube").GetComponent<Renderer> ().bounds.size.y) / 2) {
				if (Mathf.Abs (meta.transform.position.z - this.transform.FindChild ("Cube").position.z) <=
				    (meta.GetComponent<Renderer> ().bounds.size.z + this.transform.FindChild ("Cube").GetComponent<Renderer> ().bounds.size.z) / 2) {
					return true;
				} else
					return false;
			} else
				return false;
		} else
			return false;
	}
}
