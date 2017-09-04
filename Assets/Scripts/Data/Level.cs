using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level", menuName = "MG/Level", order = 1)]
public class Level : ScriptableObject {

	public int LevelNum; 	
	public int RequiredFame;
	public Country Country;

	public static Level[] LoadAll() {
		return Resources.LoadAll<Level>("ScriptableObjects/Levels");
	}
}
