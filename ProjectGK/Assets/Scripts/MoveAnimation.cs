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

	// other variables
	public bool legForward;
	public int counter = 0;

	// Use this for initialization
	void Start () {
		legForward = true;      // true - prawa idzie do przodu, false - lewa idzie do przodu
	}
	
	// Update is called once per frame
	void Update () {

		if (counter < 100) {
			leftUpLeg.Rotate (0f, 0f, -0.2f); 	// lewa do tyłu
			leftLeg.Rotate (0f, 0f, -0.4f);		// lewy piszczel w tył
			rightUpLeg.Rotate (0f, 0f, 0.2f);	// prawa w przód  --  to jest pozycja startowa do marszu
			leftArm.Rotate(0f,0f, 0.175f);
			leftForeArm.Rotate (0f, 0f, 0.2f);
			rightArm.Rotate(0f, 0f, -0.175f);
		} else if (counter < 200) {
			leftUpLeg.Rotate (0f, 0f, 0.4f);   // lewa przód
			rightUpLeg.Rotate (0f, 0f, -0.4f); // prawa w tył
			leftArm.Rotate(0f,0f,-0.3f);
			leftForeArm.Rotate (0f, 0f, -0.2f);
			rightArm.Rotate(0f, 0f, 0.3f);
			rightForeArm.Rotate (0f, 0f, 0.2f);
			skelet.position += skelet.forward * 0.018f;
		} else if (counter < 250) {
			leftLeg.Rotate (0f, 0f, 0.8f);  	// wyprostuj lewy piszczel
			rightLeg.Rotate (0f, 0f, -0.8f);	// zegnij prawy piszczel
			leftArm.Rotate(0f,0f,-0.1f);
			rightArm.Rotate(0f, 0f, 0.1f);
			skelet.position += skelet.forward * 0.011f;
		} else if (counter < 350) {
			rightUpLeg.Rotate (0f, 0f, 0.4f); 	//
			leftUpLeg.Rotate (0f, 0f, -0.4f);
			leftArm.Rotate(0f,0f, 0.3f);
			leftForeArm.Rotate (0f, 0f, 0.2f);
			rightArm.Rotate(0f, 0f,-0.3f);
			rightForeArm.Rotate (0f, 0f, -0.2f);
			skelet.position += skelet.forward * 0.018f;
		} else if (counter < 400) {
			rightLeg.Rotate (0f, 0f, 0.8f);
			leftLeg.Rotate (0f, 0f, -0.8f);
			leftArm.Rotate(0f,0f, 0.1f);
			rightArm.Rotate(0f, 0f, -0.1f);
			skelet.position += skelet.forward * 0.011f;
		}
		counter++;

		if (counter > 400)
			counter = 100;

		/*			if (counter < 100) {
			leftUpLeg.Rotate (0f, 0f, -0.2f); 	// lewa do tyłu
			leftLeg.Rotate (0f, 0f, -0.2f);		// lewy piszczel w tył
			rightUpLeg.Rotate (0f, 0f, 0.2f);	// prawa w przód  --  to jest pozycja startowa do marszu
			leftArm.Rotate(0f,0f, 0.175f);
			leftForeArm.Rotate (0f, 0f, 0.2f);
			rightArm.Rotate(0f, 0f, -0.175f);
		} else if (counter < 200) {
			leftUpLeg.Rotate (0f, 0f, 0.4f);   // lewa przód
			rightUpLeg.Rotate (0f, 0f, -0.4f); // prawa w tył
			leftArm.Rotate(0f,0f,-0.3f);
			leftForeArm.Rotate (0f, 0f, -0.2f);
			rightArm.Rotate(0f, 0f, 0.3f);
			rightForeArm.Rotate (0f, 0f, 0.2f);
			skelet.position += skelet.forward * 0.018f;
		} else if (counter < 250) {
			leftLeg.Rotate (0f, 0f, 0.4f);  	// wyprostuj lewy piszczel
			rightLeg.Rotate (0f, 0f, -0.4f);	// zegnij prawy piszczel
			leftArm.Rotate(0f,0f,-0.1f);
			rightArm.Rotate(0f, 0f, 0.1f);
			skelet.position += skelet.forward * 0.011f;
		} else if (counter < 350) {
			rightUpLeg.Rotate (0f, 0f, 0.4f); 	//
			leftUpLeg.Rotate (0f, 0f, -0.4f);
			leftArm.Rotate(0f,0f, 0.3f);
			leftForeArm.Rotate (0f, 0f, 0.2f);
			rightArm.Rotate(0f, 0f,-0.3f);
			rightForeArm.Rotate (0f, 0f, -0.2f);
			skelet.position += skelet.forward * 0.018f;
		} else if (counter < 400) {
			rightLeg.Rotate (0f, 0f, 0.4f);
			leftLeg.Rotate (0f, 0f, -0.4f);
			leftArm.Rotate(0f,0f, 0.1f);
			rightArm.Rotate(0f, 0f, -0.1f);
			skelet.position += skelet.forward * 0.011f;
		}
		*/
	}
		


	public void startWalk(){
		leftUpLeg.Rotate (0f, 0f, 0.5f);
		leftLeg.Rotate (0f, 0f, -0.5f);
		leftLeg.Rotate (0f, 0f, 0.5f);
		rightUpLeg.Rotate (0f, 0f, -0.3f);
		rightLeg.Rotate (0f, 0f, -0.2f);
		skelet.position += skelet.forward * 0.015f;
		leftLeg.Rotate (0f, 0f, -0.5f);
		rightUpLeg.Rotate (0f, 0f, 0.3f);
		rightLeg.Rotate (0f, 0f, 0.2f);
		skelet.position += skelet.forward * 0.015f;
		leftUpLeg.Rotate (0f, 0f, -0.5f);
		leftLeg.Rotate (0f, 0f, 0.5f);
	}

	public void machanie(){
		if (legForward){
			if (counter > 300)
				legForward = false;
			else if (counter < 70) {
				leftArm.Rotate (0.2f, -0.3f, -0.15f);
			}
			else if (counter < 175)
				leftArm.Rotate (0.2f, -0.3f, -0.15f);
			else
				leftForeArm.Rotate (0.6f, 0.0f, 0.0f);

			counter++;

		} else {

			if (counter < 0)
				legForward = true;
			else if (counter > 175)
				leftForeArm.Rotate (-0.6f, 0.0f, 0.0f);
			else if (counter > 70)
				leftArm.Rotate (-0.2f, 0.3f, 0.15f);
			else {
				leftArm.Rotate (-0.2f, 0.3f, 0.15f);
			}

			counter--;
		}
	}
}
