using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill : MonoBehaviour {
	[SerializeField]
	int lifeTime;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, lifeTime);
	}
	

}
