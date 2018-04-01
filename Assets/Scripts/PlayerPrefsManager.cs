using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefsManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string LEVEL_KEY = "level_unlocked_";


	public static void SetMasterVolume (float volume) {
		if (volume >= 0f && volume <= 1f) {
		PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, volume);
		Debug.Log ("Master volume set to " + volume.ToString());
		} else {
			Debug.LogError ("Master Volume value out of range!");
		}
	}
	public static float GetMasterVolume (){
		Debug.Log ("Master volume: " + PlayerPrefs.GetFloat (MASTER_VOLUME_KEY));
		return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
	}
	public static void UnlockLevel (int level){
		if (level <= SceneManager.sceneCountInBuildSettings -1) {
			PlayerPrefs.SetInt (LEVEL_KEY + level.ToString(), 1) ;
		} else {
			Debug.LogError("Trying to unlock a level out of build order");
		}
	}
	public static bool isLevelUnlocked (int level){
		if (level <= SceneManager.sceneCountInBuildSettings -1) {	
			if (PlayerPrefs.GetInt (LEVEL_KEY + level.ToString()) == 1){
				return true;
			} else {
				return false;
			}
		} else {
			Debug.LogError("isLevelUnlocked: querying a level outside of build order!");
			return false;
		}
	}

	public static void SetDifficulty (int difficulty) {
		if (difficulty >= 1f && difficulty <= 3f) {
		PlayerPrefs.SetInt (DIFFICULTY_KEY, difficulty);
		} else {
			Debug.LogError ("difficulty out of range!");
		}
	}
	public static float GetDiffuculty (){
		return PlayerPrefs.GetInt (DIFFICULTY_KEY);
	}
	
}
