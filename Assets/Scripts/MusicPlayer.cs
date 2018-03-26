using System;

using UnityEngine;

public class MusicPlayer : MonoBehaviour {

private AudioSource music;
public AudioClip introClip;


	// Use this for initialization
	void Start () {
		
	music = GetComponent<AudioSource>();
	music.clip = introClip;
	music.Play();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
