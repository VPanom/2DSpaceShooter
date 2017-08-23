using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour {
	GameObject bullet;
	bulletClass bull;
	GameObject clone;
	Rigidbody2D rb;
	Rigidbody2D playerRb;
	Vector3 spawnPos;
	float time;
	[SerializeField]
	float bulletSpeed;
	public float fireRate;
	float temprate;
	public AudioSource sound;
	public GameObject shield;
	float tajm=0;
	void Start () {
		temprate = fireRate;

		bullet = Resources.Load ("Prefabs/bullet") as GameObject;
		playerRb = gameObject.GetComponent<Rigidbody2D> ();
	}


	
	// Update is called once per frame
	void Update () {
		//playerRb.AddForce (-transform.up*10, ForceMode2D.Impulse);
		if(Input.GetKeyDown(KeyCode.Mouse0)){fireRate = temprate; spawnBullets(); time = Time.unscaledTime + fireRate;}
		if(Input.GetKey(KeyCode.Mouse0)){

			while(Time.unscaledTime >= time)
			{
				fireRate = Mathf.Clamp (fireRate, 0.1f, 1f);
				fireRate -= 0.01f;

				time = Time.unscaledTime + fireRate;

				spawnBullets ();
			}
			if(Input.GetKeyUp(KeyCode.Mouse0)){fireRate = temprate;}
		}
		if (Input.GetKeyDown (KeyCode.LeftShift)&& Time.unscaledTime >= tajm) 
		{
			StartCoroutine (kiss ());
			tajm = Time.unscaledTime + 5;
		}

	}

	void spawnBullets(){


			
			
			sound.Play ();
			clone = Instantiate (bullet, transform.position+transform.up,Quaternion.identity);
			rb = clone.GetComponent<Rigidbody2D> ();
			rb.velocity = transform.up * bulletSpeed;
			
			
	}

	private IEnumerator kiss()
	{
		shield.SetActive (true);

		yield return new WaitForSeconds (3);
		shield.SetActive(false);

		
	}
		
}
