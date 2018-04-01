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
	audioSource.volume = PlayerPrefsManager.GetMasterVolume();
	audioSource.Play();
	}

	void OnEnable() {
      SceneManager.sceneLoaded += OnSceneLoaded;
  	}
 
  	void OnDisable() {
      SceneManager.sceneLoaded -= OnSceneLoaded;
  	}
 
  	void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
		if (audioSource.clip != levelClipArray[scene.buildIndex]){ //Only do this if the song is different
		audioSource.clip = levelClipArray[scene.buildIndex];
		audioSource.loop = true;
		audioSource.Play();
		}
	}

	public void SetVolume(float volume){
		audioSource.volume = volume;
	}

}