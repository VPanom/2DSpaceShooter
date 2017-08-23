using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour {
	public float speed;
	public float distanceFromCamera;

	
	// Update is called once per frame
	void Update () {
		Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		mousePosition.z = distanceFromCamera;
		Vector3 position = Vector3.Lerp (transform.position, mousePosition, 1.0f - Mathf.Exp (-speed * Time.unscaledDeltaTime));
		transform.position = position;
	}
}
