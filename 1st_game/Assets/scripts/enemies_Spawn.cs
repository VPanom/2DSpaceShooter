using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemies_Spawn : MonoBehaviour {
	private float time;
	[SerializeField]
	public float timer;
	GameObject large_astroid;
	GameObject clone;
	Rigidbody2D rb;
	public GameObject Player;
	Vector3 direction; 
	float minX;
	float maxX;
	float minY;
	float maxY;
	float verticalView;
	float horizontalView;
	int rand;
	public int offSet;
	Rigidbody2D cloneRB;
	// Use this for initialization
	void Start () {
		large_astroid = Resources.Load ("Prefabs/Enemies/large_astroid") as GameObject;
		//rb = GameObject.Find ("large_astroid").GetComponent<Rigidbody2D> ();
		Player = GameObject.Find("Player");
		verticalView = (float)Camera.main.orthographicSize;
		horizontalView = verticalView * (float)Screen.width / (float)Screen.height;
		minX = horizontalView - horizontalView*2;
		maxX = horizontalView;
		minY = verticalView - verticalView*2;
		maxY = verticalView;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		timer_Spawn ();

		
	}


	
	void timer_Spawn(){
		if (Time.time > time) {
			time = Time.time + timer;
			switch (Random.Range (1, 5)) {
			case 1:
				clone = Instantiate (large_astroid) as GameObject;

				clone.transform.position = new Vector3 (Random.Range (minX, maxX), maxY + offSet,0);
				 cloneRB = clone.GetComponent<Rigidbody2D> ();
				cloneRB.AddForce (Player.transform.position-clone.transform.position*5, ForceMode2D.Impulse);
				break;
			case 2: 
				clone = Instantiate (large_astroid) as GameObject;
				clone.transform.position = new Vector3 (Random.Range (minX, maxX), minY - offSet,0);
				 cloneRB = clone.GetComponent<Rigidbody2D> ();
				cloneRB.AddForce (Player.transform.position-clone.transform.position*5, ForceMode2D.Impulse);
				break;
			case 3: 
				clone = Instantiate (large_astroid) as GameObject;
				clone.transform.position = new Vector3 (minX + offSet,Random.Range (minY, maxY),0);
				 cloneRB = clone.GetComponent<Rigidbody2D> ();
				cloneRB.AddForce (Player.transform.position-clone.transform.position*5, ForceMode2D.Impulse);
				break;
			case 4: 
				clone = Instantiate (large_astroid) as GameObject;
				clone.transform.position = new Vector3 ( maxX + offSet,Random.Range (minY, maxY),0);
				 cloneRB = clone.GetComponent<Rigidbody2D> ();
				cloneRB.AddForce (Player.transform.position-clone.transform.position*5, ForceMode2D.Impulse);
				break;
			default:
				break;

			}
			
			

			}
		}
	}


