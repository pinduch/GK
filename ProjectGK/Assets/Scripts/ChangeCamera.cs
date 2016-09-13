using UnityEngine;
using System.Collections;


public class ChangeCamera : MonoBehaviour {

	public GameObject skeletCamera;
	public GameObject carCamera;
	public MoveAnimation moveAnimation;

	// Use this for initialization
	void Start () {
		skeletCamera.SetActive (true);
		carCamera.SetActive (false);
		moveAnimation = (MoveAnimation) FindObjectOfType(typeof(MoveAnimation));
	}
	
	// Update is called once per frame
	void Update () {
		if ( moveAnimation.getEndCameraFollow() ) {
			skeletCamera.SetActive (false);
			carCamera.SetActive (true);
		}
	}

	// ciagle to nie działa przełączanie kamery jesli chłopek dojdzie do auta ;)

}


