using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Moves a gameobject using the keyboard.
/// </summary>
public class PlayerMovement : MonoBehaviour
{
	/// <summary>
	/// Should the forward key move this object up (y axis) or forward (z axis)?
	/// </summary>
	[Tooltip("Should the forward key move this object up (y axis) or forward (z axis)?")]
	public bool upIsForward = true;

	/// <summary>
	/// The speed to move at in meters per second.
	/// </summary>
	[Tooltip("The speed to move at in meters per second.")]
	public float speed = 10;

	/// <summary>
	/// The key that moves the gameobject forward (or up).
	/// </summary>
	[Tooltip("The key that moves the gameobject forward (or up).")]
	public KeyCode forward = KeyCode.UpArrow;

	/// <summary>
	/// The key that moves the gameobject backwards (or down).
	/// </summary>
	[Tooltip("The key that moves the gameobject backwards (or down).")]
	public KeyCode back = KeyCode.DownArrow;

	/// <summary>
	/// The key that moves the gameobject right.
	/// </summary>
	[Tooltip("The key that moves the gameobject right.")]
	public KeyCode right = KeyCode.RightArrow;

	/// <summary>
	/// The key that moves the gameobject left.
	/// </summary>
	[Tooltip("The key that moves the gameobject left.")]
	public KeyCode left = KeyCode.LeftArrow;

	private void Update()
	{
		if (Input.GetKey(forward))
			transform.Translate((upIsForward ? Vector3.up : Vector3.forward) * (speed * Time.deltaTime));

		if (Input.GetKey(back))
			transform.Translate(-(upIsForward ? Vector3.up : Vector3.forward) * (speed * Time.deltaTime));

		if (Input.GetKey(right))
			transform.Translate(Vector3.right * (speed * Time.deltaTime));

		if (Input.GetKey(left))
			transform.Translate(Vector3.left * (speed * Time.deltaTime));
	}
}