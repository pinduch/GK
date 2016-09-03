using UnityEngine;
using System.Collections;

public class EthanAnimation : MonoBehaviour {

	// Body parts
	public Transform ethan;
	public Transform rightArm; 
	public Transform rightForeArm;
	public Transform leftArm;
	public Transform leftForeArm;
	public Transform rightShoulder;
	public Transform leftShoulder;
	public Transform rightFoot;
	public Transform rightLeg;
	public Transform rightUpLeg;
	public Transform leftFoot;
	public Transform leftLeg;
	public Transform leftUpLeg;

	// other variables
	public bool direction;
	public int counter = 0;

	// Use this for initialization
	void Start () {
		direction = true; 
	}
	
	// Update is called once per frame
	void Update () {
		if (direction){
			if (counter > 300)
				direction = false;
			else if (counter < 70) {
				leftShoulder.Rotate (-0.2f, -0.3f, 0.2f);
				leftArm.Rotate (0.2f, -0.3f, -0.15f);
			}
			else if (counter < 175)
				leftArm.Rotate (0.2f, -0.3f, -0.15f);
			else
				leftForeArm.Rotate (0.6f, 0.0f, 0.0f);

			counter++;

		} else {

			if (counter < 0)
				direction = true;
			else if (counter > 175)
				leftForeArm.Rotate (-0.6f, 0.0f, 0.0f);
			else if (counter > 70)
				leftArm.Rotate (-0.2f, 0.3f, 0.15f);
			else {
				leftShoulder.Rotate (0.2f, 0.3f, -0.2f);
				leftArm.Rotate (-0.2f, 0.3f, 0.15f);
			}

			counter--;
		}
	}
}
