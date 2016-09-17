using UnityEngine;
using System.Collections;

public class FinishDetect : MonoBehaviour {

	public GameObject meta;
	private int lapCounter = 0;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {


		if (Mathf.Abs (meta.transform.position.x - this.transform.position.x) <= (meta.transform.localScale.x + this.transform.localScale.x) / 2) {
			if (Mathf.Abs (meta.transform.position.y - this.transform.position.y) <= (meta.transform.localScale.y + this.transform.localScale.y) / 2) {
				if (Mathf.Abs (meta.transform.position.z - this.transform.position.z) <= (meta.transform.localScale.z + this.transform.localScale.z) / 2) {
					Debug.Log ("kolizja z metą numer: " + lapCounter);
					lapCounter++;
				}
			}
		}
		else
			Debug.Log ("Brak kolizji");


		// to coś zle działa !!!!! :( :( :(

//		Debug.Log("local scale: \n" +
//			"x = " + this.gameObject.transform.localScale.x + "\n" +
//			"y = " + this.gameObject.transform.localScale.y + "\n" +
//			"z = " + this.gameObject.transform.localScale.z +  "\n\n" +
//			"lossy scale: \n" +
//			"x = " + this.gameObject.transform.lossyScale.x + "\n" +
//			"y = " + this.gameObject.transform.lossyScale.y + "\n" +
//			"z = " + this.gameObject.transform.lossyScale.z);
//



		if (true){
			
		}

//		if (abs(posX - c->posX)  <= (sizex + c->sizex)/2) {
//			if (abs(posY - c->posY)  <= (sizey + c->sizey)/2) {
//				if (abs(posZ - c->posZ)  <= (sizez + c->sizez)/2) {
//					obj->set_color((GLfloat *)Colors[rand() % 10]);
//					set_color((GLfloat *)Colors[rand() % 10]);
//				}
//			}
//		}

	}
}
