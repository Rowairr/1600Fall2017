using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshAI : MonoBehaviour {
public Transform player;
public NavMeshAgent agent;
public static bool gameOver = false;
	void Update () {
		if (!gameOver){
			agent.destination = player.position;
		}
	}
}
