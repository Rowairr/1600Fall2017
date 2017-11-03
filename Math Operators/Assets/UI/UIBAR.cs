using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBAR : MonoBehaviour {

public Image bar;
public GameObject GameOverUI;
public float powerLevel = 0.1f;
public float incrementAmount = 0.01f;


public enum PowerUpType
{
	PowerUp,
	PowerDown
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
			GameOverUI.SetActive(true);
			CharacterControl.gameOver = true;
		}
	}
}
