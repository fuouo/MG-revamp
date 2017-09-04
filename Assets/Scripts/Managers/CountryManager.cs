using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountryManager : MonoBehaviour {

	public static CountryManager _instance;

	public UIManager uiManager;
	public GameObject background;


	public Country CurrentCountry;
	public Level CurrentLevel;
	public int CurrentFame;



	void Awake(){
		_instance = this;
	}

	// Use this for initialization
	void Start () {

		background.GetComponent<SpriteRenderer> ().sprite = CurrentCountry.Background;

		uiManager.Initialize (this, GameManager._instance.merchant);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public bool AddFameToCountry(Character ch){
		CurrentFame += GameManager._instance.merchant.Charm;
		CharacterSpawnManager._instance.DeSpawnEntity (ch);
		uiManager.OnAddFame (CurrentFame);

		return true;

	}
		
}
