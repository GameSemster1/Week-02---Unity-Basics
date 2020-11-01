using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public bool upIsForward = true;
	public float speed = 10;

	public KeyCode forward = KeyCode.UpArrow,
		back = KeyCode.DownArrow,
		right = KeyCode.RightArrow,
		left = KeyCode.LeftArrow;

	// Update is called once per frame
	void Update()
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