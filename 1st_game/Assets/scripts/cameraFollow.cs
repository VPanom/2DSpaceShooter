using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {
	GameObject playerPos;
	public float time;
	void Start(){
		playerPos = GameObject.Find ("Player");

	}

	void FixedUpdate(){
		transform.position = new Vector3(Mathf.Clamp (transform.position.x, -0.5f, 28),Mathf.Clamp (transform.position.y, -7.2f, 7.2f),transform.position.z);
		transform.position = Vector3.MoveTowards (transform.position, new Vector3(playerPos.transform.position.x,playerPos.transform.position.y,transform.position.z) , time);
	}

}
