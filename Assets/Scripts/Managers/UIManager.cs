using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	public Text CurrentFame;
	public Text MaxFame;
	public Text ItemLeft;

	public void Initialize(CountryManager currentCountry, Merchant merchant){

		CurrentFame.text = currentCountry.CurrentFame + "";
		MaxFame.text = currentCountry.CurrentLevel.RequiredFame + "";
		ItemLeft.text = merchant.Store.Inventory.Item.Length + "";
	}

	public void OnNextLevel(Level level){
		MaxFame.text = level.RequiredFame + "";
	}

	public void OnAddFame(int currentFame){
		CurrentFame.text = currentFame + "";
	}

	public void OnSellItem(int itemCount){
		ItemLeft.text = itemCount + "";
	}


}
