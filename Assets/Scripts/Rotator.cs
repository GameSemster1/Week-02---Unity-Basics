using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rottator : MonoBehaviour
{
	[Tooltip("speed of rotation")]
    [SerializeField]
    float speed = 10f;
    
	void Update() {
		transform.Rotate(0 , speed * Time.deltaTime, 0);
	}
}
