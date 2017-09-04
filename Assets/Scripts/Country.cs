using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Country : MonoBehaviour {

	public string Name;
	public Item[] Loot; //items of the country
	public Sprite Background; //background image of the country
	public Level[] Levels; //all levels of the country
	public Level CurrentLevel; 
	public int CurrentFame;
	public Character[] Citizens;

	public static Country[] LoadAll() {
		return Resources.LoadAll<Country>("Countries");
	}
}
