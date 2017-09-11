using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IfStatements : MonoBehaviour {
	public Text input;
	public string password = "tacos";

	void Update (){
		if(input.text == password){
			print("You know the password!?!?");
		}
	}
}