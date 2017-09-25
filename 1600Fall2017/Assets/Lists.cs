using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour {

public List<GameObject> myWeapons;
public List<GameObject> availableWeapons;
void OnTriggerEnter(Collider _weapon)
{
	myWeapons.Add(_weapon.gameObject);
}
}
