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
		particles.Add ( Instantiate (obj, transform.position, Quaternion.identity));
			
		if ( (particles.Count/2) == limit ) {
			Destroy ((GameObject) particles [0]);
			particles.RemoveAt (0);
			Destroy ((GameObject) particles [1]);
			particles.RemoveAt (1);
			Destroy ((GameObject) particles [2]);
			particles.RemoveAt (2);
		}		
	}
}
