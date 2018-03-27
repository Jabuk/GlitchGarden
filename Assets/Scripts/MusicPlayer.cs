using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour {
private AudioSource audioSource;
public AudioClip[] levelClipArray;

	void Awake(){
		DontDestroyOnLoad(gameObject);
	}
	void Start () {
		
	audioSource = GetComponent<AudioSource>();
	audioSource.clip = levelClipArray[0];
	audioSource.Play();

	}

	void OnEnable() {
      SceneManager.sceneLoaded += OnSceneLoaded;
  	}
 
  	void OnDisable() {
      SceneManager.sceneLoaded -= OnSceneLoaded;
  	}
 
  	void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
		audioSource.clip = levelClipArray[scene.buildIndex];
		audioSource.loop = true;
		audioSource.Play();

	}
}