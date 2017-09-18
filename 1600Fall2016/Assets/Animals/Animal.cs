using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

	// Use this for initialization
	public virtual void Start () {
		Die();
		Eat();
		Sleep();
	}
	// This makes the word "Die" appear on screen
	void Die () {
		print(this.name + " Dies");
	}
	//This makes the word "Eats" appear on screen
	void Eat () {
		print(this.name + " Eats");
	}
	// This makes the word "Sleep" appear on screen
	void Sleep () {
		print(this.name + " Sleeps");
	}
	// Update is called once per frame
	void Update () {
		
	}
}
