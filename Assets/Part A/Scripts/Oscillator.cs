using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: add documentation
public class Oscillator : MonoBehaviour
{
	/// <summary>
	/// The distance from the starting position that this object should reach.
	/// </summary>
	[Tooltip("The distance from the starting position that this object should reach.")]
	public float limit = 1;

	/// <summary>
	/// The speed multiplier. (The speed depends on <code>limit</code>.
	/// </summary>
	[Tooltip("The speed multiplier")] public float speedScale = 1;

	/// <summary>
	/// The starting x position of this gameobject.
	/// </summary>
	private float startX;

	/// <summary>
	/// the current acceleration.
	/// </summary>
	private float currentAcceleration;

	/// <summary>
	/// The current direction and speed multiplier. This is what makes the object move as an oscillator.
	/// </summary>
	private float dircetion;

	private void Start()
	{
		startX = transform.position.x;
		dircetion = 0;
		transform.position += Vector3.right * limit;
	}

	private void Update()
	{
		if (transform.position.x < startX)
			currentAcceleration = 1 / limit;
		else
			currentAcceleration = -1 / limit;

		dircetion += currentAcceleration * Time.deltaTime;

		transform.position += new Vector3(dircetion * speedScale * limit * Time.deltaTime, 0, 0);
	}
}