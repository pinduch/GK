using UnityEngine;

public class particle : MonoBehaviour
{
	public static int lifeTime;
	Vector3 velocity;
	Vector3 acceleration;
	Vector3 position;
	float scale;
	Color color;

	// Use this for initialization
	void Start()
	{
		transform.position += randomVector ();
		position = transform.position;
		acceleration = randomVector () / 20000;
		velocity = randomVector () / 20000;

		particleSystem ps = (particleSystem)FindObjectOfType(typeof(particleSystem));
		lifeTime = 200;

	}

	// Update is called once per frame
	void Update()
	{
		velocity += acceleration;
		position += velocity;
		transform.position = position;
		transform.Rotate (0.5f, 0.5f, 0.5f);

	//	if (lifeTime < (lifeTime / 10)) {
	//		scale = transform.lossyScale.x - 0.1f;
	//		if (scale > 0)
	//			transform.localScale = new Vector3 (scale, scale, scale);
	//	}

	//	color = transform.GetComponent<SpriteRenderer>().color;
	//	color = new Color (color.r, color.g, color.b, color.a - 3.0f);
	//	transform.GetComponent<SpriteRenderer> ().color = color;

	//	transform.GetComponent<Shader> ().maximumLOD (UIVertex.simpleVert.color.a);

		lifeTime--;
	//	Color color = transform.GetComponent<Shader> ().color;


	//	if (isDead ()) 
		//Destroy (transform.gameObject);
	//		Destroy(gameObject);
	}

	public bool isDead()
	{
		return lifeTime < 0;
	}

	public Vector3 randomVector(){
		float x, y, z;
		Vector3 movement;

		x = Random.Range(-0.25f, 0.25f);
		y = Random.Range(0.0f, 1.0f);
		z = Random.Range(-0.25f, 0.25f);

		movement = new Vector3 (x, y, z);

		return movement;
	}


}
