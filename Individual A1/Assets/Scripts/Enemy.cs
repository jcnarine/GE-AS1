using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Spaceship
	{

	public float shootTimer;
	public float minVelocity;


	void Awake()
	{
		float temp = Random.Range(minVelocity, maxVelocity);
		rb.velocity = new Vector3(0.0f, temp, 0.0f);
	}

	public void Update()
	{
		Invoke("Shoot", shootTimer);
	}

	public void OnTriggerEnter(Collider other)
		{

		if (other.gameObject.CompareTag("Boundary") || (other.gameObject.CompareTag("Player")))
			{Destroy(this.gameObject);}
		if (other.gameObject.CompareTag("PlayerBullet"))
			{
			if (lives == 0) 
			{
				Destroy(this.gameObject);
			} else {
				lives -= 1;
			}
		}

	}

}
