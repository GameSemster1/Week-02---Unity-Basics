using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
	[Tooltip("speed of rotation")] [SerializeField]
	float speed = 10f;

	void Update()
	{
		transform.Rotate(0, 0, speed * Time.deltaTime);
	}
}