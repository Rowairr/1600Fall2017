using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour {
//If statements are used to plug in functions under certain circumstances.
	void Start () {
		int x = 7;
		if (x==7)
		{
			print("We've got us a lucky 7");
		}
		if(x>7)
		{
			print("That's too high");
		}
		if(x<7)
		{
			print("That's too low");
		}
	}
}
