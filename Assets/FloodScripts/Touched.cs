﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touched : MonoBehaviour {

	GamePlayScript MainScript;
	public GameObject GameManager;

	void Start(){
		MainScript = GameManager.GetComponent<GamePlayScript>();
	}

	void OnTriggerStay2D(Collider2D other){
		//Destroy(this.gameObject);
		if((this.gameObject.GetComponent<Renderer>().material.color == other.gameObject.GetComponent<Renderer>().material.color) && (MainScript.touched.Contains(other.gameObject) == false)){
			other.gameObject.GetComponent<Touched>().enabled = true;
			//this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
			MainScript.AddToTouched(other.gameObject);
		}
	}
}
