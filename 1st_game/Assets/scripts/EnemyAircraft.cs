using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAircraft : MonoBehaviour {
	Rigidbody2D RB;
	GameObject Player;
	float tajm;
	[Range(0,20)]public int speed;
	GameObject walter;
	public AudioSource sound;
	// Use this for initialization
	void Start () {
		
		RB = GetComponent<Rigidbody2D> ();
		Player = GameObject.Find ("Player");
		walter = Resources.Load ("Prefabs/Enemies/small_astroid") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 dir = Player.transform.position - transform.position;
		float rotationDir = Mathf.Atan2 (dir.x, dir.y) * Mathf.Rad2Deg;
		RB.velocity = dir.normalized*speed;
		transform.rotation = Quaternion.AngleAxis (-rotationDir,Vector3.forward);

		if (Time.unscaledTime >= tajm) 
		{
			tajm = Time.unscaledTime + 1;
			GameObject WalterVit = Instantiate (walter, transform.position+(transform.up.normalized * 1.5f)*2 , Quaternion.identity);

			Rigidbody2D CloneRb = WalterVit.GetComponent<Rigidbody2D> ();
			CloneRb.AddForce (dir.normalized * 10, ForceMode2D.Impulse);
			sound.Play ();
		
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
	
		switch (other.gameObject.tag) {

		case"Player":
			Destroy (this.gameObject);
			break;

		case"bullet":
			

			break;


		case"small_astroid":
			Destroy (this.gameObject);
			break;

		}
	
	
	}

}
