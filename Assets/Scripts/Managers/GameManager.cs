using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameMode
{
	MERCHANT, BASE, WORLD, COLLECT
}
	
public class GameManager : MonoBehaviour {

	public static GameManager _instance;

	public GameMode gameMode;

	public Merchant merchant;

	void Awake(){
		_instance = this;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
}
