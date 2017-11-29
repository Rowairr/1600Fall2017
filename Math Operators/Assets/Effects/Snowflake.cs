using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Snowflake : MonoBehaviour {
public Transform parent;
public Transform flake;
	void OnCollisionEnter(Collision other)
	{
		flake.position = parent.position;
		}
	}
