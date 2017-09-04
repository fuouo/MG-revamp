using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawnManager : MonoBehaviour {

	public static CharacterSpawnManager _instance;

	public GameObject MerchantSpawnArea;

	public int maxEntitySpawnCount;
	public GameObject CitizenSpawnArea;
	public GameObject MonsterSpawnArea;

	[SerializeField]
	bool isSpawning = true;



	void Awake(){
		_instance = this;
	}

	// Use this for initialization
	void Start () {
		InvokeRepeating("SpawnCitizens", 2.0f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SpawnCitizens(){
		if (isSpawning && !CheckIfValidEntityCount ()) { //if the spawner is spawning, but the count is invalid 
			CancelInvoke ("SpawnCitizens");
			isSpawning = false;
			return;
		}

		SpawnEntity (CountryManager._instance.CurrentCountry.Citizens);
	}

	bool CheckIfValidEntityCount(){
		if (CitizenSpawnArea.transform.childCount > maxEntitySpawnCount ||
			MonsterSpawnArea.transform.childCount > maxEntitySpawnCount ||
			CitizenSpawnArea.transform.childCount + MonsterSpawnArea.transform.childCount > maxEntitySpawnCount) {
			return false;
		}
		return true; 

	}


	public void DeSpawnEntity(Character ch){
		Destroy (ch.gameObject);

		if (CheckIfValidEntityCount () && !isSpawning) {
			InvokeRepeating("SpawnCitizens", 2.0f, 1.0f);
			isSpawning = true;
		}

	}


	void SpawnEntity(string[] entities){

		var negXBound = -CitizenSpawnArea.GetComponent<SpriteRenderer> ().bounds.max.x;
		var posXBound = CitizenSpawnArea.GetComponent<SpriteRenderer> ().bounds.max.x;
		var upYBound = CitizenSpawnArea.GetComponent<SpriteRenderer> ().bounds.max.y;
		var lowYBound = CitizenSpawnArea.GetComponent<SpriteRenderer> ().bounds.min.y;

		var randomIndex = (int) Random.Range (0, 1);
 
		GameObject entity = (GameObject) Instantiate (Resources.Load(FilePath.CITIZEN_PREFAB_FOLDER + "/" + entities [randomIndex]));
		entity.transform.SetParent (CitizenSpawnArea.transform);

		Vector2 position = Vector2.zero;

		do {

			position = new Vector2 (
				Random.Range (negXBound, posXBound), //random x position
				Random.Range (lowYBound, upYBound) //random y position
			);



		} while(!IsPositionValid (position, MerchantSpawnArea));

		entity.transform.position = position;

		//entity is default looking to the left
		if (position.x < CitizenSpawnArea.GetComponent<SpriteRenderer> ().bounds.center.x) {
			//must look to the right
			entity.transform.localScale = new Vector3(-entity.transform.localScale.x, entity.transform.localScale.y, entity.transform.localScale.z);
		} 
	}
		
	bool IsPositionValid(Vector2 position, GameObject NonSpawnArea){

		var negXBound = -NonSpawnArea.GetComponent<SpriteRenderer> ().bounds.max.x;
		var posXBound = NonSpawnArea.GetComponent<SpriteRenderer> ().bounds.max.x;
		var upYBound = NonSpawnArea.GetComponent<SpriteRenderer> ().bounds.max.y;
		var lowYBound = NonSpawnArea.GetComponent<SpriteRenderer> ().bounds.min.y;

		if (position.x <= posXBound && position.x >= negXBound &&
		   position.y <= upYBound && position.y >= lowYBound) {
			return false;
		}

		return true;
	}
}
