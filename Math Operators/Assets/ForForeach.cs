using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForForeach : MonoBehaviour{

void Update()
{
	for (int x=7; x>2; x -= 1)
	{
		print("Value of x:{0}",x);
	}
}
}
