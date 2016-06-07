using UnityEngine;
using System.Collections;


public class GameManager : MonoBehaviour 
{	
	public void Start(){
		DontDestroyOnLoad(this);
	}
	
	public void changeLevel(string id)
	{
		Debug.Log("Changing level to "+ id);
		Application.LoadLevel(id);
	}
	
	public void changeLevel(int id){
		Application.LoadLevel(id);
	}
	
	public void quitGame(){
		Debug.Log("Quitting");
		Application.Quit();
	}
	
	public void startGame()
	{
		Application.LoadLevel(1);
	}
	
	public void lose(){
		Application.LoadLevel(Application.levelCount-1);
	}
	
	public void win()
	{
		Application.LoadLevel(Application.levelCount-2);
	}
	
	public void loadNextLevel(){
		if(Application.loadedLevel < Application.levelCount - 3) 
		{
			Application.LoadLevel(Application.loadedLevel+1);
			return;
		}
		win();
	}
}
