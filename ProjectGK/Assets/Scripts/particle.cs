using UnityEngine;

public class particle : MonoBehaviour
{
	public static int lifeTime;
	Vector3 velocity;
	Vector3 acceleration;
	Vector3 position;
	float scale;
	Color color;
	private float alpha = 0.035f;

	// Use this for initialization
	void Start()
	{
		position = transform.position;
		acceleration = randomVector () / 20000;
		velocity = randomVector () / 20000;
		lifeTime = 500;
	}

	// Update is called once per frame
	void Update()
	{
		if (CollisionDetect.burnCar) {
			velocity += acceleration;
			position += velocity;
			transform.position = position;
			transform.Rotate (0.5f, 0.5f, 0.5f);
			if (alpha > 0)
				alpha -= 0.00005f;
			color = new Color (1, 1, 1, alpha);
			GetComponent<Renderer> ().material.SetColor ("_TintColor", color);
		}
			
	}

	public bool isDead()
	{
		return lifeTime < 0;
	}

	public Vector3 randomVector(){
		float x, y, z;
		Vector3 movement;

		x = Random.Range(-0.25f, 0.25f);
		y = Random.Range(0.4f, 1.0f);
		z = Random.Range(-0.25f, 0.25f);

		movement = new Vector3 (x, y, z);

		return movement;
	}


}
