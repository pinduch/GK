using UnityEngine;
using System.Collections;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;

public class CollisionDetect : MonoBehaviour {

	private int collisionCounter = 0;
	public static bool burnCar = false;
	public GameObject car;
	public Text lifes;
	private int life = 100;
	private bool startCollision = false;

	void OnCollisionEnter(){
		startCollision = true;
//		collisionCounter++;
//		life -= collisionCounter;
//
//		if (collisionCounter >= 2) {
//			burnCar = true;
//		}
	}

	void OnCollisionStay(){
		if (startCollision && (life <= 0)) {
			burnCar = true;
		}
	}

	void OnCollisionExit(){
		if (startCollision && (life > 0)) {
			startCollision = false;
			collisionCounter++;
			life -= collisionCounter*10;
		}
	}
	 

	void Start () {
		lifes.text = "Life: " + life.ToString () + " %";
	}

	void Update(){
		
		lifes.text = "Life: " + life.ToString () + " %";

		if (burnCar){
			if (car.GetComponent<CarUserControl>().isActiveAndEnabled == true)
			car.GetComponent<CarUserControl>().enabled = false;
			if (car.GetComponent<CarAudio>().isActiveAndEnabled == true)
			car.GetComponent<CarAudio>().enabled = false;
		}
	}
}
