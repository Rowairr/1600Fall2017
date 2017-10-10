using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

	public string[] foxFood = {"Bananas", "Apples", "Grapes", "Chicken", "Turkey", "Cake"};
	public int[] foodCount = {3, 45, 3, 1, 1, 1};
	// Use this for initialization
	public virtual void Start () {
		Die();

		for(int i = 0; i < foxFood.Length; i++)
		{
			Eat(foxFood[i], foodCount[i]);
		}
		Sleep();
	}
	// This makes the word "Die" appear on screen
	void Die () {
		print(this.name + " Dies");
	}
	//This makes the word "Eats" appear on screen
	void Eat (string food, int amount) {
		print(this.name + "likes to eat" + food);
		print(this.name + "ate" + amount);
	}
	// This makes the word "Sleep" appear on screen
	void Sleep () {
		print(this.name + " Sleeps");
	}
	// Update is called once per frame
	void Update () {
		
	}
}
