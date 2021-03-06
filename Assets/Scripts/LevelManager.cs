﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevel;

	void Start() {
		if (autoLoadNextLevel > 0) {
			Invoke ("LoadNextLevel", autoLoadNextLevel);
		}
	}

	public void LoadLevel (string name) {
		Debug.Log("LoadLevel() Name: " + name);
		Application.LoadLevel(name);
	}

	public void LoadNextLevel() {
		Debug.Log("LoadNextLevel() Loaded Level: " + Application.loadedLevelName);
		Application.LoadLevel(Application.loadedLevel + 1);
	}

	public void Quit(){
		Debug.Log("Quit()");
		Application.Quit();
	}

	void OnLevelWasLoaded(int level) {
		Debug.Log("OnLevelWasLoaded() Level: " + level);
	}
}
