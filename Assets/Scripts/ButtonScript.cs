using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

	SceneScript currentScene = null;
	public int id;
	
	void Start(){
		currentScene = (SceneScript)GameObject.FindGameObjectWithTag("SceneTag").GetComponent("SceneScript");
		//currentScene.respond();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnMouseOver(){
		currentScene.receiveButtonCall(id, true);
	}
	public void OnMouseExit(){
		currentScene.showSceneText();
	}
	public void OnMouseClick(){
		currentScene.receiveButtonCall(id, false);
	}
}
