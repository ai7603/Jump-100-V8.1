﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoneButton : MonoBehaviour {

    public AudioSource click_audio;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void backtomain(){
		SceneManager.LoadScene ("Main");
	}
}