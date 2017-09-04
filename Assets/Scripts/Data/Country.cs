using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Country", menuName = "MG/Country", order = 1)]
public class Country : ScriptableObject {

	public string Name;
	public Item[] Loot; //items of the country
	public Sprite Background; //background image of the country
	public Level[] Levels; //all levels of the country
	public string[] Citizens;

	public static Country[] LoadAll() {
		return Resources.LoadAll<Country>("ScriptableObjects/Countries");
	}
}
