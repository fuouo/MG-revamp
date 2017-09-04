using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Character : MonoBehaviour {

	public string Name;
	public Sprite Image; //TODO: much discussion
	public CharacterStatus Status;

	public int MaxSatisfaction;
	public int CurrentSatisfaction;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		Debug.Log ("Clicked " + Name);

		OnEntityTap ();

	}

	void OnEntityTap(){
		CurrentSatisfaction++;
		if (CurrentSatisfaction >= MaxSatisfaction) {
			CountryManager._instance.AddFameToCountry(this);
			//notify a manager about destroying this entity
		}
	}
}
