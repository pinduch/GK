using UnityEngine;
using System.Collections;

public class particleSystem : MonoBehaviour
{
	public GameObject obj;
	ArrayList particles = new ArrayList();
	int limit;

	void Start()
	{
		limit = particle.lifeTime;
	}

	// Update is called once per frame
	void Update()
	{
		if (CollisionDetect.burnCar) {
			particles.Add (Instantiate (obj, transform.position, Quaternion.identity));
			
			if ((particles.Count - 100) >= limit) {

				for (int i = 0; i <= Random.Range (1, 20); i++) {
					Destroy ((GameObject)particles [i]);
					particles.RemoveAt (i);
				}
			}	
		}
	}
}
