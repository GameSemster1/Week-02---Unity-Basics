using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
	public Vector3 maxScale = Vector3.one * 1.5f;
	public Vector3 minScale = Vector3.one * 0.5f;
	public Vector3 scaleSpeed = Vector3.one;

	private bool scaleUp = true;

	// Update is called once per frame
	void Update()
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