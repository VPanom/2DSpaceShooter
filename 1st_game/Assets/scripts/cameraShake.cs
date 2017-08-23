using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraShake : MonoBehaviour {
	public bool seizure = true;
	//float timeLeft=1;
	public float shakeForce;
	 public float timeLeft;
	GameObject cam;

	void Start () {
		cam = GameObject.Find ("Main Camera");
	}
	void FixedUpdate(){
		if (!seizure) {
			StartCoroutine (ShakeDatShit ());
		}

	}

	public IEnumerator ShakeDatShit()
	{
		
		seizure = true;
		float time = 0;
		while (time < timeLeft) 
		{
			
			time += Time.unscaledDeltaTime;
			cam.transform.position = new Vector3 (cam.transform.position.x + Random.Range(-shakeForce,shakeForce),cam.transform.position.y+Random.Range(-shakeForce,shakeForce), cam.transform.position.z);
			yield return null;
		}

		cam.transform.position = new Vector3 (0, 0, -10);
	

	}

}	
