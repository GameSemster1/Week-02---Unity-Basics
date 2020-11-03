using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Makes an render appear and disappear when the mouse is clicked.
/// </summary>
public class MouseClick : MonoBehaviour
{
	/// <summary>
	/// The renderer to control.
	/// </summary>
	[Tooltip("The renderer to control.")] public Renderer r;

	private void Start()
	{
		r = gameObject.GetComponent<Renderer>();
		r.enabled = true;
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			if (r.enabled)
			{
				r.enabled = false;
			}
			else
			{
				r.enabled = true;
			}
		}
	}
}