using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileScript : MonoBehaviour {
public double num = 10;
public float decrease = 0.3f;
public double x = 7;
public double y = 12;
	void Update () {
		while(num >= 9)
		{
			num -= 0.000001f;
		}
	}
}
