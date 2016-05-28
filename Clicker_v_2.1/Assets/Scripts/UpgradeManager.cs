using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour {

	public Click click;
	public UnityEngine.UI.Text itemInfo;
	public float cost;
	public int count = 0;
	public int clickPower;
	public string itemName;
	public Color standart;
	public Color affordable;
	private float baseCost;
	private Slider _slider;

	void Start(){
		baseCost = cost;
		_slider = GetComponentInChildren<Slider> (); 
	}

	void Update(){
		itemInfo.text = itemName + "(" + count + ")" + "\nCost:  " + cost + "\nPower +" + clickPower;	

		_slider.value = click.gold / cost * 100; 

		if (_slider.value >= 100) {
			GetComponent<Image> ().color = affordable;
		} else {
			GetComponent<Image> ().color = standart;
		}
	}

	public void PurchasedUpgrade(){
		if (click.gold >= cost) {
			click.gold -= cost;
			count += 1;
			click.goldPerClick += clickPower;
			cost = Mathf.Round(baseCost * Mathf.Pow (1.15f, count));
		}
	}
}
