using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactionsScript : MonoBehaviour {
public int strength = 7;
public int divinity = 1;
public int stamina = 4;
public int speechcraft = 2;
public int corruption = 0;
public int charisma = 3;
public int accuracy = 2;
public int brutality = 6;
public int willpower = 2;
public int vision = 4;
void Intimidate()
{
	switch(strength)
	{
		case 7:
			print("You're going to do what I say or I'll snap you in half");
			break;
		case 6:
			print("My fist is about to go straight through your rib cage");
			break;
		case 5:
			print("Out of the way weakling");
			break;
		case 4:
			print("You're in my way");
			break;
		case 3:
			print("Move");
			break;
		case 2:
			print("There will be...consequences? If you don't move...");
			break;
		case 1:
			print("Please move.");
			break;
		default:
			print("Isuffiient Stats");
			break;
	}
}
void Awe()
	{
		switch(divinity)
			{
				case 3:
					print("Behold me and tremble mortal");
					break;
				case 2:
					print("Your affairs are of little use to me");
					break;
				case 1:
					print("You need not fear me, I'm like you");
					break;
				default:
					print("You are not divine");
					break;
	}
	}
void Endurance()
		{
			switch(stamina)
			{
				case 7: 
					print("You complete the action without even the slightest hint of difficulty");
					break;
				case 6:
					print("A single bead of sweat drops as you finish the challenge");
					break;
				case 5:
					print("That was of negligible difficulty");
					break;
				case 4:
					print("Looks like you need a breather");
					break;
				case 3:
					print("You need to fight some more hobgoblins if you're panting that hard");
					break;
				case 2:
					print("You really should've let someone stronger do that");
					break;
				case 1:
					print("I'm surprised you didn't die");
					break;
				default:
					print("There's no way you can do that");
					break;
			}
		}
void Speak()
			{
				switch(speechcraft)
				{
					case 3:
						print("They give you what you want, and all their worldly possessions to boot");
						break;
					case 2:
						print("They give you what you want and offer you more");
						break;
					case 1:
						print("They give you what you want");
						break;
					default:
						print("There's no way you can convince them");
						break;
				}
			}
void Enslave()
	{
		switch(corruption)
		{
			case 3:
				print("Your power completely corrupts them");
				break;
			case 2:
				print("They become enslaved to your will");
				break;
			case 1:
				print("They obey you... For now.");
				break;
			default:
				print("You cannot corrupt");
				break;
		}	
	}
void Cohersion()
	{
		switch(charisma)
		{
			case 3:
				print("You're good looks and great personality persuade them");
				break;
			case 2:
				print("You're good looks persuade them... or maybe it was your personality");
				break;
			case 1:
				print("Hey they did it! They must have felt bad for you.");
				break;
			default:
				print("You're too ugly to use this skill");
				break;
		}
	}
void Accuracy()
	{
		switch(accuracy)
			{
				case 3:
					print("You score a critical!");
					break;
				case 2:
					print("You hit them");
					break;
				case 1:
					print("Your hit wasn't as efficient");
					break;
				default:
					print("You miss");
					break;
			}
	}
void Savagery()
	{
		switch(brutality)
			{
				case 7:
					print("You gain extra loot and health from your conquest");
					break;
				case 6:
					print("You gain extra loot from your conquest");
					break;
				case 5:
					print("You find a map in your conquest");
					break;
				case 4:
					print("You find extra gold on your conquest");
					break;
				case 3:
					print("The townsfolk are more susceptible to your intimidates");
					break;
				case 2:
					print("The townsfolk are more susceptible to your cohersions");
					break;
				case 1:
					print("You brutalize the body for no apparent reason");
					break;
				default:
					print("Error: Brutality stat not found");
					break;
			}
	}
void Will()
	{
		switch(willpower)
		{
			case 3:
				print("You are master of your own decisions. Counter-Corrupt available");
				break;
			case 2:
				print("Enemy's Corruption attempt failed");
				break;
			case 1:
				print("Enemy's Corruption attempt was partially successful. Next corruption attempt will succeed");
				break;
			default:
				print("Your will is not your own");
				break;
		}
	}
void Vision()
	{
		switch(vision)
		{
			case 7:
				print("Nothing is, nor can be, kept from you. You detect all enemies and hidden objects");
				break;
			case 6:
				print("No where to hide. All enemies are revealed");
				break;
			case 5:
				print("I see you. All enemies without hidden are revealed");
				break;
			case 4:
				print("I can kind of see you. All enemies in line of sight revealed");
				break;
			case 3:
				print("Vision insufficient for benefits");
				break;
			case 2:
				print("Your eyesight is impaired. Some enemies gain hidden");
				break;
			case 1:
				print("You can hardly see. Most enemies gain hidden, accuracy decreased");
				break;
			default:
				print("You are blind. All enemies have hidden, accuracy greatly decreased");
				break;
		}
	}

}



		

