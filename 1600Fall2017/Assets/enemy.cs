using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour {
	public NavMeshAgent agent;
	public Transform player;
	void Update () {
		agent.destination = player.position;
	}
	public void Stun (float speed){
		agent.speed = speed;
		agent.acceleration = speed;
	}
}
