using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnPowerup : MonoBehaviour {
	void OnTriggerEnter()
    {
        gameObject.SetActive(false);
    }
}
