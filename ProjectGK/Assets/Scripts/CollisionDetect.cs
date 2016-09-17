using UnityEngine;
using System.Collections;
using UnityStandardAssets.Vehicles.Car;

public class CollisionDetect : MonoBehaviour {

	private int collisionCounter = 0;
	public static bool burnCar = false;
	public GameObject car;

	void OnCollisionEnter(){
		collisionCounter++;

		if (collisionCounter >= 1) {
			burnCar = true;
		}
	}

	void Update(){
		if (burnCar){
			car.GetComponent<CarUserControl>().enabled = false;
			car.GetComponent<CarAudio>().enabled = false;
		}
	}
}
