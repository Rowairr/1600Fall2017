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
public int r = 5;
// This int can be affected by other scripts//
private int q = 4;
// This int can only be seen by in this script.//
internal int m = 7;
// This int can only be affected by this script//
protected int p = 12;
/* This int can only be affected by classes derived from this class. Such as if 
this script were in the Animal class we did earlier, it would only be able to be
affected by the breakoffs (such as whale, human, and fish)*/
/* I don't really have anything else to add, so I'll just finish with three
more examples*/
public string king = "Royal";
public float kk = 0.02f;
private string d = "Done";




}
