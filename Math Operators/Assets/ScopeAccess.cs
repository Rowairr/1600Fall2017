using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAccess : MonoBehaviour {
/*Access modifiers determine who and what has access to the code in your
scripts. */
public float x = 15; 
/* The public access modifier means that this float can be manipulated in
any program that I upload this to. It also means that it can be affected by
lines of code in this script as well as in other scripts.*/
private float y = 12;
/*The private access modifier means that this can only be modified by lines
of code within our c# script and cannot be seen in other programs. All lines
of code default to private unless stated otherwise. */


}
