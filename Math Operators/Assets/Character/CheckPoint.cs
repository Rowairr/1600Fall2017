using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

public static bool gameOver = false;

	
	void OnTriggerEnter(){
		if(!gameOver){
			ReplayGame.startPosition = transform.position;
	}
}
}
