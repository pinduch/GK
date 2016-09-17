using UnityEngine;
using System.Collections;

public class MoveAnimation : MonoBehaviour {

	// Body parts
	public Transform skelet;
	public Transform rightArm; 
	public Transform rightForeArm;
	public Transform leftArm;
	public Transform leftForeArm;
	public Transform rightFoot;
	public Transform rightLeg;
	public Transform rightUpLeg;
	public Transform leftFoot;
	public Transform leftLeg;
	public Transform leftUpLeg;
	public Transform highSpin;
	public Transform middleSpin;

	// other variables
	public int counter = 0;
	public int stepCounter = 0;
	public int lastStepCounter = 0;
	public int catchCar = 0;

	public static bool endCameraFollow = false;

	// Use this for initialization
	void Start () {
		endCameraFollow = false;
		leftUpLeg.Rotate (0f, 0f, -20f); 	// lewa do tyłu
		leftLeg.Rotate (0f, 0f, -40f);		// lewy piszczel w tył
		rightUpLeg.Rotate (0f, 0f, 20f);	// prawa w przód  --  to jest pozycja startowa do marszu
		leftArm.Rotate (0f, 0f, 17.5f);
		leftForeArm.Rotate (0f, 0f, 20f);
		rightArm.Rotate (0f, 0f, -17.5f);
	}
	
	// Update is called once per frame
	void Update () {

		if (stepCounter < 2) {
			if (counter < 100) {
				leftUpLeg.Rotate (0f, 0f, 0.4f);   // lewa przód
				rightUpLeg.Rotate (0f, 0f, -0.4f); // prawa w tył
				leftArm.Rotate (0f, 0f, -0.3f);
				leftForeArm.Rotate (0f, 0f, -0.2f);
				rightArm.Rotate (0f, 0f, 0.3f);
				rightForeArm.Rotate (0f, 0f, 0.2f);
				skelet.position += skelet.forward * 0.018f;
			} else if (counter < 150) {
				leftLeg.Rotate (0f, 0f, 0.8f);  	// wyprostuj lewy piszczel
				rightLeg.Rotate (0f, 0f, -0.8f);	// zegnij prawy piszczel
				leftArm.Rotate (0f, 0f, -0.1f);
				rightArm.Rotate (0f, 0f, 0.1f);
				skelet.position += skelet.forward * 0.011f;
			} else if (counter < 250) {
				rightUpLeg.Rotate (0f, 0f, 0.4f); 	
				leftUpLeg.Rotate (0f, 0f, -0.4f);
				leftArm.Rotate (0f, 0f, 0.3f);
				leftForeArm.Rotate (0f, 0f, 0.2f);
				rightArm.Rotate (0f, 0f, -0.3f);
				rightForeArm.Rotate (0f, 0f, -0.2f);
				skelet.position += skelet.forward * 0.018f;
			} else if (counter < 300) {
				rightLeg.Rotate (0f, 0f, 0.8f);
				leftLeg.Rotate (0f, 0f, -0.8f);
				leftArm.Rotate (0f, 0f, 0.1f);
				rightArm.Rotate (0f, 0f, -0.1f);
				skelet.position += skelet.forward * 0.011f;
			}
			counter++;

			if (counter > 300) {
				counter = 0;
			} else if (counter == 150) {
				stepCounter++;					
			}

		} else {
			if (lastStepCounter < 50) {
				if (leftUpLeg.rotation.z > 0) {
					if (leftUpLeg.rotation.z != 0 && rightUpLeg.rotation.z != 0) {
						leftUpLeg.Rotate (0f, 0f, -0.4f);
						rightUpLeg.Rotate (0f, 0f, 0.4f);
						rightLeg.Rotate (0f, 0f, 0.8f);
						rightArm.Rotate (0f, 0f, -0.35f);
						rightForeArm.Rotate (0f, 0f, -0.4f);
						leftArm.Rotate (0f, 0f, 0.35f);
						skelet.position += skelet.forward * 0.018f;
					}
				} else {
					if (leftUpLeg.rotation.z != 0 && rightUpLeg.rotation.z != 0) {
						leftUpLeg.Rotate (0f, 0f, 0.4f);
						rightUpLeg.Rotate (0f, 0f, -0.4f);
						leftLeg.Rotate (0f, 0f, 0.8f);
						leftArm.Rotate (0f, 0f, -0.35f);
						leftForeArm.Rotate (0f, 0f, -0.4f);
						rightArm.Rotate (0f, 0f, 0.35f);
						skelet.position += skelet.forward * 0.018f;
					}
				}
				lastStepCounter++;
			} else {
				if (catchCar < 100) {
					middleSpin.Rotate (0f, 0f, -0.3f);
					highSpin.Rotate (0f, 0f, -0.1f);
					rightArm.Rotate (0f, 0f, 0.8f);
					rightForeArm.Rotate (0f, 0f, 0.5f);
					catchCar++;
				} else {
					endCameraFollow = true;
				}

			}
		}
	}
		
}
