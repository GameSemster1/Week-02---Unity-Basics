using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Changes the scale of a gameobject up until a top bound and then down until a bottom bound like a heartbeat.
/// </summary>
public class Scaler : MonoBehaviour
{
	/// <summary>
	/// The higher bound of the scaler.
	/// </summary>
	[Tooltip("The higher bound of the scaler.")]
	public Vector3 maxScale = Vector3.one * 1.5f;

	/// <summary>
	/// The lower bound of the scaler.
	/// </summary>
	[Tooltip("The lower bound of the scaler.")]
	public Vector3 minScale = Vector3.one * 0.5f;

	/// <summary>
	/// The scaling speed.
	/// </summary>
	[Tooltip("The scaling speed.")] public Vector3 scaleSpeed = Vector3.one;

	/// <summary>
	/// The current scaling direction.
	/// </summary>
	private bool scaleUp = true;

	private void Update()
	{
		var currentScale = transform.localScale;
		if (currentScale.x > maxScale.x || currentScale.y > maxScale.y || currentScale.z > maxScale.z)
		{
			scaleUp = false;
		}

		if (currentScale.x < minScale.x || currentScale.y < minScale.y || currentScale.z < minScale.z)
		{
			scaleUp = true;
		}

		transform.localScale += scaleSpeed * ((scaleUp ? 1 : -1) * Time.deltaTime);
	}
}