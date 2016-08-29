using UnityEngine;
using System.Collections;
using UnityStandardAssets.Vehicles.Car;

public class PauseGame : MonoBehaviour {

	public Transform canvas;
	public Transform car;
	
	// Update is called once per frame
	void Update () {
		pause ();
	}

	public void pause(){
		if (Input.GetKeyDown(KeyCode.Escape)) {
			if (canvas.gameObject.activeInHierarchy == false) {
				canvas.gameObject.SetActive (true);
				Time.timeScale = 0;
				car.GetComponent<CarAudio>().enabled = false;
			} else {
				canvas.gameObject.SetActive (false);
				Time.timeScale = 1;
				car.GetComponent<CarAudio>().enabled = true;
			}
		}
	}
		
	public void goToMenu(){
		UnityEngine.SceneManagement.SceneManager.LoadScene ("Menu");
	}

	public void restartLevel(){
		UnityEngine.SceneManagement.SceneManager.LoadScene ("Game");
		Time.timeScale = 1;
	}

	public void resumGame(){
		if (canvas.gameObject.activeInHierarchy == true) {
			canvas.gameObject.SetActive (false);
			Time.timeScale = 1;
			car.GetComponent<CarAudio>().enabled = true;
		}
	}

	public void exitGame(){
		Application.Quit();
	}
}
