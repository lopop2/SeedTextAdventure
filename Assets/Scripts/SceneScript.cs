using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SceneScript : MonoBehaviour {

	public Button[] sceneRelatedButtons;
	public string[] onButtonHoverStrings;
	protected GameManager manager;
	
	public virtual void receiveButtonCall(int buttonId, bool hover){
	
	}
	
	public virtual void respond(){
	}
	
	public virtual void showSceneText(){
	}
}
