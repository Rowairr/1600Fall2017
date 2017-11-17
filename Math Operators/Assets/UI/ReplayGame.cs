﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReplayGame : MonoBehaviour {

	public Transform player;
	public Transform enemy;
	public Image uiBar;
	public GameObject GameOverUI;

	public static Vector3 startPosition;
	public static Vector3 enemyStart;
	private float fillAmount;
	void Awake()
	{
		startPosition = player.position;
		enemyStart = enemy.position;
		fillAmount = uiBar.fillAmount;
		GameOverUI.SetActive(false);
	}
	public void Click () {
		CharacterControl.gameOver = false;
		NavMeshAI.gameOver = false;
		UIBAR.PowerUpsOff = false;
		CheckPoint.gameOver = false;
		player.position = startPosition;
		enemy.position = enemyStart;
		uiBar.fillAmount = fillAmount;
		GameOverUI.SetActive(false);
	}
}
