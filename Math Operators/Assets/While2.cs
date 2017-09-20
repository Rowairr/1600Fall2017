using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While2 : MonoBehaviour {
public double Num1 = 7;
	void Update () {
		while (Num1==7)
		{
			Num1 -= 1;
		}
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
	}
}
