using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {
	private bool pause = true;
	GameObject restart;
	GameObject quit;
	Camera cam;
	//GameObject background;
	// Use this for initialization
	void Start () {
		cam = Camera.main;
		Time.timeScale = 1;
		//background = GameObject.Find ("menuBackground");
		restart = GameObject.Find ("RestartButton");
		quit = GameObject.Find ("QuitButton");
		restart.SetActive(false);
		quit.SetActive (false);
	//	background.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) 
		{
			transform.position = new Vector3 (cam.transform.position.x, cam.transform.position.y, transform.position.z);
			switch (pause) {
			case true:
				pause = false;
				//background.SetActive (true);
				quit.SetActive (true);
				restart.SetActive (true);
				Time.timeScale = 0;
				break;
			case false:
				pause = true;
				//background.SetActive (false);
				quit.SetActive (false);
				restart.SetActive (false);
				Time.timeScale = 1.0f;
				
				break;
			}


		}
	}
}
