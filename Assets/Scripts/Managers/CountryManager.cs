using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountryManager : MonoBehaviour {

	public static CountryManager _instance;

	public UIManager uiManager;

	public Country CurrentCountry;
	public int CurrentFame;
	public Level CurrentLevel;


	void Awake(){
		_instance = this;
	}

	// Use this for initialization
	void Start () {

		uiManager.Initialize (CurrentCountry, GameManager._instance.merchant);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public bool AddFameToCountry(Character ch){
		CurrentCountry.CurrentFame += GameManager._instance.merchant.Charm;
		CharacterSpawnManager._instance.DeSpawnEntity (ch);

		return true;

	}
		
}
