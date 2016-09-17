using UnityEngine;
using System.Collections;
using UnityStandardAssets.Vehicles.Car;

public class ChangeCamera : MonoBehaviour {

	public GameObject skeletCamera;
	public GameObject carCamera;
	public GameObject skelet;
	public GameObject car;

	// Use this for initialization
	void Start () {
		skeletCamera.SetActive (true);
		carCamera.SetActive (false);
		car.GetComponent<CarUserControl>().enabled = false;
		car.GetComponent<CarAudio>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (MoveAnimation.endCameraFollow) {
			skeletCamera.SetActive (false);
			carCamera.SetActive (true);
			skelet.SetActive (false);
			car.GetComponent<CarUserControl>().enabled = true;
			car.GetComponent<CarAudio>().enabled = true;
		}
	}

}


