using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartContainer : MonoBehaviour {

	public GameObject Character;

	public GameObject Container;
	public GameObject HeartPrefab;

	void InitHearts(){

		var maxSatisfaction = Character.GetComponent<Character> ().MaxSatisfaction;

		for (int i = 0; i < maxSatisfaction; i++) {
			GameObject heart = Instantiate (HeartPrefab);
			heart.transform.localScale = Vector3.one;
			heart.transform.SetParent (Container.transform);
		}

	}

	// Use this for initialization
	void Start () {

		//reposition heartcontainer on top of character
		//Container.transform.position = Camera.WorldToScreenPoint(Character.transform.position);


	}
	
	// Update is called once per frame
	void Update () {



	}
}
