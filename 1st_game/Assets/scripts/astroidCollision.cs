using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astroidCollision : MonoBehaviour {
	cameraShake sez;
	public GameObject prefab;
	GameObject debree;
	Rigidbody2D debreeRb;
	public int health;
	public Sprite spritte;
	SpriteRenderer sprite;
	public AudioSource sound;
	public AudioSource sound1;
	public PlayerClass score;
	// Use this for initialization
	void Awake () {
		score = GameObject.Find ("Player").GetComponent<PlayerClass> ();
		sez =GameObject.Find("Main Camera").GetComponent<cameraShake> ();
		//prefab = Resources.Load ("Prefabs/explosion") as GameObject;


	}

	
	
	
		void explode(){
		score.ScoreUp (50);	
		Destroy (gameObject.GetComponent<CircleCollider2D> ());
		Destroy (gameObject.GetComponent<Rigidbody2D> ());
		Destroy (gameObject.GetComponent<SpriteRenderer> ());
		debree = Instantiate (prefab) as GameObject;
		debree.transform.position = transform.position;
		Destroy (gameObject, 1.8f);
		sound.Play ();
		Destroy(debree,2);
			
		}



	void OnCollisionEnter2D(Collision2D other){
		
	
		if (other.gameObject.tag == "Player" || other.gameObject.tag == "bullet") {
			sound1.Play ();
			if (tag == "large_astroid") {
				sprite= gameObject.GetComponent<SpriteRenderer> ();
				sprite.sprite = spritte;
			}
			sez.seizure = false;
			sez.timeLeft = 0.2f;
			sez.shakeForce = 0.3f;
			//t = true;
			health -= 1;
			if (health == 0) {
				
				explode ();

			}

		}
	}

}
