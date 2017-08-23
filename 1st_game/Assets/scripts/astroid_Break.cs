using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astroid_Break : MonoBehaviour {
	public GameObject small_astroid;
	public GameObject large_astroid;
	public GameObject medium_astroid;
	public bool astroidHit = false;
	cameraShake shake;
	public int hitL=0;
	public int hitM=0;
	Color col;
	void Start () {
		shake = Camera.main.GetComponent<cameraShake> ();
		col = gameObject.GetComponent<SpriteRenderer> ().color;
		small_astroid = Resources.Load ("Prefabs/Enemies/small_astroid") as GameObject;
		medium_astroid = Resources.Load ("Prefabs/Enemies/medium_astroid") as GameObject;
		large_astroid = Resources.Load ("Prefabs/Enemies/large_astroid") as GameObject;
	}




	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Player" || other.gameObject.tag=="bullet") {

			ContactPoint2D contact = other.contacts [0];
			Vector2 pos = contact.point;
			
			switch (tag) {
			case"small_astroid":
				GameObject.Find ("Player").GetComponent<PlayerClass> ().ScoreUp (10);
				Destroy (this.gameObject);
				Rigidbody2D rb = this.gameObject.GetComponent<Rigidbody2D> ();
				//rb.AddForce(new Vector2(Random.Range(-5f,5f),Random.Range(-5f,5f));

				break;
			case"medium_astroid":
				hitM++;
				shake.shakeForce = 0.2f;
				shake.timeLeft = 0.1f;
				shake.seizure = false;
				if (hitM == 2) {
					hitM = 0;

					GameObject.Find ("Player").GetComponent<PlayerClass> ().ScoreUp (50);
					spawnSmall (3,pos);
					Destroy (this.gameObject);
				}
				break;
			case"large_astroid":
				hitL++;
				shake.shakeForce = 0.36f;
				shake.timeLeft = 0.2f;
				shake.seizure = false;
				spawnSmall (2,pos);
				if(hitL==5){
					GameObject.Find ("Player").GetComponent<PlayerClass> ().ScoreUp (100);
					hitL = 0;
				for (int x = 0; x < 2; x++) {
						
					
					GameObject clone = Instantiate (medium_astroid, transform.position, Quaternion.identity) as GameObject;
					Rigidbody2D cloneRB = clone.GetComponent<Rigidbody2D> ();
					cloneRB.AddForce (new Vector2 (Random.Range (-5f, 5f), Random.Range (-8f, 8f)), ForceMode2D.Impulse);
					cloneRB.sharedMaterial.bounciness = 0.9f;
				}

				Destroy(this.gameObject);
				}
				break;
			default:
				break;
			}
		}
	}

	protected void spawnSmall(int SpawnCount, Vector2 contact)
	{
		for (int x = 0; x < SpawnCount; x++) {
			GameObject clone = Instantiate (small_astroid, contact, Quaternion.identity) as GameObject;
		Rigidbody2D cloneRB = clone.GetComponent<Rigidbody2D> ();
		cloneRB.AddForce (new Vector2 (Random.Range (-10f, 10f), Random.Range (-10f, 10f)), ForceMode2D.Impulse);
		}
		
	}



}
