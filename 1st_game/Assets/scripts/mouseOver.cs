using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mouseOver : MonoBehaviour {
	SpriteRenderer sr;


	void Start(){
		sr = this.gameObject.GetComponent<SpriteRenderer> ();
	}

	void OnMouseOver()
	{
		sr.color = Color.green;
	}

	void OnMouseExit()
	{
		sr.color = Color.white;
	}
	void OnMouseDown(){
		string ButtonName = this.tag;
		switch (ButtonName) {
		case "Restart": 

			SceneManager.LoadScene ("Scene_1");
			Time.timeScale = 1;
			break; 
		case "Quit":

			Application.Quit ();
			break;

		}


	}
}
