﻿using UnityEngine;
using System.Collections;

public class VideoController : MonoBehaviour {

	public MovieTexture myMovie;
	
	void Start()
	{
		myMovie.Play();
	}
	
	
	void OnGUI()
	{
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), myMovie);
	}
}
