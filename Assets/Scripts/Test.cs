using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Country[] countries = Country.LoadAll();
		for (int i = 0; i < countries.Length; i++) {
			Debug.Log("Mode: " + countries[i].name);
			countries [i].name = "derp";
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
