using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IfStatements : MonoBehaviour {
	public Text input;

	public bool canPlayGame = false;
	public string password = "tacos";

	void Update (){
		if(input.text == password){
			print("You know the password!?!?");
			canPlayGame = true;
		} else{
			print("Username/Password incorrect");
		}

		if(canPlayGame) {
			print("Playing Game");
		}	else {
			print("Can't Play Yet, Enter a Correct Password");
		}
	}
}