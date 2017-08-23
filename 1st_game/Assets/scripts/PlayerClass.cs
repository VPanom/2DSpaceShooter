using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass : MonoBehaviour {
	public int health=5;
	public int GameScore = 0;

	void Awake(){
		Application.targetFrameRate = 300;
	}

	public int ScoreUp(int x)
	{

		GameScore = GameScore + x; 
		return GameScore;
	}

	public int healthDown(int x)
	{

		health = health - x;
		return health;

	}

	public int healthUp(int x)
	{

		health += x;
		return health;
	}

	//KEK
}

