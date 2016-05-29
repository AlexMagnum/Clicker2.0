using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour {
	public UnityEngine.UI.Text itemInfo;
	public Click click;
	public float cost;
	public int tickValue;
	public int count;
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
		itemInfo.text = itemName + "(" + count + ")" + "\nCost: " + cost + "\nDamage: " + tickValue + "/s";

		_slider.value = click.gold / cost * 100; 

		if (_slider.value >= 100) {
			GetComponent<Image> ().color = affordable;
		} else {
			GetComponent<Image> ().color = standart;
		}
	}

	public void PurchaseItem(){
		if (click.gold >= cost) {
			click.gold -= cost;
			count += 1;
			cost = Mathf.Round(baseCost * Mathf.Pow( 1.15f, count));
		}
	}
}
