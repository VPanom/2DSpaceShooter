using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour {
	float minX;
	float maxX;
	float minY;
	float maxY;
	float verBounds;
	float horBounds;
	float offSizeX = 105;
	float offSizeY = 55;
	public float offSet;
	public float offSet2;
	// Use this for initialization
	void Start () {
		
		verBounds = Camera.main.orthographicSize;
		horBounds = verBounds * Screen.width / Screen.height;

 	minX = horBounds - offSizeX / 2;
		maxX = offSizeX / 2 - horBounds;
		minY = verBounds - offSizeY / 2;
		maxY = offSizeY / 2 - verBounds;

	}


	void Update(){
		
		if (transform.position.x >= maxX + offSet2) {
			transform.position = new Vector3 (minX+offSet, transform.position.y, transform.position.z);
		} else if (transform.position.x <= minX-offSet2) {
			transform.position = new Vector3 (maxX-offSet, transform.position.y, transform.position.z);
		}



		if (transform.position.y >= maxY + offSet2) {
			transform.position = new Vector3 (transform.position.x, minY+offSet, transform.position.z);
		}
		else if(transform.position.y <= minY - offSet2) {
			transform.position = new Vector3 (transform.position.x, maxY-offSet, transform.position.z);
		}
	}





}
