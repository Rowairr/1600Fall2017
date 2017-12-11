using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MasterOfMonsters : MonoBehaviour {
public GameObject text1;
public GameObject text2;
public GameObject text3;
public int activationcode = 9;
public string[] monsterstatement = {"Master", "of", "Monsters!!!"};
	
	void OnTriggerEnter()
	{
		activationcode -= 3;
		//I know this is a really dumb use of a foreach loop, but
		//it's the only thing I could come up with.
		foreach (string value in monsterstatement)
		{
			if(activationcode <= 0){
			text1.SetActive(true);
			text2.SetActive(true);
			text3.SetActive(true);
			}
		}
	}
}
