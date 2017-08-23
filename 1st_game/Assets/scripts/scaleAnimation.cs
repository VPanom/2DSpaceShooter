using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleAnimation : MonoBehaviour {
	public float maxLimit;
	public float minLimit;
	float scaleSize;

	// Use this for initialization
	void Start () {
		scaleSize = 1;
	}

	// Update is called once per frame
	void Update () {

		//transform.localScale += new Vector3 (1f * Time.deltaTime * scaleSize, 1f * Time.deltaTime * scaleSize, 0);
		//if(transform.localScale.x <= minLimit || transform.localScale.x>=maxLimit){
			//scaleSize *= -1;
	//}
		transform.localScale = new Vector3(Mathf.Sin(Time.unscaledTime),Mathf.Sin(Time.unscaledTime),0);
		}

	}

		
	



