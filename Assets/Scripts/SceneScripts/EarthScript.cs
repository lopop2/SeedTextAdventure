using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EarthScript : SceneScript {

	public Text text;
	
	public static bool wasVisited = false;
	
	string[] sceneTexts = 
	{	
		"The human race is no more, with the exception of a few scientists. "+
		"You have been provided with sufficiently diverse specimens of DNA, and all of "+
		"the data needed to find a suitable planet and clone the beginning of the new human race to populate it. ",
		"You've returned back to earth"
	};
	
	// Use this for initialization
	void Start () {
		manager = (GameManager)GameObject.FindGameObjectWithTag("GameManager").GetComponent("GameManager");
		showSceneText();
	}
	
	public override void receiveButtonCall(int buttonId, bool hover){
		if(hover)
			text.text = onButtonHoverStrings[buttonId];
		else
			switch(buttonId)
			{
				case 0: { manager.changeLevel(2); return;}
				case 1: { manager.changeLevel(3); return;}
			}
	}
	
	public override void respond(){
		Debug.Log ("Hi, earth script here!");
	}
	
	public override void showSceneText(){
		if(wasVisited)
			text.text = sceneTexts[1];
		else
			text.text = sceneTexts[0];
	}
}
