﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBAR : MonoBehaviour {

public Image bar;

public Text endGameText;
public Text coinNum;
public int totalCoinValue;
public int coinValue = 10;
public GameObject GameOverUI;
public float powerLevel = 0.1f;
public float incrementAmount = 0.01f;
public static bool PowerUpsOff = false;
public GameObject cover;

public enum PowerUpType
{
	PowerUp,
	PowerDown,
	CollectCoin,
	Win,
	Umbrella
}
public PowerUpType powerUp;

	void Start()
	{
		cover.gameObject.SetActive(false);
	}
	void OnTriggerEnter () {
		if(!PowerUpsOff){
		switch (powerUp)
		{
			case PowerUpType.PowerUp:
				StartCoroutine(PowerUpBar());
			break;

			case PowerUpType.PowerDown:
				StartCoroutine(PowerDownBar());
			break;
			case PowerUpType.CollectCoin:
				StartCoroutine(CollectCoin());
			break;
			case PowerUpType.Win:
				EndGame("You Win!");
			break;
			case PowerUpType.Umbrella:
				Umbrella();
			break;
		}
	}
	}
	IEnumerator CollectCoin(){
		print("Coin Collected");
		totalCoinValue = int.Parse(coinNum.text);
		//coinNum.text = (totalCoinValue + coinValue).ToString();
		int tempAmount = totalCoinValue + coinValue;
		while (totalCoinValue <= tempAmount){
			coinNum.text = (totalCoinValue++).ToString();
			yield return new WaitForFixedUpdate();
		}
		gameObject.SetActive(false);
	}

	IEnumerator PowerUpBar () {
		float tempAmount = bar.fillAmount + powerLevel;
		if (tempAmount > 1){
			tempAmount = 1;
		}
		while (bar.fillAmount < 1)
		{
			bar.fillAmount += incrementAmount;
			yield return new WaitForSeconds(incrementAmount);
		}
		gameObject.SetActive(false);
		}
	IEnumerator PowerDownBar () {
		float tempAmount = bar.fillAmount - powerLevel;
		if(tempAmount < 0){
			tempAmount = 0;
		}
		while (bar.fillAmount > tempAmount)
		{
			bar.fillAmount -= incrementAmount;
			
			yield return new WaitForSeconds(incrementAmount);
		}
		gameObject.SetActive(false);
		
		if (bar.fillAmount == 0){
			EndGame("GAME OVER");
		}
	}
	void Umbrella () {
		if(bar.fillAmount == 1)
		{
			cover.SetActive(true);
		}
		else
		{
			StartCoroutine(PowerUpBar());
		}
		gameObject.SetActive(false);	
	}
	void EndGame (string _text){
		endGameText.text = _text;
		GameOverUI.SetActive(true);
		CharacterControl.gameOver = true;
		NavMeshAI.gameOver = true;
		CheckPoint.gameOver = true;
		PowerUpsOff = true;
	}
}
