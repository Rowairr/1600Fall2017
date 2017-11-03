using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While2 : MonoBehaviour {
public double Num1 = 7;
public double Num2 = 4;
	void Update () {
		/* A while loop is like an if statement that will continue to run as long
		as the given input is true */
		while (Num1==7)
		{
			Num1 -= 1;
		}
		/*For example, this above function will run only while Num1 is exactly equal
		to seven, causing it to only run once.*/
		while (Num1==6)
		{
			Num1 -= 1;
		}
		while (Num1==5)
		{
			Num1 -= 1;
		}
		while (Num1<=4)
		{
			Num1 -= 0.5f;
		}
		while (Num1 <= 0)
		{
			Num1 = 0;
		}
		while (Num1 == 0)
		{
			print("While Loop Complete");
		}
		while (Num2 == 4)
		{
			print("Num2 is currently 4");
		}
		while (Num2 <= 4)
		{
			if(Num2 >= 3)
			{
				Num2 -= 0.5f;
			}
				}
		while (Num2 <= 3)
		{
			if(Num2 >= 2)
			{
				Num2 -= 0.5f;
			}
			else
			{
				print("While Loop complete");
			}
		while (Num2 <= 2)
		{
			print("Final While Loop complete");
		}
		}
	}
}
