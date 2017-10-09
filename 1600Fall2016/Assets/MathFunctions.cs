using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathFunctions : MonoBehaviour {
public int myScore;
public int health;
public int ammo;
public string myPassword = "CoolStuff";
public string myDoorPassword;
	void Start () {
		myScore = ReturnNum(health, ammo);
		myPassword = ReturnPassword(myPassword);
		myDoorPassword = DoorPassword(myDoorPassword);
	}
	int ReturnNum(int _num, int _num2) {
		return _num + _num2;
	}
	string ReturnPassword (string _login){
		if(_login == "ou812"){
		return "Password Correct";
	} else{
		return "Incorrect";
	}
	string DoorPassword(string password){
		if(password == "0825"){
			return "The door has opened";
		}else{
			return "Your fate is still sealed";
		}
	}
}
}
