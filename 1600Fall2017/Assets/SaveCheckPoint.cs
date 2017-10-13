using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveCheckPoint : MonoBehaviour {
	Vector3 checkPoint;
	
	string[] PlayerPrefsTitles = {"CheckPointX", "CheckPointY", "CheckPointZ"};
	public Transform player;
	
	void OnTriggerEnter()
	{
		checkPoint = transform.position;
		for (int i = 0; i < PlayerPrefsTitles.Length; i++)
		{
			PlayerPrefs.SetFloat(PlayerPrefsTitles[i], checkPoint[i]);
		}
	}
	void Start()
	{
		for (int i = 0; i < PlayerPrefsTitles.Length; i++)
		{
			checkPoint[i] = PlayerPrefs.GetFloat(PlayerPrefsTitles[i]);
		}
		player.position = checkPoint;
	}

}
