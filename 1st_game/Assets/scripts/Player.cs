using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour {
	[SerializeField]
	private float rotationSpeed;
	[SerializeField]
	public float movementSpeed;
	Rigidbody2D rb;
	Rigidbody2D rb2;
	Vector2 tempVelocity; 
	PlayerClass classProperties;
	Vector3 mousePos;
	Vector3 worldPos;
	float angle;
	public GameObject shield;
	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D> ();
		classProperties	 = 	gameObject.GetComponent<PlayerClass>();

	}
	



	void FixedUpdate(){

		player_rotate ();
		player_movement ();

	}

	void player_rotate(){

		mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		transform.rotation = Quaternion.LookRotation (Vector3.forward, mousePos - transform.position );

	}

	void player_movement(){

		rb.velocity = new Vector2 (Input.GetAxis ("Horizontal") * Time.fixedDeltaTime * movementSpeed, Input.GetAxis ("Vertical") * Time.fixedDeltaTime * movementSpeed);

	}


	void OnCollisionEnter2D(Collision2D other){
		if (shield.active == false) {
			switch (other.gameObject.tag) {
			case"small_astroid":
				classProperties.healthDown (1);
				Debug.Log (classProperties.health);
				break;
			case"medium_astroid":
				classProperties.healthDown (1);
				break;
			case"large_astroid":
				classProperties.healthDown (2);
				break;
			default:
				break;
			}
		}
	}
}

