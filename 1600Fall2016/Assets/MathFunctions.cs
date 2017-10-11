using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathFunctions : MonoBehaviour {
public int myScore;
public int health;
public int regen;
public int ammo;
public int dead;
public int robbed;
public int living;
public int helped;
public string myPassword = "CoolStuff";
public string myDoorPassword;
public int myLife;
public int BrutalityRating;
public int MercyRating;
public int PovertyRating;
public int BetraylRating;
public int DeathTotal;
public int JustOkay;

	void Start () {
		myScore = ReturnNum(health, ammo);
		myPassword = ReturnPassword(myPassword);
		myDoorPassword = DoorPassword(myDoorPassword);
		myLife = ReturnH(health, regen);
		BrutalityRating =ReturnBrutal(dead, robbed);
		MercyRating = ReturnMercy(living, helped);
		PovertyRating = ReturnPov(living, robbed);
		BetraylRating = ReturnB(dead, helped);
		DeathTotal = ReturnD(living, dead);
		JustOkay = ReturnOK(living);
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
	}
	string DoorPassword (string password){
		if(password == "0825"){
			return "The door has opened";
		}else{
			return "Your fate is still sealed";
		}
	}
	int ReturnH(int num, int num2){
		return num * num2;
	}
	int ReturnMercy(int num, int num2){
		return num * num2;
	}
	int ReturnBrutal(int num, int num2){
		return num * num2;
	}
	int ReturnPov(int num, int num2){
		return num * num2;
	}
	int ReturnB(int num, int num2){
		if(dead <= helped){
			return num * num2;
		}else{
			return 0;
		}
	}
	int ReturnD(int num, int num2){
		return num - num2;
	}
	int ReturnOK(int num){
		return num;
	}
}
