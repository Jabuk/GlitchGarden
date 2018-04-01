using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {

	public Slider volumeSlider;
	public Slider difficultySlider;
	public LevelManager levelManager;
	private MusicPlayer musicPlayer;
	// Use this for initialization
	void Start () {
		musicPlayer = GameObject.FindObjectOfType<MusicPlayer>();
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
		difficultySlider.value = PlayerPrefsManager.GetDiffuculty();
		volumeSlider.onValueChanged.AddListener(delegate {VolumeValueChange(); });
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SaveAndExit(){
		PlayerPrefsManager.SetMasterVolume (volumeSlider.value);
		PlayerPrefsManager.SetDifficulty (Convert.ToInt32(difficultySlider.value));
		levelManager.LoadStartScreen();
	}

	public void SetDefaults(){
		volumeSlider.value = 0.8f;
		difficultySlider.value = 2;
	}

	void VolumeValueChange(){
		musicPlayer.SetVolume(volumeSlider.value);
	}
}
