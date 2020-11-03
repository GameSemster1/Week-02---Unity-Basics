using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
	/// <summary>
	/// The speed of the rotation in degrees per second.
	/// </summary>
	[Tooltip("speed of rotation")] [SerializeField]
	float speed = 10f;

	private void Update()
	{
		transform.Rotate(0, 0, speed * Time.deltaTime);
	}
}