using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor : MonoBehaviour {


	public Texture2D cursorTexture;



	void OnMouseEnter()
	{
		Cursor.SetCursor (cursorTexture, Vector2.zero, CursorMode.Auto);


	}

	void OnMousExit()
	{
		Cursor.SetCursor (null, Vector2.zero, CursorMode.Auto);
	
	}

}
