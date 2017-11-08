using System.Collections;
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


public enum PowerUpType
{
	PowerUp,
	PowerDown,
	CollectCoin,
	Win
}
public PowerUpType powerUp;
	void OnTriggerEnter () {

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
			//start the coroutine "CollectCoin"
			break;
			case PowerUpType.Win:
				EndGame("You Win!");
			break;
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
		
		if (bar.fillAmount == 0){
			EndGame("Game Over");
		}
	}
	void EndGame (string _text){
		endGameText.text = _text;
		GameOverUI.SetActive(true);
		CharacterControl.gameOver = true;
	}
}
