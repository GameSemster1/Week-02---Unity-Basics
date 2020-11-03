using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Follows a target gameobject at a set distance.
/// </summary>
public class Follow : MonoBehaviour
{
	/// <summary>
	/// The gameobject to follow.
	/// </summary>
	[Tooltip("The gameobject to follow.")] public Transform target;

	/// <summary>
	/// The desired distance from the target.
	/// </summary>
	[Tooltip("The desired distance from the target.")]
	public Vector3 offset;

	private void Update()
	{
		transform.position = target.position + offset;
	}
}