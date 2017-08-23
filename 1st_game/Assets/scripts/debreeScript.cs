using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debreeScript : MonoBehaviour {
	Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D> ();
		Destroy (gameObject, 2);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		switch (Random.Range (1, 4)) {
		case 1:
			rb.AddForce (Vector2.down, ForceMode2D.Impulse);
			//transform.Rotate (0, 0, 5);
			break;
		case 2: rb.AddForce (Vector2.up, ForceMode2D.Impulse);
			//transform.Rotate (0, 0, 5);
			break;
		case 3: rb.AddForce (Vector2.right, ForceMode2D.Impulse);
			//transform.Rotate (0, 0, 5);
			break;
		case 4:
			rb.AddForce (Vector2.left, ForceMode2D.Impulse);
			//transform.Rotate (0, 0, 5);
			break;
		default: 
			break;
		}
	}
}
