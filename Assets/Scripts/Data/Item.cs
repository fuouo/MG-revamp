using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "MG/Item", order = 1)]
public class Item : ScriptableObject {

	public string Name;
	public Sprite Image; 
	public float Rarity; //how rare is it to get it
	public float Worth; //how much is it to be sold

	public static Item[] LoadAll() {
		return Resources.LoadAll<Item>("ScriptableObjects/Items");
	}
}
