using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public Canvas MainCanvas;
	public Transform image;
	public Transform[] buttons;

	public void LoadOn(){
		UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
		CollisionDetect.burnCar = false;
		Time.timeScale = 1;
	}

	public void exitGame(){
		Application.Quit ();
	}

	public void about(){
		image.gameObject.SetActive(true);
		foreach(Transform btn in buttons){
			btn.gameObject.SetActive (false);
		}
	}

	public void backToMenu(){
		image.gameObject.SetActive(false);
		foreach(Transform btn in buttons){
			btn.gameObject.SetActive (true);
		}
	}

}
