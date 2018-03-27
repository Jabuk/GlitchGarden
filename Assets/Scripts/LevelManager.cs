using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	void Start(){
		if(SceneManager.GetActiveScene().buildIndex == 0){
			Invoke("LoadNextScene", 3f);
		}
	}

	public void LoadNextScene () {
	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void LoadStartScreen(){
	SceneManager.LoadScene("Start");
	}

	public void LoadEndScreen(){
	SceneManager.LoadScene("End");
	}

	public void LoadScene(string scene){
	SceneManager.LoadScene(scene);	
	}

	public void ExitGame(){
		
	}

}
