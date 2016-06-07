using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShipScript : SceneScript {
	
	public Text text;
	
	//public static bool wasVisited = false;
	
	string[] sceneTexts = 
	{	
		"For which planet do you wish to set course?"
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
			case 2: {manager.changeLevel(1); return;}
			//TODO: Add the rest as well
			default: {Debug.Log("This scene doesn't exist yet, sorry :("); return;}
		}
	}
	
	public override void respond(){
		Debug.Log ("Hi, ship script here!");
	}
	
	public override void showSceneText(){
			text.text = sceneTexts[0];
	}
}
