using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReplayGame : MonoBehaviour {

	public Transform player;
	public Transform enemy;
	public Transform Powerups;
	public GameObject powerups;
	public Image uiBar;
	public GameObject GameOverUI;

	public static Vector3 startPosition;
	public static Vector3 enemyStart;
	public static Vector3 powerupstart;
	private float fillAmount;
	void Awake()
	{
		startPosition = player.position;
		enemyStart = enemy.position;
		fillAmount = uiBar.fillAmount;
		powerupstart = Powerups.position;
		GameOverUI.SetActive(false);
	}
	public void Click () {
		CharacterControl.gameOver = false;
		NavMeshAI.gameOver = false;
		UIBAR.PowerUpsOff = false;
		CheckPoint.gameOver = false;
		powerups.SetActive(true);
		player.position = startPosition;
		enemy.position = enemyStart;
		Powerups.position = powerupstart;
		uiBar.fillAmount = fillAmount;
		GameOverUI.SetActive(false);
	}
}
