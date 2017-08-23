using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerups : MonoBehaviour {
	PlayerClass health;
	Player player_movementSpeed;
	public bulletClass bullet;
	public GameObject bulletObj;
	[SerializeField]
	float rotateSpeed;

	// Use this for initialization
	void Start () {

		player_movementSpeed = GameObject.Find ("Player").GetComponent<Player> ();
		health = GameObject.Find ("Player").GetComponent<PlayerClass> ();
		bulletObj = Resources.Load ("Prefabs/bullet") as GameObject;
		bullet = bulletObj.GetComponent<bulletClass>();
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate (0, 0, rotateSpeed);
		
	}


	//tweak player properties on trigger-collision
	void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.tag == "Player") {
			//Debug.Log("hej");
			switch (tag) {
			case "item_speed":
				player_movementSpeed.movementSpeed += 100;
				break;
			case "item_health":
				health.healthUp (1);
				break;
			case "item_bulletSize":
				bullet.health (1);
				bullet.scaleBullet (0.1f);
				break;
			default:
				break;
			}
		}
	}

}
