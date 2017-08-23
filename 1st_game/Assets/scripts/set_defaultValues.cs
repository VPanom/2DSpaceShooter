using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class set_defaultValues : MonoBehaviour {
	GameObject bull;
	bulletClass bullet;
	int hp_default = 1;
	public Vector3 bulletScale = new Vector3(0.5f,0.5f,0);
	// Use this for initialization
	void Start () {
		bull = Resources.Load ("Prefabs/bullet") as GameObject;
		bullet = bull.GetComponent<bulletClass> ();
		bull.GetComponent<Transform> ().localScale=bulletScale;
		bull.GetComponent<bulletClass> ().healthPoints = hp_default;


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
