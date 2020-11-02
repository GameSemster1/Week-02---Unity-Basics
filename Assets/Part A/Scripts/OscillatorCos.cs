using System;
using UnityEngine;

public class OscillatorCos : MonoBehaviour
{
	public float limit;
	public float speed;

	private float startX;
	private float angle = 0;

	void Start()
	{
		startX = transform.position.x;
	}

	void Update()
	{
		angle += speed * Time.deltaTime;

		transform.position = new Vector3(startX + Mathf.Cos(angle) * limit, transform.position.y, transform.position.z);
	}
}