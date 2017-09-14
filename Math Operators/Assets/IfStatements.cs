using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour {
//If statements are used to plug in functions under certain circumstances.	
		public double x = 9.0;
		public float decreasingNumber = .1f;
		void Update()
		{
			x -= Time.deltaTime / decreasingNumber;
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
		if(x<=0)
		{
			print("Well, that's that. No more luck.");
		}
		if(x<=6)
		{
			print("Wait... What's going on?");
		}
		if(x<=5)
		{
			print("Hey! Stop that!");
		}
		if(x<=4)
		{
			print("No! Seven come back!");
		}
		if(x<=3)
		{
			print("S.O.S!");
		}
		if(x<=2)
		{
			print("Call the police!!! Call the fire department!");
		}
		if(x<=1)
		{
			print("Call my mom...");
		}
	}
}

