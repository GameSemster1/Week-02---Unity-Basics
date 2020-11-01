using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: add documentation
public class Oscillator : MonoBehaviour
{
	public float limit = 1;
	public float topSpeed = 1;

	private float startX;
	private float currentAcceleration;
	private float dircetion;


	// Start is called before the first frame update
	void Start()
	{
		startX = transform.position.x;
		dircetion = 0;
		transform.position += Vector3.right * limit;
	}

	// Update is called once per frame
	void Update()
	{
		if (transform.position.x < startX)
			currentAcceleration = 1 / limit;
		else
			currentAcceleration = -1 / limit;

		dircetion += currentAcceleration * Time.deltaTime;

		transform.position += new Vector3(dircetion * topSpeed * limit * Time.deltaTime, 0, 0);
	}
}