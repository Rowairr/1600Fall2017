using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidFunctions : MonoBehaviour {
	public string[] Squashing = {"Bug", "Fruit", "Pot"};
	public int[] SquashCount = {1, 1,1};
	public string[] Pickup = {"Rock", "Weapon", "Artifact"};
	public int[] PickupCount = {3, 1, 2};
	public string[] Powerup = {"Health Regen", "Mana Regen", "Invulnerability"};
	public string[] MagicItems = {"Scepter", "Talking Rock", "Barking Twig"};
	public int[] MagicCollection = {1, 1, 2};
	public string[] BadStuff = {"Bats", "Rats", "Mother-in-law's cooking"};
	public string[] Gems = {"Common Gem", "Rare Gem", "Epic Gem", "Ultimate Gem"};

	public void Start()
	{
		for(int i = 0; i < Squashing.Length; i++)
		{
			Squash(Squashing[i], SquashCount[i]);
			Gather(Pickup[i], PickupCount[i]);
			Strengthen(Powerup[i]);
			GatherM(MagicItems[i], MagicCollection[i]);
			Pain(BadStuff[i]);
		}
		for(int i = 0; i < Gems.Length; i++)
		{
			GemCollection(Gems[i]);
		}
	}
	void Squash(string bug, int amount){
		print(this.name + " squashed" + " " + bug);
		print(this.name + " squashed" + " " + amount + " " + bug);
	}
	void GemCollection(string gem){
		print(this.name + " acquired" + " " + gem);
	}
	void Gather(string junk, int amount){
		print(this.name + " gathered" + " " + junk);
		print(this.name + " gathered" + " " + amount + " " + junk);
	}
	void GatherM(string magic, int amount){
		print(this.name + " has" + " a " + magic + " in his collection");
		print("There are " + amount + " " + magic + " in the collection");
	}
	void Pain(string pain){
		print(this.name + " is attacked by " + pain);
	}
	void Strengthen(string power){
		print(this.name + " has " + power);
	}

}
