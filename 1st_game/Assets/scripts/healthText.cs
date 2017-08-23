using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class healthText : MonoBehaviour {
	public Text health_Text;
	public PlayerClass healthclass;
	int lasthealth;
	// Use this for initialization
	void Start () {
		healthclass = GameObject.Find("Player").GetComponent<PlayerClass> ();
		health_Text.text = "";
		lasthealth = healthclass.health;
	}
	
	// Update is called once per frame
	void Update () {
		
		do {
			health_Text.text = "";
			for (int x = 1; x <= healthclass.health; ++x) {
				health_Text.text += "♥ ";

			}
		lasthealth = healthclass.health;
		} while(healthclass.health < lasthealth);

		if (healthclass.health <= 0) {
			
			health_Text.text = "DEAD";
			Time.timeScale = 0;
		}

 

		
	}
}
