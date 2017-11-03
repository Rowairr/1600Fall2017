using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListsArrays : MonoBehaviour {

private string[] MeleeWeapons = new string[3];
private string[] RangedWeapons = new string[2];
private string[] ChestItems = new string [3];
private string[] ArmItems = new string [2];
private string[] LegItems = new string [2];
private string[] FeetItems = new string [2];
private string[] Spells = new string [4];
private string[] Enchantments = new string [2];
private string[] Pets = new string [3];
private string[] Companions = new string [3];
void Start(){
MeleeWeapons[0] = "Knuckles";
MeleeWeapons[1] = "Sword";
MeleeWeapons[2] = "Axe";

RangedWeapons[0] = "Bow";
RangedWeapons[1] = "Crossbow";

ChestItems[0] = "Wooden Breastplate";
ChestItems[1] = "Stone Breastplate";
ChestItems[2] = "Steel Breastplate";

ArmItems [0] = "Leather Wraps";
ArmItems [1] = "Steel Wraps";

LegItems [0] = "Leather Pants";
LegItems [1] = "Steel Pants";

FeetItems [0] = "Leather Boots";
FeetItems [1] = "Steel Boots";

Spells [0] = "Fireball";
Spells [1] = "Ice Blast";
Spells [2] = "Dark Storm";
Spells [3] = "Light Spear";

Enchantments [0] = "Damage";
Enchantments [1] = "Protection";

Pets [0] = "Dog";
Pets [1] = "Frenzied Manticore";

Companions [0] = "Biff the Strong";
Companions [1] = "Bella the Brave";
Companions [2] = "Grokland the Sniveling";
}
void Update()
{
	foreach(string m in MeleeWeapons){
		print(m + "");
	}
	foreach(string r in RangedWeapons){
		print(r + "");
	}
	foreach(string c in ChestItems){
		print(c + "");
	}
	foreach(string a in ArmItems){
		print(a + "");
	}
	foreach(string l in LegItems){
		print(l + "");
	}
	foreach(string f in FeetItems){
		print(f + "");
	}
	foreach(string s in Spells){
		print(s + "");
	}
	foreach(string e in Enchantments){
		print(e + "");
	}
	foreach(string p in Pets){
		print(p + "");
	}
	foreach(string co in Companions){
		print(co + "");
	}
}
}
