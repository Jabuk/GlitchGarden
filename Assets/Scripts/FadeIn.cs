﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {

	public float fadeInTime;
	private Image fadePanel;
	private float a;

	// Use this for initialization
	void Start () {
		fadePanel = GetComponent<Image>();
		a = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad < fadeInTime){
			a = a - (Time.deltaTime/fadeInTime);
			fadePanel.SetTransparency(a);
			//Debug.Log(fadePanel.color);
		} else {
			gameObject.SetActive(false);
		}
		
	}
}
