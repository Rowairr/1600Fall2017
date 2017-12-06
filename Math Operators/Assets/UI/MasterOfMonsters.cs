using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MasterOfMonsters : MonoBehaviour {
public Text activeword;
public string[] monsterstatement = {"Master", "of", "Monsters!!!"};
	
	void OnTriggerEnter()
	{
		foreach (string value in monsterstatement)
		{
			print (monsterstatement);
		}
	}
}
