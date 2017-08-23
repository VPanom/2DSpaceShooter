
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour {
	public Text Score;
	PlayerClass playerclass;
	// Use this for initialization
	void Start () {
		playerclass = GameObject.Find ("Player").GetComponent<PlayerClass> ();
	}
	
	// Update is called once per frame
	void Update () {
		Score.text = playerclass.GameScore.ToString ();
	}
}
