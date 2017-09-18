using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour {

	public string[] weapons;

	public void MyWeaponSwitch (int I){
		switch(weapons[I])
		{
			case "Missile":
				print("Missile");
				break;

			case "Plasma":
				print("Plasma");
				break;
			
			default:
				print("You have no other weapons.");
				break;
		}
	}
}
