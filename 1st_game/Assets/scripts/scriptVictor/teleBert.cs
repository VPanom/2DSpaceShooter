using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleBert : MonoBehaviour {

	float minX;
	float maxX;
	float minY;
	float maxY;
	float verticalView;
	float horizontalView;
	bool wallHit;
	public float offset;

	// Use this for initialization
	void Start () {

		verticalView = (float)Camera.main.orthographicSize;
		horizontalView = verticalView * (float)Screen.width / (float)Screen.height;
		minX = horizontalView - horizontalView*2;
		maxX = horizontalView;
		minY = verticalView - verticalView*2;
		maxY = verticalView;




	}


	void Update(){
		

		if (transform.position.x >= maxX+offset) {
			wallHit = true;
			transform.position = new Vector3 (minX-offset, transform.position.y, transform.position.z);
		} else if (transform.position.x <= minX-offset) {
			wallHit = true;
			transform.position = new Vector3 (maxX+offset, transform.position.y, transform.position.z);
		}



		if (transform.position.y >= maxY+offset) {
			wallHit = true;
			transform.position = new Vector3 (transform.position.x, minY-offset, transform.position.z);
		}
		else if(transform.position.y <= minY-offset) {
			wallHit = true;
			transform.position = new Vector3 (transform.position.x, maxY+offset, transform.position.z);
		
		}
		

		if (wallHit && tag == "small_astroid"||wallHit && tag == "bullet") {
			Destroy (this.gameObject);
		}

	}





}
