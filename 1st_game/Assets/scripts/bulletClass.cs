using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletClass : MonoBehaviour {

	void Start(){
		Destroy (gameObject, 2);
	}
	public int healthPoints;
	public Vector3 bulletScale;

	public int health(int hp){
		healthPoints = healthPoints + hp;
		return healthPoints;
	}

	public Vector3 scaleBullet(float var){
		transform.localScale = new Vector3 (transform.localScale.x + var, transform.localScale.y + var);
		return transform.localScale;
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "wall") {
			Destroy (gameObject);
		}
		health (-1);
		scaleBullet (-0.1f);
		if (healthPoints <= 0) {
			Destroy (gameObject);
		}


	}




}
